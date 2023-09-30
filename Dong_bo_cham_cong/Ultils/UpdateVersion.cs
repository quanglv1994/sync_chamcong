using AutoUpdaterDotNET;
using System;
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
      AutoUpdater.DownloadPath = "update";
    }

    private static void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
    {
      if (args.IsUpdateAvailable)
      {
        DialogResult dialogResult;
        dialogResult =
                MessageBox.Show(
                    $@"Phần mềm có phiên bản mới {args.CurrentVersion}. Phiên bản bạn đang sử dụng hiện tại  {args.InstalledVersion}. Bạn có muốn cập nhật phần mềm không?", @"Cập nhật phần mềm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

        if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
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
        }
      }
      //else
      //{
      //  MessageBox.Show(@"Phiên bản bạn đang sử dụng đã được cập nhật mới nhất.", @"Cập nhật phần mềm",
      //      MessageBoxButtons.OK, MessageBoxIcon.Information);
      //}
    }
    
    public static void RunAutoUpdate()
    {
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
