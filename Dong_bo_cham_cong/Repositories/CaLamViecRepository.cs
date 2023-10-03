using Dong_bo_cham_cong.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dong_bo_cham_cong.Repositories
{
  public class CaLamViecRepository
  {
    private readonly string path_file_data = Application.StartupPath + "/Data/CaLamViec.xml";
    private readonly string schema = "CaLamViecs";

    public List<CaLamViec> GetList()
    {
      try
      {
        List<Dto.CaLamViec> CaLamViecs = new List<Dto.CaLamViec>();

        if (File.Exists(path_file_data))
        {
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
        }

        return CaLamViecs;
      }
      catch (Exception err)
      {
        return new List<CaLamViec>();
      }
    }
  }
}
