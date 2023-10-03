using Dong_bo_cham_cong.Dto;
using Dong_bo_cham_cong.Repositories;
using System;
using System.Windows.Forms;

namespace Dong_bo_cham_cong.Frm
{
  public partial class frm_cauhinh_chung : Form
  {
    CauHinhChungRepository cauHinhChungRepository = new CauHinhChungRepository();
    public frm_cauhinh_chung()
    {
      InitializeComponent();
    }

    private void frm_cauhinh_chung_Load(object sender, EventArgs e)
    {
      load_data();
    }

    private void load_data()
    {
      CauHinhChung cauHinhChung = cauHinhChungRepository.Load();
      ckCheckCloud.Checked = cauHinhChung.IsCloud;
      txtUrlCloud.Text = cauHinhChung.UrlCloud;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      if (ckCheckCloud.Checked && txtUrlCloud.Text.Trim() == "")
      {
        MessageBox.Show("Vui lòng nhập Url cloud !");
        return;
      }
      CauHinhChung cauHinhChung = new CauHinhChung(isCloud: ckCheckCloud.Checked, urlCloud: txtUrlCloud.Text);
      bool cauHinhChungCheck = cauHinhChungRepository.CreateOrUpdate(cauHinhChung);

      if(cauHinhChungCheck)
      {
        MessageBox.Show("Cập nhật cấu hình thành công !");
        load_data();
      }
      else
      {
        MessageBox.Show("Đã có lỗi xảy ra !");
        return;
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

  }
}
