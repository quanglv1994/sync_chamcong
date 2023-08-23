using GATEWAY_SDK;
using Dong_bo_cham_cong.Dto;
using Dong_bo_cham_cong.Enums;
using Dong_bo_cham_cong.Ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dong_bo_cham_cong.Frm.VnEdu
{
  public partial class frm_cauhinh_thietbi_vnEdu : Form
  {
    private readonly string path_file_data = Application.StartupPath + "/Data/Device_vnEdu.xml";
    private readonly string schema = "Devices";
    private int _id = 0;

    public frm_cauhinh_thietbi_vnEdu()
    {
      InitializeComponent();

    }

    private void frm_cauhinh_thietbi_vnEdu_Load(object sender, EventArgs e)
    {
      load_control();
      load_data();
    }

    private void load_control()
    {
      try
      {
        string path_device =  Application.StartupPath + "/Data/Device.xml";

        if (!File.Exists(path_device))
        {
          return;
        }

        List<Dto.Device> devices = new List<Dto.Device>();

        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path_device);
        DataTable dt = new DataTable();
        dt = dataSet.Tables["Device"];
        if (dt != null)
        {
          List<Dto.ComboboxItem> items = new List<Dto.ComboboxItem>();

          Dto.ComboboxItem item_empty = new Dto.ComboboxItem();
          item_empty.Text = "--Chọn--";
          item_empty.Value = "";

          items.Add(item_empty);

          foreach (DataRow dr in dt.Rows)
          {
            Dto.ComboboxItem item = new Dto.ComboboxItem();
            item.Text = dr["Ten"].ToString();
            item.Value = dr["Ma"].ToString();

            items.Add(item);
          }
          this.cb_thietbi_diemdanh.DisplayMember = "Text";
          this.cb_thietbi_diemdanh.ValueMember = "Value";
          this.cb_thietbi_diemdanh.DataSource = items;
        }
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }

      grv_devices.AutoGenerateColumns = false;
    }

    private void cb_thietbi_diemdanh_TextChanged(object sender, EventArgs e)
    {
      if(cb_thietbi_diemdanh.SelectedValue == null)
      {
        return;
      }  
      txt_ma.Text = cb_thietbi_diemdanh.SelectedValue.ToString();
    }

    private void load_data()
    {
      try
      {
        if (!File.Exists(path_file_data))
        {
          return;
        }

        List<Dto.Device_vnEdu> devices = new List<Dto.Device_vnEdu>();

        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path_file_data);
        DataTable dt = new DataTable();
        dt = dataSet.Tables["Device"];
        if (dt != null)
        {
          int i = 1;
          foreach (DataRow dr in dt.Rows)
          {
            devices.Add(new Dto.Device_vnEdu()
            {
              Stt = i,
              Ma = dr["Ma"].ToString(),
              Ten = dr["Ten"].ToString(),
              SN_vnEdu = dr["SN_vnEdu"].ToString(),
              Key_vnEdu = dr["Key_vnEdu"].ToString()
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

    private void btn_add_Click(object sender, EventArgs e)
    {
      _id = 0;
      cb_thietbi_diemdanh.SelectedValue = "";
      txt_ma.Text = "";
      txt_SN_vnEdu.Text = "";
      txt_key_vnEdu.Text = "";
      cb_thietbi_diemdanh.Enabled = true;
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

        if (deviceExit != null)
        {
          MessageBox.Show("Mã thiết bị đã tồn tại !");
          return;
        }

        XElement device = new XElement("Device",
        new XElement("Ma", txt_ma.Text),
        new XElement("Ten", cb_thietbi_diemdanh.SelectedItem.ToString()),
        new XElement("SN_vnEdu", txt_SN_vnEdu.Text),
        new XElement("Key_vnEdu", txt_key_vnEdu.Text)
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

    private void edit(string ma)
    {
      _id = 1;
      cb_thietbi_diemdanh.Enabled = false;

      XDocument xmlObject = XDocument.Load(path_file_data);

      XElement device = xmlObject.Descendants("Device").Where(c => c.Element("Ma").Value.Equals(ma)).FirstOrDefault();
      if (device != null)
      {
        txt_ma.Text = device.Element("Ma").Value;
        cb_thietbi_diemdanh.SelectedValue = device.Element("Ma").Value;
        txt_SN_vnEdu.Text = device.Element("SN_vnEdu").Value;
        txt_key_vnEdu.Text = device.Element("Key_vnEdu").Value;
      }
    }

    private void update(string ma)
    {
      try
      {
        XDocument xmlObject = XDocument.Load(path_file_data);

        XElement device = xmlObject.Descendants("Device").Where(c => c.Element("Ma").Value.Equals(ma)).FirstOrDefault();
        
        if (device != null)
        {
          device.Element("Ma").Value = txt_ma.Text;
          device.Element("Ten").Value = cb_thietbi_diemdanh.SelectedItem.ToString();
          device.Element("SN_vnEdu").Value = txt_SN_vnEdu.Text;
          device.Element("Key_vnEdu").Value = txt_key_vnEdu.Text;

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

    private void delete(string ma)
    {
      try
      {
        if (MessageBox.Show("Confirm Delete", "Bạn có chắc chắn muốn xóa ?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
        {
          return;
        }

        XDocument xmlObject = XDocument.Load(path_file_data);
        XElement device = xmlObject.Descendants("Device").Where(c => c.Element("Ma").Value.Equals(ma)).FirstOrDefault();
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


    private void grv_devices_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == grv_devices.NewRowIndex || e.RowIndex < 0)
        return;

      DataGridViewRow row = grv_devices.Rows[e.RowIndex];

      if (e.ColumnIndex == grv_devices.Columns["Btn_edit"].Index)
      {
        string ma = row.Cells["Ma"].Value.ToString();
        edit(ma);
      }

      if (e.ColumnIndex == grv_devices.Columns["Btn_delete"].Index)
      {
        string ma = row.Cells["Ma"].Value.ToString();
        delete(ma);
      }
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      if (txt_ma.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập mã thiết bị !");
        return;
      }
      if (cb_thietbi_diemdanh.SelectedValue == null)
      {
        MessageBox.Show("Vui lòng chọn thiết bị !");
        return;
      }

      if (txt_SN_vnEdu.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập Số Serial vnEdu !");
        return;
      }
      if (txt_key_vnEdu.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập key vnEdu !");
        return;
      }

      if (_id == 0)
      {
        insert();
      }
      else
      {
        update(txt_ma.Text);
      }
    }

    private void btn_timkiem_Click(object sender, EventArgs e)
    {
      load_data();
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
