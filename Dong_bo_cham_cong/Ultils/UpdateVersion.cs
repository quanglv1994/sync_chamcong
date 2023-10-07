using AutoUpdaterDotNET;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Dong_bo_cham_cong.Ultils
{
  public static class UpdateVersion
  {
    private static string _urlCheckVersion = System.Configuration.ConfigurationSettings.AppSettings["UrlCheckVersion"];
    
    public static void Init()
    {
      //System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      //System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
      AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
      //string version = fvi.FileVersion;
      //label1.Text = "Phiên bản: " + version;
      //AutoUpdater.UpdateMode = Mode.Forced; 
      AutoUpdater.AppTitle = "Cập nhật đồng bộ điểm danh vnpt";
      AutoUpdater.RunUpdateAsAdmin = true;
      AutoUpdater.DownloadPath = Application.StartupPath + "/update";
    }

    private static void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
    {
      if (args.IsUpdateAvailable)
      {
        try
        {
          if (AutoUpdater.DownloadUpdate(args))
          {
            Application.Exit();
          }
        }
        catch (Exception exception)
        {
          MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
              MessageBoxIcon.Error);
        }

        //DialogResult dialogResult;
        //dialogResult =
        //        MessageBox.Show(
        //            $@"Phần mềm có phiên bản mới {args.CurrentVersion}. Phiên bản bạn đang sử dụng hiện tại  {args.InstalledVersion}. Bạn có muốn cập nhật phần mềm không?", @"Cập nhật phần mềm",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Information);

        //if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
        //{
        //  try
        //  {
        //    if (AutoUpdater.DownloadUpdate(args))
        //    {
        //      Application.Exit();
        //    }
        //  }
        //  catch (Exception exception)
        //  {
        //    MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
        //        MessageBoxIcon.Error);
        //  }
        //}
      }
      //else
      //{
      //  MessageBox.Show(@"Phiên bản bạn đang sử dụng đã được cập nhật mới nhất.", @"Cập nhật phần mềm",
      //      MessageBoxButtons.OK, MessageBoxIcon.Information);
      //}
    }
    
    public static void RunAutoUpdate()
    {
      if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
      {
        System.Diagnostics.Process.GetCurrentProcess().Kill();
      }

      AutoUpdater.Mandatory = false;
      AutoUpdater.Start(_urlCheckVersion);
    }

    public static void RunUpdate()
    {
      AutoUpdater.Mandatory = true;

      AutoUpdater.Start(_urlCheckVersion);
    }
  }
}
