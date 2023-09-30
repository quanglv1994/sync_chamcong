using RestSharp;
using GATEWAY_SDK;
using Dong_bo_cham_cong.Dto;
using Dong_bo_cham_cong.Enums;
using Dong_bo_cham_cong.Ultils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using Dong_bo_cham_cong.Repositories;

namespace Dong_bo_cham_cong
{
  public partial class Sync_logs : Form
  {
    private string path = Application.StartupPath + "/Data/Device.xml";
    public static List<Log> listLogs;
    private readonly LogHikvisionRepository logHikvisionRepository = new LogHikvisionRepository();

    public Sync_logs()
    {
      InitializeComponent();
    }

    private void Sync_logs_Load(object sender, EventArgs e)
    {
      load_data_async();
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void load_data_async()
    {
      using (WatingForm waitingForm = new WatingForm(load_data, "Đang lấy dữ liệu máy chấm công. Vui lòng đợi ..."))
      {
        waitingForm.ShowDialog(this);
      }
    }

    private void load_data()
    {

      listLogs = new List<Log>();

      try
      {
        XDocument xmlObject = XDocument.Load(path);

        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path);
        DataTable dt = new DataTable();
        dt = dataSet.Tables["Device"];
        if (dt != null)
        {
          int i = 1;
          foreach (DataRow dr in dt.Rows)
          {
            Device device = new Device();
            device.Ip = dr["Ip"].ToString();
            device.Port = dr["Port"].ToString();
            device.Username = dr["Username"].ToString();
            device.Password = dr["Password"].ToString();

            VendorType _hang = (VendorType)Enum.Parse(typeof(VendorType), dr["Hang"].ToString(), true);

            SDK_Hikvision hik = new SDK_Hikvision("http://" + device.Ip + ":" + device.Port, device.Username, device.Password);

            if (_hang == VendorType.Hikvision)
            {
              if (hik.login())
              {
                int page = 1;
                int numberRecord = 30;
                int totalPage = 1;
                int totalMatches = logHikvisionRepository.getTotalEvent(txt_tungay.Value, txt_denngay.Value, device);

                totalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalMatches) / Convert.ToDouble(numberRecord)));
                get_data_log:
                if (page <= totalPage)
                {
                  List<Info> infoList = logHikvisionRepository.getListEvents(txt_tungay.Value, txt_denngay.Value, device, page, numberRecord);

                  foreach (Info log in infoList)
                  {
                    listLogs.Add(new Log()
                    {
                      Stt = i,
                      UserCode = log.employeeNoString,
                      Name = log.name,
                      Time = Convert.ToDateTime(log.time),
                      Attendance = log.attendanceStatus,
                      Ip_Device = dr["Ip"].ToString(),
                      Serial_Device = dr["Ma"].ToString()
                    });
                    i++;
                  }
                  page++;
                  goto get_data_log;

                }
              }
              else
              {
                string message = "Không thể kết nối được đến máy chấm công " + "http://" + dr["Ip"].ToString() + ":" + dr["Port"].ToString();
                MessageBox.Show(message);
              }
            }
          }

        }
        if (listLogs.Count > 0)
        {
          btn_dongbo.Invoke(new Action(() => { btn_dongbo.Enabled = true; }));
        }
        else
        {
          btn_dongbo.Invoke(new Action(() => { btn_dongbo.Enabled = false; }));
        }
      }
      catch (Exception err)
      {
        btn_dongbo.Invoke(new Action(() => { btn_dongbo.Enabled = false; }));
        MessageBox.Show(err.Message);
      }
      grv_logs.Invoke(new Action(() => { grv_logs.DataSource = listLogs; }));
    }

    private void dong_bo()
    {
      if(listLogs != null)
      {
        BoxLoading boxLoading = new BoxLoading("Đang tải đồng bộ dữ liệu chấm công. Vui lòng chờ ...");
        boxLoading.ShowDialog();

        List<int> sttList = new List<int>();
        foreach (Log _log in listLogs)
        {
          if (_log.UserCode != "" && !string.IsNullOrEmpty(_log.UserCode))
          {
            var client = new RestClient("http://localhost:52149/api/apiCheckin/Post");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            string queryString = "{" +
              "\"_userCode\": \"" + _log.UserCode + "\"," +
              "\"_dateCheckin\": \"" + _log.Time.ToString() + "\"," +
              "\"_user\": 1" +
              "}";
            request.AddParameter("application/json", queryString, ParameterType.RequestBody);
            var response = client.Execute(request);
            var result = response.Content;
            if (response.StatusCode == 0)
            {
              MessageBox.Show("Không thể kết nối được API đồng bộ chấm công !");
              return;
            }

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
              sttList.Add(_log.Stt);
            }
          }
        }

        boxLoading.Close();

        if (sttList.Count == 0)
        {
          MessageBox.Show("Đồng bộ dữ liệu thành công !");
        }
        else
        {
          MessageBox.Show("Đã có lỗi tại dòng: " + string.Join(",", sttList.ToArray()));
          return;
        }
      }  
    }

    private void btn_search_Click(object sender, EventArgs e)
    {
      load_data_async();
    }

    private void btn_dongbo_Click(object sender, EventArgs e)
    {
      dong_bo();
    }
  }
}
