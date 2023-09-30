using System;
using Dong_bo_cham_cong.Dto;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;
using RestSharp;
using Dong_bo_cham_cong.Repositories;

namespace Dong_bo_cham_cong
{
  public partial class frm_log : Form
  {
    private string path = Application.StartupPath + "/Data/Device.xml";
    private string path_device_vnEdu = Application.StartupPath + "/Data/Device_vnEdu.xml";
    private readonly LogHikvisionRepository logHikvisionRepository = new LogHikvisionRepository();
    public int id;
    private int numberRecord = 20;
    private static int totalPage = 0;

    public frm_log()
    {
      InitializeComponent();
    }

    private void frm_log_Load(object sender, EventArgs e)
    {

      numberRecord = 30;
      totalPage = 0;
      load_data();
    }

    private List<Info> get_data_events(int page)
    {
      XDocument xmlObject = XDocument.Load(path);

      XElement deviceXml = xmlObject.Descendants("Device").Where(c => Int32.Parse(c.Element("Id").Value) == id).FirstOrDefault();
      if (deviceXml != null)
      {
        try
        {

          //string start_time = "2023-04-06T00:00:00+07:00";
          //string end_time = "2023-04-07T23:59:59+07:00";
          //string start_time = txt_tungay.Value.ToString("yyyy-MM-ddT00:00:00+07:00");
          //string end_time = txt_denngay.Value.ToString("yyyy-MM-ddT23:59:59+07:00");

          Device device = new Device();
          device.Ip = deviceXml.Element("Ip").Value;
          device.Port = deviceXml.Element("Port").Value;
          device.Username = deviceXml.Element("Username").Value;
          device.Password = deviceXml.Element("Password").Value;

          int totalMatches = logHikvisionRepository.getTotalEvent(txt_tungay.Value, txt_denngay.Value, device);
          totalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalMatches) / Convert.ToDouble(numberRecord)));
          lb_totalPage.Text = totalPage.ToString();

          List<Info> infoList = logHikvisionRepository.getListEvents(txt_tungay.Value, txt_denngay.Value, device, page, numberRecord);

          return infoList;
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
          return new List<Info>();
        }
      }
      else
      {
        return new List<Info>();
      }
    }

    private void load_data()
    {
      List<Info> infos = get_data_events(Convert.ToInt32(txt_page.Text));
      grv_logs.DataSource = infos;

      if (infos.Count > 0)
      {
        btn_dongbo.Enabled = true;
        btn_dongbo_vnEdu.Enabled = true;
      }
      else
      {
        btn_dongbo.Enabled = false;
        btn_dongbo_vnEdu.Enabled = false;
      }
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btn_search_Click(object sender, EventArgs e)
    {
      load_data();
    }

    private void txt_page_TextChanged(object sender, EventArgs e)
    {
      load_data();
      check_status_pagination();
    }

    private void check_status_pagination()
    {
      int currentPage = 1;

      if (Int32.TryParse(txt_page.Text, out int number))
      {
        currentPage = number;
      }

      if (currentPage > 1 & currentPage < totalPage)
      {
        btn_trangTruoc.Enabled = true;
        btn_trangSau.Enabled = true;
      }
      else
      {
        if (currentPage <= 1)
        {
          btn_trangTruoc.Enabled = false;
        }
        if (currentPage >= totalPage)
        {
          btn_trangSau.Enabled = false;
        }
      }
    }

    private void btn_trangTruoc_Click(object sender, EventArgs e)
    {
      int currentPage = 1;

      if (Int32.TryParse(txt_page.Text, out int number))
      {
        currentPage = number;
      }
      currentPage--;
      btn_trangTruoc.Enabled = true;
      txt_page.Text = currentPage.ToString();

      check_status_pagination();
    }

    private void btn_trangSau_Click(object sender, EventArgs e)
    {
      int currentPage = 1;

      if(Int32.TryParse(txt_page.Text, out int number))
      {
        currentPage = number;
      }
      currentPage++;
      btn_trangSau.Enabled = true;
      txt_page.Text = currentPage.ToString();

      check_status_pagination();
    }

    private void txt_page_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^1-9]"))
      {
        e.Handled = true;
      }
    }

    private void btn_dongbo_Click(object sender, EventArgs e)
    {
      List<int> serialList = new List<int>();

      for (int i = 1; i <= totalPage; i++)
      {
        List<Info> listEvents = get_data_events(i);
        foreach (Info _event in listEvents)
        {
          if (_event.employeeNoString != "" && !string.IsNullOrEmpty(_event.employeeNoString))
          {
            string dateCheckin = Convert.ToDateTime(_event.time).ToString("yyyy-MM-dd HH:mm:ss");

            var client = new RestClient("http://localhost:52149/api/apiCheckin/Post");
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            string queryString = "{" +
              "\"_userCode\": \"" + _event.employeeNoString + "\"," +
              "\"_dateCheckin\": \"" + dateCheckin + "\"," +
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
              serialList.Add(_event.serialNo);
            }
          }
        }
      }  

      if(serialList.Count == 0)
      {
        MessageBox.Show("Đồng bộ dữ liệu thành công !");
      }
      else
      {
        MessageBox.Show("Đã có lỗi tại dòng: "+ string.Join(",", serialList.ToArray()));
        return;
      }
    }

    private void btn_dongbo_vnEdu_Click(object sender, EventArgs e)
    {
      List<int> serialList = new List<int>();

      ApiCheckIn.VnEdu vnEdu = new ApiCheckIn.VnEdu();
      for (int i = 1; i <= totalPage; i++)
      {
        List<Info> listEvents = get_data_events(i);
        foreach (Info _event in listEvents)
        {
          if (_event.employeeNoString != "" && !string.IsNullOrEmpty(_event.employeeNoString))
          {
            XDocument xmlObject = XDocument.Load(path);
            XElement device = xmlObject.Descendants("Device").Where(c => Int32.Parse(c.Element("Id").Value) == id).FirstOrDefault();
            
            XDocument xmlObjectvnEdu = XDocument.Load(path_device_vnEdu);
            XElement devicevnEdu = xmlObjectvnEdu.Descendants("Device").Where(c => c.Element("Ma").Value == device.Element("Ma").Value).FirstOrDefault();

            if (devicevnEdu == null)
            {
              MessageBox.Show("Chưa cấu hình thiết bị điểm danh vnEdu !");
              return;
            }

            string SN_MayDiemDanh_vnEdu = devicevnEdu.Element("SN_vnEdu").Value;
            string Key_vnEdu = devicevnEdu.Element("Key_vnEdu").Value;

            string result = vnEdu.checkin(SN_MayDiemDanh_vnEdu, Key_vnEdu, _event.employeeNoString, Convert.ToDateTime(_event.time).ToString("yyyy-MM-dd HH:mm:ss"));

            if (result != "OK")
            {
              serialList.Add(_event.serialNo);
            }
          }
        }
      }

      if (serialList.Count == 0)
      {
        MessageBox.Show("Đồng bộ dữ liệu thành công !");
      }
      else
      {
        MessageBox.Show("Đã có lỗi tại dòng: " + string.Join(",", serialList.ToArray()));
        return;
      }
    }
  }
}
