using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dong_bo_cham_cong.Dto
{
  public class Log
  {
    public int Stt { get; set; }
    public string UserCode { get; set; }
    public string Name { get; set; }
    public DateTime Time { get; set; }
    public string Attendance { get; set; }
    public string Ip_Device { get; set; }
    public string Serial_Device { get; set; }
  }
}
