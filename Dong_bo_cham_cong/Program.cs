using Dong_bo_cham_cong.Frm.VnEdu;
using Dong_bo_cham_cong.Ultils;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dong_bo_cham_cong
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      UpdateVersion.Init();
      UpdateVersion.RunAutoUpdate();

      Application.Run(new frm_dongbo_vnEdu());
    }
  }
}
