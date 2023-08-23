using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dong_bo_cham_cong.Ultils
{
  public static class FileUtil
  {
    public static void Init_Xml(string path, string schema)
    {
      var file = File.Create(path);
      file.Dispose();

      var rootXml = new XDocument();
      //Now, we are Adding the Root Element  
      var rootElement = new XElement(schema);
      rootXml.Add(rootElement); //done with it  
      rootXml.Save(path);
    }  

  }
}
