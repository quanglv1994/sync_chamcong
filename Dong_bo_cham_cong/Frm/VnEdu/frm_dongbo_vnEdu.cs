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
using System.Threading.Tasks;

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
    private readonly CaLamViecRepository caLamViecRepository = new CaLamViecRepository();
    private List<CaLamViec> _listCaLamViecs { get; set; }

    #region Common
    public frm_dongbo_vnEdu()
    {
      InitializeComponent();
    }

    private void frm_dongbo_vnEdu_Load(object sender, EventArgs e)
    {
      _listCaLamViecs = caLamViecRepository.GetList();
      txt_tungay.Value = DateTime.Now.AddHours(-1);
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

    private void NotifyMessage(string message)
    {
      if (this.Visible)
      {
        //open windown
        MessageBox.Show(message);
      }
      else
      {
        //hide window
        notifyIconSystem.ShowBalloonTip(5000, notifyIconSystem.BalloonTipTitle, message, ToolTipIcon.Info);
      }
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
      IEnumerable<XElement> logs = xmlObject.Descendants("Log").OrderBy(l => DateTime.Parse(l.Element("Created_at").Value)).ToList();

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

    private List<Info> get_data_events_hikvision(Device device, int page, int numberRecord)
    {
      try
      {
        List<Info> infoList = logHikvisionRepository.getListEvents(txt_tungay.Value, txt_denngay.Value, device, page, numberRecord);

        return infoList;
      }
      catch (Exception ex)
      {
        NotifyMessage(String.Format("{0}: {1}", DateTime.Now, ex.Message));
        return new List<Info>();
      }
    }

    private CaLamViec getTimeLogHikUpdated(Info infoLog)
    {
      foreach (var calamviec in _listCaLamViecs)
      {
        DateTime time = Convert.ToDateTime(infoLog.time);

        int hour = time.Hour;
        int minute = time.Minute;

        DateTime timeCheck = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);

        DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, calamviec.StartHour, calamviec.StartMinute, 0);
        DateTime endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, calamviec.EndHour, calamviec.EndMinute, 0);

        if (timeCheck >= startTime && timeCheck <= endTime)
        {
          return calamviec;
        }
      }
      return null;
    }

    private List<Log> getLogDevice(DateTime tu_ngay, DateTime den_ngay, bool saveLog = false)
    {
      List<Log> listLogDevices = new List<Log>();
      int i = 1;
      int totalEvent = 0;
      try
      {
        //List<Info> listEventHikvisons = new List<Info>();
        string path_device = Application.StartupPath + "/Data/Device.xml";

        if (!File.Exists(path_device))
        {
          return listLogDevices;
        }

        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path_device);
        DataTable dt = new DataTable();
        dt = dataSet.Tables["Device"];
        if (dt != null)
        {
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
                int numberRecord = 30;
                int totalMatches = logHikvisionRepository.getTotalEvent(tu_ngay, den_ngay, device);
                int totalPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalMatches) / Convert.ToDouble(numberRecord)));
                totalEvent += totalMatches;
                for (int page = 1; page <= totalPage; page++)
                {
                  List<Info> listInfos = get_data_events_hikvision(device, page, numberRecord);
                  //listEventHikvisons.AddRange(listInfos);

                  foreach (Info info in listInfos)
                  {
                    foreach (var calamviec in _listCaLamViecs)
                    {
                      DateTime timeInfo = Convert.ToDateTime(info.time);

                      int hour = timeInfo.Hour;
                      int minute = timeInfo.Minute;

                      DateTime timeCheck = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);

                      DateTime startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, calamviec.StartHour, calamviec.StartMinute, 0);
                      DateTime endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, calamviec.EndHour, calamviec.EndMinute, 0);

                      if (timeCheck >= startTime && timeCheck <= endTime)
                      {
                        Log logExist = null;

                        foreach (var x in listLogDevices)
                        {
                          DateTime startTimeLog = new DateTime(x.Time.Year, x.Time.Month, x.Time.Day, calamviec.StartHour, calamviec.StartMinute, 0);
                          DateTime endTimeLog = new DateTime(x.Time.Year, x.Time.Month, x.Time.Day, calamviec.EndHour, calamviec.EndMinute, 0);

                          if (x.UserCode.Equals(info.employeeNoString)
                             && x.Time.ToShortDateString().Equals(timeInfo.ToShortDateString())
                             && x.Time >= startTimeLog && x.Time <= endTimeLog)
                          {
                            logExist = x;
                            break;
                          }
                        }
                        //logExist = listLogDevices.FirstOrDefault(x =>
                        //    x.UserCode.Equals(info.employeeNoString)
                        //   && x.Time.ToShortDateString().Equals(timeInfo.ToShortDateString())
                        //   && x.Time >= startTime && x.Time <= endTime);


                        if (logExist == null)
                        {
                          listLogDevices.Add(new Log()
                          {
                            Stt = i,
                            UserCode = info.employeeNoString,
                            Name = info.name,
                            Time = Convert.ToDateTime(info.time),
                            Attendance = info.attendanceStatus,
                            Ip_Device = dr["Ip"].ToString(),
                            Serial_Device = dr["Ma"].ToString()
                          });

                          i++;
                        }
                        else if(logExist.Time > timeInfo)
                        {
                          var itemIndex = listLogDevices.FindIndex(x => x.Equals(logExist));
                          if (itemIndex > -1)
                          {
                            listLogDevices.ElementAt(itemIndex).Time = Convert.ToDateTime(info.time);
                          }
                        }

                        break;
                      }
                    }
                  }

                  //Thread.Sleep(1000);
                }
              }
              else
              {
                string message = "Không thể kết nối được đến máy chấm công " + "http://" + dr["Ip"].ToString() + ":" + dr["Port"].ToString();
                NotifyMessage(String.Format("{0}: {1}", DateTime.Now, message));
                if (saveLog)
                {
                  SaveLog("Error", message);
                }
              }
            }

          }
        }
      }
      catch (Exception ex)
      {
        NotifyMessage(String.Format("{0}: {1}", DateTime.Now, ex.Message));
        if (saveLog)
        {
          SaveLog("Error", ex.Message);
        }
      }
      grLogDevices.Invoke(new Action(() =>
      {
        lbTotalLog.Text = String.Format("Tổng: {0} bản ghi điểm danh", totalEvent);
      }
       ));
      //grLogDevices.Text = String.Format("Tổng: {0} bản ghi", totalEvent);
      return listLogDevices;
    }

    private void load_data()
    {
      List<Log> listLogDevices = getLogDevice(txt_tungay.Value, txt_denngay.Value);

      if (listLogDevices.Count > 0)
      {
        btn_dongbo.Invoke(new Action(() => { btn_dongbo.Enabled = true; }));
      }
      else
      {
        btn_dongbo.Invoke(new Action(() => { btn_dongbo.Enabled = false; }));
      }

      grv_logs.Invoke(new Action(() =>
      {
        //grLogDevices.Text = String.Format("Tổng: {0} bản ghi", listLogDevices.Count);
        lbTotalSync.Text = String.Format("Tổng: {0} bản ghi", listLogDevices.Count);
        grv_logs.DataSource = listLogDevices;
      }
      ));
    }

    private void dong_bo_async(DateTime tu_ngay, DateTime den_ngay)
    {
      Action action = () => { dong_bo(tu_ngay, den_ngay); };
      if (this.Visible)
      {
        using (WatingForm waitingForm = new WatingForm(action, "Đang đồng bộ dữ liệu chấm công. Vui lòng đợi ..."))
        {
          waitingForm.ShowDialog(this);
        }
      }
      else
      {
        var task = new Task(action);
        task.Start();
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
        //load_logs();
        var listViewItem = new ListViewItem(log.Element("Created_at").Value + ": " + log.Element("Message").Value);
        ltLogs.Invoke(new Action(() => { ltLogs.Items.Add(listViewItem); }));

        if (this.Visible)
        {
          NotifyMessage(string.Format("{0}: {1}", created_at, message));
          //notifyIconSystem.ShowBalloonTip(5000, notifyIconSystem.BalloonTipTitle, string.Format("{0}: {1}", created_at, message), ToolTipIcon.Info);
        }
        //hide notify when form hide

      }
      catch (Exception ex)
      {
        NotifyMessage(string.Format("{0}: {1}", created_at, ex.Message));
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

    private void frm_dongbo_vnEdu_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing)
      {
        this.WindowState = FormWindowState.Minimized;
        e.Cancel = true;
      }
    }

    #endregion

    #region Open Window
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
    #endregion

    #region Hide Window
    private void notifyIconSystem_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      this.Show();
      this.WindowState = FormWindowState.Normal;
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

    //private void load_data_hide()
    //{
    //  var task = Task.Factory.StartNew(delegate
    //  {
    //    NotifyMessage("Đang lấy dữ liệu máy chấm công. Vui lòng đợi ...");
    //    load_data();
    //    NotifyMessage("Lấy dữ liệu thành công ...");
    //  });
    //}

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
      //dong_bo_async(DateTime.Now, DateTime.Now);
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

    #endregion
  }
}
