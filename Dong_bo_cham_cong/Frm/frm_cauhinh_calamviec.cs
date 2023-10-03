using Dong_bo_cham_cong.Ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dong_bo_cham_cong.Frm
{
  public partial class frm_cauhinh_calamviec : Form
  {
    private readonly string path_file_data = Application.StartupPath + "/Data/CaLamViec.xml";
    private readonly string schema = "CaLamViecs";
    private int _id = 0;
    public frm_cauhinh_calamviec()
    {
      InitializeComponent();
    }

    private void frm_cauhinh_calamviec_Load(object sender, EventArgs e)
    {
      load_data();
      grvCaLamViec.AutoGenerateColumns = false;
    }

    private void load_data()
    {
      try
      {
        if (!File.Exists(path_file_data))
        {
          return;
        }

        List<Dto.CaLamViec> CaLamViecs = new List<Dto.CaLamViec>();

        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path_file_data);
        DataTable dt = new DataTable();
        dt = dataSet.Tables["CaLamViec"];
        if (dt != null)
        {
          int i = 1;
          foreach (DataRow dr in dt.Rows)
          {
            CaLamViecs.Add(new Dto.CaLamViec()
            {
              Stt = i,
              Ma = dr["Ma"].ToString(),
              Ten = dr["Ten"].ToString(),
              StartHour = Convert.ToInt32(dr["StartHour"].ToString()),
              StartMinute = Convert.ToInt32(dr["StartMinute"].ToString()),
              EndMinute = Convert.ToInt32(dr["EndMinute"].ToString()),
              EndHour = Convert.ToInt32(dr["EndHour"].ToString()),
            });
            i++;
          }

        }
        grvCaLamViec.DataSource = CaLamViecs;
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
        XElement CaLamViecExit = xmlObject.Descendants("CaLamViec").Where(c => c.Element("Ma").Value == txtMa.Text.ToString()).FirstOrDefault();

        if (CaLamViecExit != null)
        {
          MessageBox.Show("Mã ca đã tồn tại !");
          return;
        }
        XElement CaLamViec = new XElement("CaLamViec",
        new XElement("Ma", txtMa.Text),
        new XElement("Ten", txtTen.Text),
        new XElement("StartHour", txtStartHour.Text),
        new XElement("StartMinute", txtStartMinute.Text),
        new XElement("EndHour", txtEndHour.Text),
        new XElement("EndMinute", txtEndMinute.Text)
        );
        xmlObject.Element(schema).Add(CaLamViec);
        xmlObject.Save(path_file_data);

        MessageBox.Show("Thêm mới ca thành công !");
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

      XDocument xmlObject = XDocument.Load(path_file_data);

      XElement CaLamViec = xmlObject.Descendants("CaLamViec").Where(c => c.Element("Ma").Value.Equals(ma)).FirstOrDefault();
      if (CaLamViec != null)
      {
        txtMa.Text = CaLamViec.Element("Ma").Value;
        txtTen.Text = CaLamViec.Element("Ten").Value;
        txtStartHour.Text = CaLamViec.Element("StartHour").Value;
        txtStartMinute.Text = CaLamViec.Element("StartMinute").Value;
        txtEndHour.Text = CaLamViec.Element("EndHour").Value;
        txtEndMinute.Text = CaLamViec.Element("EndMinute").Value;
      }
    }

    private void update(string ma)
    {
      try
      {
        XDocument xmlObject = XDocument.Load(path_file_data);

        XElement CaLamViec = xmlObject.Descendants("CaLamViec").Where(c => c.Element("Ma").Value.Equals(ma)).FirstOrDefault();

        if (CaLamViec != null)
        {
          CaLamViec.Element("Ma").Value = txtMa.Text;
          CaLamViec.Element("Ten").Value = txtTen.Text;
          CaLamViec.Element("StartHour").Value = txtStartHour.Text;
          CaLamViec.Element("StartMinute").Value = txtStartMinute.Text;
          CaLamViec.Element("EndHour").Value = txtEndHour.Text;
          CaLamViec.Element("EndMinute").Value = txtEndMinute.Text;

          xmlObject.Save(path_file_data);

          MessageBox.Show("Cập nhật CaLamViec thành công !");
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
        XElement device = xmlObject.Descendants("CaLamViec").Where(c => c.Element("Ma").Value.Equals(ma)).FirstOrDefault();
        device.Remove();
        xmlObject.Save(path_file_data);

        MessageBox.Show("Xóa ca thành công !");
        load_data();
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (txtMa.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập mã Ca !");
        return;
      }

      if (txtTen.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập tên Ca !");
        return;
      }
      if (txtStartHour.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập giờ bắt đầu!");
        return;
      }
      if (txtStartMinute.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập phút bắt đầu !");
        return;
      }
      if (txtEndHour.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập giờ kết thúc !");
        return;
      }
      if (txtEndMinute.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập phút kết thúc !");
        return;
      }
      if (_id == 0)
      {
        insert();
      }
      else
      {
        update(txtMa.Text);
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      _id = 0;
      txtMa.Text = "";
      txtTen.Text = "";
      txtStartHour.Value = 0;
      txtStartMinute.Value = 0;
      txtEndHour.Value = 0;
      txtEndMinute.Value = 0;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void grvCaLamViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == grvCaLamViec.NewRowIndex || e.RowIndex < 0)
        return;

      DataGridViewRow row = grvCaLamViec.Rows[e.RowIndex];

      if (e.ColumnIndex == grvCaLamViec.Columns["btnEdit"].Index)
      {
        string ma = row.Cells["Ma"].Value.ToString();
        edit(ma);
      }

      if (e.ColumnIndex == grvCaLamViec.Columns["btnDelete"].Index)
      {
        string ma = row.Cells["Ma"].Value.ToString();
        delete(ma);
      }
    }
  }
}
