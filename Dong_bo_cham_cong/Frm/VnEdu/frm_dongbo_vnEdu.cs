using GATEWAY_SDK;
using Dong_bo_cham_cong.Dto;
using Dong_bo_cham_cong.Enums;
using Dong_bo_cham_cong.Ultils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Win32;
using Dong_bo_cham_cong.Repositories;
using System.Text.Json;

namespace Dong_bo_cham_cong.Frm.VnEdu
{
  public partial class frm_dongbo_vnEdu : Form
  {
    private readonly string path_file_data = Application.StartupPath + "/Data/Log.xml";
    private readonly string schema = "VnEdu";
    private readonly string runReg = @"Software\Dong_bo_cham_cong";
    private readonly string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
    private readonly string appName = "Dong_bo_cham_cong";
    private readonly string pathProgram = Path.Combine(Application.StartupPath, "Dong_bo_cham_cong.exe");
    private readonly LogHikvisionRepository logHikvisionRepository = new LogHikvisionRepository();

    public frm_dongbo_vnEdu()
    {
      InitializeComponent();
    }

    private void frm_dongbo_vnEdu_Load(object sender, EventArgs e)
    {
      panel1.Controls.Add(new uc_MainMenu());

      var prevOpenedForm = Application.OpenForms.Cast<Form>().First();

      if (prevOpenedForm.Name == this.Name)
      {
        btn_close.Visible = false;
      }
     
      //load_data();
      load_logs();
      //run_jobs();

      check_tudongchay();
    }
    private void check_tudongchay()
    {
      RegistryKey myReg = Registry.CurrentUser.OpenSubKey(runReg, true);
      RegistryKey myStart = Registry.CurrentUser.OpenSubKey(runKey, true);

      if (myReg != null && myStart.GetValue(appName) != null)
      {
        tuDongChayToolStripMenuItem.Visible = false;
        tatTudongChayToolStripMenuItem.Visible = true;
        this.WindowState = FormWindowState.Minimized;
      }
      else
      {
        tuDongChayToolStripMenuItem.Visible = true;
        tatTudongChayToolStripMenuItem.Visible = false;
      }

    }
    private void load_logs()
    {
      if (!File.Exists(path_file_data))
      {
        return;
      }
      XDocument xmlObject = XDocument.Load(path_file_data);
      IEnumerable<XElement> logs = xmlObject.Descendants("Log").OrderByDescending(l => DateTime.Parse(l.Element("Created_at").Value)).ToList();

      if (logs != null)
      {
        ltLogs.Invoke(new Action(() => { ltLogs.Clear(); }));
        foreach (XElement _log in logs)
        {
          var listViewItem = new ListViewItem(_log.Element("Created_at").Value + ": " + _log.Element("Message").Value);
          ltLogs.Invoke(new Action(() => { ltLogs.Items.Add(listViewItem); }));
        }
      }
    }

    private void load_data_async()
    {
      using (WatingForm waitingForm = new WatingForm(load_data, "Đang lấy dữ liệu máy chấm công. Vui lòng đợi ..."))
      {
        waitingForm.ShowDialog(this);
      }
    }

