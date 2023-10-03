using Dong_bo_cham_cong.Dto;
using Dong_bo_cham_cong.Ultils;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Dong_bo_cham_cong.Repositories
{
  public class CauHinhChungRepository
  {
    private readonly string path_file_data = Application.StartupPath + "/Data/CauHinhChung.xml";
    private readonly string schema = "CauHinhChungs";
    private readonly string object_name = "CauHinhChung";

    public CauHinhChung Load()
    {
      CauHinhChung cauHinhChung = new CauHinhChung();
      if (!File.Exists(path_file_data))
      {
        return new CauHinhChung();
      }

      XDocument xmlObject = XDocument.Load(path_file_data);

      XElement cloud = xmlObject.Descendants(object_name).FirstOrDefault();
      
      if(cloud != null)
      {
        cauHinhChung.IsCloud = Convert.ToBoolean(cloud.Element("IsCloud").Value);
        cauHinhChung.UrlCloud = cloud.Element("UrlCloud").Value;
      }

      return cauHinhChung;
    }

    public bool CreateOrUpdate(CauHinhChung cauHinhChung)
    {
      try
      {
        if (!File.Exists(path_file_data))
        {
          FileUtil.Init_Xml(path_file_data, schema);
        }

        XDocument xmlObject = XDocument.Load(path_file_data);

        XElement cloudExist = xmlObject.Descendants(object_name).FirstOrDefault();

        if (cloudExist != null)
        {
          cloudExist.Element("IsCloud").Value = cauHinhChung.IsCloud.ToString();
          cloudExist.Element("UrlCloud").Value = cauHinhChung.UrlCloud;

          xmlObject.Save(path_file_data);
        }
        else
        {
          
          XElement cloud = new XElement(object_name,
           new XElement("IsCloud", cauHinhChung.IsCloud),
           new XElement("UrlCloud", cauHinhChung.UrlCloud)
          );
          xmlObject.Element(schema).Add(cloud);
          xmlObject.Save(path_file_data);
        }
        return true;
      }
      catch
      {
        return false;
      }
      
    }
  }
}
