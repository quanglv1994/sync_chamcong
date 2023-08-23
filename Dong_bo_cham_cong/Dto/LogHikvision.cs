using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dong_bo_cham_cong.Dto
{
  public class AcsEvent
  {
    public string searchID { get; set; }
    public int totalMatches { get; set; }
    public string responseStatusStrg { get; set; }
    public int numOfMatches { get; set; }
    public List<Info> InfoList { get; set; }
  }
  public class Info
	{
    public int serialNo { get; set; }
    public int major { get; set; }
		public int minor { get; set; }
		public string time { get; set; }
		public string cardNo { get; set; }
		public string name { get; set; }
		public string employeeNoString { get; set; }
		public string attendanceStatus { get; set; }
		public string label { get; set; }
		public string mask { get; set; }
		public string pictureURL { get; set; }
  }

  public class LogHikvision
  {
    public AcsEvent @AcsEvent;
  }
}
