using System;

namespace Dong_bo_cham_cong.Dto
{
  public class CaLamViec
  {
    public CaLamViec() { }

    public CaLamViec(string ma, string ten, int startMinute, int startHour, int endMinute, int endHour)
    {
      Ma = ma;
      Ten = ten;
      StartMinute = startMinute;
      StartHour = startHour;
      EndMinute = endMinute;
      EndHour = endHour;
    }

    public int Stt { get; set; }
    public string Ma { get; set; }
    public string Ten { get; set; }
    public int StartMinute { get; set; }
    public int StartHour { get; set; }
    public int EndMinute { get; set; }
    public int EndHour { get; set; }

    public string StartTime => String.Format("{0}:{1}", StartHour, StartMinute);
    public string EndTime => String.Format("{0}:{1}", EndHour, EndMinute);
  }
}
