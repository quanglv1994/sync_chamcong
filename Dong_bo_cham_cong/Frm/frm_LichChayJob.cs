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
  public partial class frm_LichChayJob : Form
  {
    private readonly string path_file_data = Application.StartupPath + "/Data/Jobs.xml";
    private readonly string schema = "Jobs";
    private int _id = 0;

    public frm_LichChayJob()
    {
      InitializeComponent();
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frm_LichChayJob_Load(object sender, EventArgs e)
    {
      load_data();
      grv_jobs.AutoGenerateColumns = false;
    }
    private void load_data()
    {
      try
      {
        if (!File.Exists(path_file_data))
        {
          return;
        }

        List<Dto.Job> jobs = new List<Dto.Job>();

        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path_file_data);
        DataTable dt = new DataTable();
        dt = dataSet.Tables["Job"];
        if (dt != null)
        {
          int i = 1;
          foreach (DataRow dr in dt.Rows)
          {
            jobs.Add(new Dto.Job()
            {
              Stt = i,
              Ma = dr["Ma"].ToString(),
              Ten = dr["Ten"].ToString(),
              Thoigian = dr["Hour"].ToString() + ":"+ dr["Minute"].ToString()
            });
            i++;
          }

        }
        grv_jobs.DataSource = jobs;
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    private void btn_add_Click(object sender, EventArgs e)
    {
      _id = 0;
      txt_key.Text = "";
      txt_name.Text = "";
      txt_hour.Value = 0;
      txt_minute.Value = 0;
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
        XElement jobExit = xmlObject.Descendants("Job").Where(c => c.Element("Ma").Value == txt_key.Text.ToString()).FirstOrDefault();

        if (jobExit != null)
        {
          MessageBox.Show("Mã Job đã tồn tại !");
          return;
        }
        XElement job = new XElement("Job",
        new XElement("Ma", txt_key.Text),
        new XElement("Ten", txt_name.Text),
        new XElement("Hour", txt_hour.Text),
        new XElement("Minute", txt_minute.Text)
        );
        xmlObject.Element(schema).Add(job);
        xmlObject.Save(path_file_data);

        MessageBox.Show("Thêm mới Job thành công !");
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

      XElement job = xmlObject.Descendants("Job").Where(c => c.Element("Ma").Value.Equals(ma)).FirstOrDefault();
      if (job != null)
      {
        txt_key.Text = job.Element("Ma").Value;
        txt_name.Text = job.Element("Ten").Value;
        txt_hour.Text = job.Element("Hour").Value;
        txt_minute.Text = job.Element("Minute").Value;
      }
    }

    private void update(string ma)
    {
      try
      {
        XDocument xmlObject = XDocument.Load(path_file_data);

        XElement job = xmlObject.Descendants("Job").Where(c => c.Element("Ma").Value.Equals(ma)).FirstOrDefault();

        if (job != null)
        {
          job.Element("Ma").Value = txt_key.Text;
          job.Element("Ten").Value = txt_name.Text;
          job.Element("Hour").Value = txt_hour.Text;
          job.Element("Minute").Value = txt_minute.Text;

          xmlObject.Save(path_file_data);

          MessageBox.Show("Cập nhật Job thành công !");
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
        XElement device = xmlObject.Descendants("Job").Where(c => c.Element("Ma").Value.Equals(ma)).FirstOrDefault();
        device.Remove();
        xmlObject.Save(path_file_data);

        MessageBox.Show("Xóa Job thành công !");
        load_data();
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      if (txt_key.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập mã Job !");
        return;
      }

      if (txt_name.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập tên Job !");
        return;
      }
      if (txt_hour.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập giờ !");
        return;
      }
      if (txt_minute.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập phút !");
        return;
      }

      if (_id == 0)
      {
        insert();
      }
      else
      {
        update(txt_key.Text);
      }
    }

    private void grv_jobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex == grv_jobs.NewRowIndex || e.RowIndex < 0)
        return;

      DataGridViewRow row = grv_jobs.Rows[e.RowIndex];

      if (e.ColumnIndex == grv_jobs.Columns["btn_edit"].Index)
      {
        string ma = row.Cells["Ma"].Value.ToString();
        edit(ma);
      }

      if (e.ColumnIndex == grv_jobs.Columns["btn_delete"].Index)
      {
        string ma = row.Cells["Ma"].Value.ToString();
        delete(ma);
      }
    }
  }
}
