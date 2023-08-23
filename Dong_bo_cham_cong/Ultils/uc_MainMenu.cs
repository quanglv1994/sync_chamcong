using Dong_bo_cham_cong.Frm;
using Dong_bo_cham_cong.Frm.Hrm;
using Dong_bo_cham_cong.Frm.VnEdu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dong_bo_cham_cong.Ultils
{
  public partial class uc_MainMenu : UserControl
  {
    public uc_MainMenu()
    {
      InitializeComponent();
      this.Dock = DockStyle.Fill;

      var prevOpenedForm = Application.OpenForms.Cast<Form>().Last();
      if(prevOpenedForm.Name == "frm_dongbo_vnEdu")
      {
        dongbo_vnEduToolStripMenuItem.Enabled = false;
      }  
    }

    private void chvnEdu_thamSoAPIToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frm_cauhinh_chung_vnEdu frmCauhinh_chung_vnEdu = new frm_cauhinh_chung_vnEdu();
      frmCauhinh_chung_vnEdu.ShowDialog();
    }

    private void chVnedu_thietbiToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frm_cauhinh_thietbi_vnEdu frmCauhinh_thietbi_vnEdu = new frm_cauhinh_thietbi_vnEdu();
      frmCauhinh_thietbi_vnEdu.ShowDialog();
    }

    private void dongbo_vnEduToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frm_dongbo_vnEdu frmDongbo_vnEdu = new frm_dongbo_vnEdu();
      frmDongbo_vnEdu.ShowDialog();
    }

    private void dongbo_hrmToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frm_dongbo_hrm frmDongbo_hrm = new frm_dongbo_hrm();
      frmDongbo_hrm.ShowDialog();
    }

    private void cauhinhhrmToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frm_cauhinh_hrm frmCauhinh_hrm = new frm_cauhinh_hrm();
      frmCauhinh_hrm.ShowDialog();
    }

    private void cauhinhchungToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frm_cauhinh_chung frm_Cauhinh_chung = new frm_cauhinh_chung();
      frm_Cauhinh_chung.ShowDialog();
    }

    private void thietbiToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frm_Device frm_device = new frm_Device();
      frm_device.ShowDialog();
    }

    private void lichChayJobToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frm_LichChayJob frm_job = new frm_LichChayJob();
      frm_job.ShowDialog();
    }
  }
}
