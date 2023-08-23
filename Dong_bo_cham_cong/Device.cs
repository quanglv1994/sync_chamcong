using GATEWAY_SDK;
using Dong_bo_cham_cong.Enums;
using Dong_bo_cham_cong.Ultils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Dong_bo_cham_cong.Frm;
using Dong_bo_cham_cong.Frm.VnEdu;
using Dong_bo_cham_cong.Frm.Hrm;
using System.IO;

namespace Dong_bo_cham_cong
{
  public partial class frm_Device : Form
  {
    public static int _id = 0;

    private readonly string path_file_data = Application.StartupPath + "/Data/Device.xml";
    private readonly string schema = "Devices";

    public frm_Device()
    {
      InitializeComponent();
    }

    private void frm_Device_Load(object sender, EventArgs e)
    {
      panel1.Controls.Add(new uc_MainMenu());
      load_control();
      load_data();
    }

    private void load_control()
    {
      cb_vendor.Items.Add(VendorType.Hikvision);
      cb_vendor.Items.Add(VendorType.ZKTeco);
      cb_vendor.SelectedItem = VendorType.Hikvision;

      grv_devices.AutoGenerateColumns = false;
    }

    private void load_data()
    {
      try
      {
        if (!File.Exists(path_file_data))
        {
          return;
        }

        List<Dto.Device> devices = new List<Dto.Device>();
        
        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path_file_data);
        DataTable dt = new DataTable();
        dt = dataSet.Tables["Device"];
        if(dt != null)
        {
          int i = 1;
          foreach (DataRow dr in dt.Rows)
          {
            StatusType _trang_thai = StatusType.Deactive;
            VendorType _hang = (VendorType)Enum.Parse(typeof(VendorType), dr["Hang"].ToString(), true);
            if (_hang == VendorType.Hikvision)
            {
              SDK_Hikvision hik = new SDK_Hikvision("http://" + dr["Ip"].ToString() + ":" + dr["Port"].ToString(), dr["Username"].ToString(), dr["Password"].ToString());
              if(hik.login())
              {
                _trang_thai = StatusType.Active;
              }  
            }

            devices.Add(new Dto.Device()
            {
              Stt = i,
              Id = Convert.ToInt32(dr["Id"].ToString()),
              Ma = dr["Ma"].ToString(),
              Ten = dr["Ten"].ToString(),
              Hang = _hang,
              Model = dr["Model"].ToString(),
              Ip = dr["Ip"].ToString(),
              Port = dr["Port"].ToString(),
              Username = dr["Username"].ToString(),
              Password = dr["Password"].ToString(),
              Trang_thai = _trang_thai
            });
            i++;
          }

        }
        grv_devices.DataSource = devices;
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    private void insert()
    {
      try
      {

        if (!File.Exists(path_file_data))
        {
          FileUtil.Init_Xml(path_file_data, schema);
        }

        XDocument xmlObject = XDocument.Load(path_file_data);
        XElement deviceExit = xmlObject.Descendants("Device").Where(c => c.Element("Ma").Value == txt_ma.Text.ToString()).FirstOrDefault();

        if(deviceExit != null)
        {
          MessageBox.Show("Mã thiết bị đã tồn tại !");
          return;
        }

        var lastDevice = xmlObject.Descendants("Device").LastOrDefault();
        int newID = 1;
        if (lastDevice != null)
        {
          newID = Convert.ToInt32(lastDevice.Attribute("Id").Value) + 1;
        }


        XElement device = new XElement("Device",
        new XElement("Id", newID),
        new XElement("Ma", txt_ma.Text),
        new XElement("Ten", txt_name.Text),
        new XElement("Hang", cb_vendor.SelectedItem.ToString()),
        new XElement("Model", txt_model.Text),
        new XElement("Ip", txt_ip.Text),
        new XElement("Port", txt_port.Text),
        new XElement("Username", txt_username.Text),
        new XElement("Password", txt_password.Text)
        );
        xmlObject.Element(schema).Add(device);
        xmlObject.Save(path_file_data);

        MessageBox.Show("Thêm mới thiết bị thành công !");
        load_data();
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    private void edit(int id)
    {
      txt_username.Enabled = true;
      txt_password.Enabled = true;
      txt_port.Enabled = true;

      XDocument xmlObject = XDocument.Load(path_file_data);

      XElement device = xmlObject.Descendants("Device").Where(c => Int32.Parse(c.Element("Id").Value) == id).FirstOrDefault();
      if (device != null)
      {
        _id = id;
        txt_ma.Text = device.Element("Ma").Value;
        txt_name.Text = device.Element("Ten").Value;
        cb_vendor.SelectedItem = device.Element("Hang").Value;
        txt_model.Text = device.Element("Model").Value;
        txt_ip.Text = device.Element("Ip").Value;
        txt_port.Text = device.Element("Port").Value;
        txt_username.Text = device.Element("Username").Value;
        txt_password.Text = device.Element("Password").Value;
      }
    }

    private void update(int id)
    {
      try
      {
        XDocument xmlObject = XDocument.Load(path_file_data);

        XElement deviceExist = xmlObject.Descendants("Device").Where(c => Int32.Parse(c.Element("Id").Value) != id && c.Element("Ma").Value.Equals(txt_ma.Text)).FirstOrDefault();
        if(deviceExist != null)
        {
          MessageBox.Show("Mã thiết bị đã tồn tại !");
          return;
        }  

        XElement device = xmlObject.Descendants("Device").Where(c => Int32.Parse(c.Element("Id").Value) == id).FirstOrDefault();
        if (device != null)
        {
          device.Element("Ma").Value = txt_ma.Text;
          device.Element("Ten").Value = txt_name.Text;
          device.Element("Ip").Value = txt_ip.Text;
          device.Element("Port").Value = txt_port.Text;
          device.Element("Username").Value = txt_username.Text;
          device.Element("Password").Value = txt_password.Text;
          device.Element("Hang").Value = cb_vendor.SelectedItem.ToString();
          device.Element("Model").Value = txt_model.Text;

          xmlObject.Save(path_file_data);

          MessageBox.Show("Cập nhật thiết bị thành công !");
          load_data();
        }
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    private void delete(int id)
    {
      try
      {
        if (MessageBox.Show("Confirm Delete", "Bạn có chắc chắn muốn xóa ?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
        {
          return;
        }

        XDocument xmlObject = XDocument.Load(path_file_data);
        XElement device = xmlObject.Descendants("Device").Where(c => Int32.Parse(c.Element("Id").Value) == id).FirstOrDefault();
        device.Remove();
        xmlObject.Save(path_file_data);

        MessageBox.Show("Xóa thiết bị thành công !");
        load_data();
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    private void view_log(int id)
    {
      XDocument xmlObject = XDocument.Load(path_file_data);

      XElement device = xmlObject.Descendants("Device").Where(c => Int32.Parse(c.Element("Id").Value) == id).FirstOrDefault();
      if (device != null)
      {
        SDK_Hikvision hik = new SDK_Hikvision("http://"+ device.Element("Ip").Value + ":" + device.Element("Port").Value, device.Element("Username").Value, device.Element("Password").Value);

        if (hik.login())
        {
          frm_log form_log = new frm_log();
          form_log.id = id;

          form_log.Show(this);
        }
        else
        {
          MessageBox.Show("Không thể kết nối được đến thiết bị !");
        }
      }
      else
      {
        MessageBox.Show("Không tồn tại thiết bị !");
      }
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      if(txt_ma.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập mã thiết bị !");
        return;
      }
      if (txt_name.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập tên thiết bị !");
        return;
      }
      if (txt_ip.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập địa chỉ IP !");
        return;
      }
      if (txt_port.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập Port !");
        return;
      }
      if (txt_username.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập Username !");
        return;
      }
      if (txt_password.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập Password !");
        return;
      }

      if (_id == 0)
      {
        insert();
      }
      else
      {
        update(_id);
      }
    }

    private void btn_add_Click(object sender, EventArgs e)
    {
      _id = 0;
      txt_ma.Text = "";
      txt_name.Text = "";
      txt_ip.Text = "";
      txt_username.Text = "";
      txt_password.Text = "";
      txt_username.Enabled = true;
      txt_password.Enabled = true;
      txt_port.Enabled = true;
    }

    private void grv_devices_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == grv_devices.NewRowIndex || e.RowIndex < 0)
        return;

      DataGridViewRow row = grv_devices.Rows[e.RowIndex];

      if (e.ColumnIndex == grv_devices.Columns["Btn_edit"].Index)
      {
        int id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
        edit(id);
      }

      if (e.ColumnIndex == grv_devices.Columns["Btn_delete"].Index)
      {
        int id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
        delete(id);
      }

      if (e.ColumnIndex == grv_devices.Columns["Btn_log"].Index)
      {
        int id = Convert.ToInt32(row.Cells["Id"].Value.ToString());
        view_log(id);
      }
    }

    private void btn_timkiem_Click(object sender, EventArgs e)
    {
      txt_username.Enabled = false;
      txt_password.Enabled = false;
      txt_port.Enabled = false;

      load_data();
    }

    private void frm_Device_Resize(object sender, EventArgs e)
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
      this.Close();
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
