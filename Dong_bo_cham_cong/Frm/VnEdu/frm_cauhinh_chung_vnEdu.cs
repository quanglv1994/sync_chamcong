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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Dong_bo_cham_cong.Frm.VnEdu
{
  public partial class frm_cauhinh_chung_vnEdu : Form
  {
    private readonly string path_file_data = Application.StartupPath + "/Data/Config_General_VnEdu.xml";
    private readonly string schema = "VnEdu";
    public frm_cauhinh_chung_vnEdu()
    {
      InitializeComponent();
      load_data();
    }
    private void load_data()
    {
      try
      {
        if (!File.Exists(path_file_data))
        {
          return;
        }

        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path_file_data);
        DataTable dt = new DataTable();
        dt = dataSet.Tables[schema];
        if (dt != null)
        {
          txt_Url.Text = dt.Rows[0]["Url"].ToString();
        }
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      try
      {
        if (txt_Url.Text.Trim() == "")
        {
          MessageBox.Show("Vui lòng nhập Url API !");
          return;
        }

        if (!File.Exists(path_file_data))
        {
          FileUtil.Init_Xml(path_file_data, schema);
        }

        XDocument xmlObject = XDocument.Load(path_file_data);

        XElement configExit = xmlObject.Descendants(schema).FirstOrDefault();

        if (configExit.HasElements)
        {
          configExit.Element("Url").Value = txt_Url.Text;
        }
        else
        {
          XElement device = new XElement(
            new XElement("Url", txt_Url.Text)
          );
          xmlObject.Element(schema).Add(device);
        }

        xmlObject.Save(path_file_data);

        MessageBox.Show("Cập nhật thành công !");
        load_data();
      }
      catch (Exception err)
      {
        MessageBox.Show(err.Message);
      }
    }

    private void btn_close_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