    private List<Log> getLogDevice(DateTime tu_ngay, DateTime den_ngay, bool saveLog = false)
    {
      List<Log> listLogDevices = new List<Log>();

      try
      {
        string path_device = Application.StartupPath + "/Data/Device.xml";

        if (!File.Exists(path_device))
        {
          return new List<Log>();
        }

        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path_device);
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
                int totalMatches = logHikvisionRepository.getTotalEvent(tu_ngay, den_ngay, device);

                totalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalMatches) / Convert.ToDouble(numberRecord)));
                get_data_log:
                if (page <= totalPage)
                {
                  List<Info> infoList = logHikvisionRepository.getListEvents(txt_tungay.Value, txt_denngay.Value, device, page, numberRecord);

                  foreach (Info log in infoList)
                  {
                    listLogDevices.Add(new Log()
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
                if (saveLog)
                {
                  SaveLog("Error", message);
                }
              }
            }
          }

        }
        if (listLogDevices.Count > 0)
        {
          btn_dongbo.Invoke(new Action(() => { btn_dongbo.Enabled = true; }));
        }
        else
        {
          btn_dongbo.Invoke(new Action(() => { btn_dongbo.Enabled = false; }));
        }
      }
      catch (Exception ex)
      {
        listLogDevices = null;
        btn_dongbo.Invoke(new Action(() => { btn_dongbo.Enabled = false; }));
        MessageBox.Show(ex.Message);
        if (saveLog)
        {
          SaveLog("Error", ex.Message);
        }
      }

      return listLogDevices;
    }

    private void load_data()
    {
      grv_logs.Invoke(new Action(() => { grv_logs.DataSource = getLogDevice(txt_tungay.Value, txt_denngay.Value); }));
    }

    private void dong_bo_async(DateTime tu_ngay, DateTime den_ngay)
    {
      if (FormWindowState.Minimized == this.WindowState)
      {
        dong_bo(tu_ngay, tu_ngay);
      }
      else
      {
        Action action = () => { dong_bo(tu_ngay, tu_ngay); };

        using (WatingForm waitingForm = new WatingForm(action, "Đang đồng bộ dữ liệu chấm công. Vui lòng đợi ..."))
        {
          waitingForm.ShowDialog(this);
        }
      }
    }
    private void SaveLog(string type, string message)
    {
      string created_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
      try
      {
        if (!File.Exists(path_file_data))
        {
          FileUtil.Init_Xml(path_file_data, schema);
        }

        XDocument xmlObject = XDocument.Load(path_file_data);

        XElement log = new XElement("Log",
          new XElement("Type", type),
          new XElement("Created_at", created_at),
          new XElement("Message", message)
        );
        xmlObject.Element(schema).Add(log);
        xmlObject.Save(path_file_data);
        load_logs();

        if (FormWindowState.Minimized == this.WindowState)
        {
          notifyIconSystem.ShowBalloonTip(5000, notifyIconSystem.BalloonTipTitle, string.Format("{0}: {1}", created_at, message), ToolTipIcon.Info);
        }
        else
        {
          MessageBox.Show(string.Format("{0}: {1}", created_at, message));
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("{0}: {1}", created_at, ex.Message));
      }
    }

    private void dong_bo(DateTime tu_ngay, DateTime den_ngay)
    {
      string typeLog = "Success";
      string message = "";
      var listLogDevices = getLogDevice(tu_ngay, den_ngay, saveLog: true);
      if (listLogDevices != null)
      {
        List<int> rowSyncCorrect = new List<int>();
        List<int> rowSyncFail = new List<int>();

        ApiCheckIn.VnEdu vnEdu = new ApiCheckIn.VnEdu();

        string path_device_vnEdu = Application.StartupPath + "/Data/Device_vnEdu.xml";

        if (!File.Exists(path_device_vnEdu))
        {
          return;
        }

        XDocument xmlObject = XDocument.Load(path_device_vnEdu);

        foreach (Log _log in listLogDevices)
        {
          if (_log.UserCode != "" && !string.IsNullOrEmpty(_log.UserCode))
          {
            XElement devicevnEdu = xmlObject.Descendants("Device").Where(c => c.Element("Ma").Value == _log.Serial_Device).FirstOrDefault();

            if (devicevnEdu == null)
            {
              message = "Chưa cấu hình thiết bị điểm danh vnEdu !";
              typeLog = "Error";
              return;
            }

            string SN_MayDiemDanh_vnEdu = devicevnEdu.Element("SN_vnEdu").Value;
            string Key_vnEdu = devicevnEdu.Element("Key_vnEdu").Value;

            string result = vnEdu.checkin(SN_MayDiemDanh_vnEdu, Key_vnEdu, _log.UserCode, _log.Time.ToString("yyyy-MM-dd HH:mm:ss"));

            if (result == "OK")
            {
              rowSyncCorrect.Add(_log.Stt);
            }
            else
            {
              //log not ok
              rowSyncFail.Add(_log.Stt);
            }
          }
        }

        if (rowSyncFail.Count == 0)
        {
          message = "Đồng bộ thành công " + rowSyncCorrect.Count + " bản ghi điểm danh !";
          typeLog = "Success";
          btn_dongbo.Invoke(new Action(() => { btn_dongbo.Enabled = false; }));
        }
        else
        {
          typeLog = "Error";
          message = "Đồng bộ thất bại " + rowSyncFail.Count + " bản ghi điểm danh | " + string.Join(",", rowSyncFail.ToArray());
        }

      }
      else
      {
        typeLog = "Error";
        message = "Không có dữ liệu đồng bộ !";
        return;
      }

      SaveLog(typeLog, message);
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    
    private void btn_search_Click(object sender, EventArgs e)
    {
      load_data_async();
    }

    private void btn_dongbo_Click(object sender, EventArgs e)
    {
      dong_bo_async(txt_tungay.Value, txt_denngay.Value);
    }

    private void notifyIconSystem_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      this.Show();
      this.WindowState = FormWindowState.Normal;
    }

    private void frm_dongbo_vnEdu_Resize(object sender, EventArgs e)
    {
      if (FormWindowState.Minimized == this.WindowState)
      {
        notifyIconSystem.Visible = true;
        notifyIconSystem.ShowBalloonTip(500);
        this.Hide();
      }
      else if (FormWindowState.Normal == this.WindowState)
      {
        notifyIconSystem.Visible = false;
      }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Show();
      this.WindowState = FormWindowState.Normal;
    }

    private void closeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void run_jobs()
    {
      string path_file_job = Application.StartupPath + "/Data/Jobs.xml";

      if (!File.Exists(path_file_job))
      {
        return;
      }

      XDocument xmlObject = XDocument.Load(path_file_job);

      IEnumerable<XElement> jobs = xmlObject.Descendants("Job").Where(j => Int32.Parse(j.Element("Hour").Value) == DateTime.Now.Hour && Int32.Parse(j.Element("Minute").Value) == DateTime.Now.Minute);

      timer1.Start();
      if (jobs.Any())
      {
        dong_bo_async(DateTime.Now, DateTime.Now);
      }
    }

    int timer = 0;
    private void timer1_Tick(object sender, EventArgs e)
    {
      timer++;
      run_jobs();
    }

    private void frm_dongbo_vnEdu_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing)
      {
        this.WindowState = FormWindowState.Minimized;
        e.Cancel = true;
      }
    }

    private void tuDongChayToolStripMenuItem_Click(object sender, EventArgs e)
    {
      StartupWithWindow(
        enable: true
      );

      check_tudongchay();
    }

    private void tatTudongChayToolStripMenuItem_Click(object sender, EventArgs e)
    {
      StartupWithWindow(
        enable: false
      );
      check_tudongchay();
    }


    private void StartupWithWindow(bool enable)
    {
      RegistryKey myReg = Registry.CurrentUser.OpenSubKey(runReg, true);
      if (enable)
      {
        if (myReg == null)
        {
          RegistryKey regkey = Registry.CurrentUser.CreateSubKey(runReg);
          //mo registry khoi dong cung win
          RegistryKey regstart = Registry.CurrentUser.CreateSubKey(runKey);
          string keyvalue = "1";
          try
          {
            //chen gia tri key
            regkey.SetValue("Index", keyvalue);
            regstart.SetValue(appName, pathProgram);
            ////dong tien trinh ghi key
            regkey.Close();
          }
          catch (Exception ex)
          {
            string typeLog = "Error";
            string message = "Không thể set khởi động cùng Window !";
            SaveLog(typeLog, message);
          }
        }
      }
      else
      {
        RegistryKey myStart = Registry.CurrentUser.OpenSubKey(runKey, true);

        if (myReg != null && myStart.GetValue(appName) != null)
        {
          try
          {
            Registry.CurrentUser.DeleteSubKey(runReg, true);
            myStart.DeleteValue(appName);
          }
          catch (Exception ex)
          {
            string typeLog = "Error";
            string message = "Không thể hủy khởi động cùng Window !";
            SaveLog(typeLog, message);
          }
        }
      }
    }

  }
}
