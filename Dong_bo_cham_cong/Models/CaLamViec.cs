using System;

namespace Dong_bo_cham_cong.Models
{
  public class CaLamViec
  {
    public CaLamViec() { }

    public CaLamViec(int id, string ma, string ten, int startMinute, int startHour, int endMinute, int endHour)
    {
      Id = id;
      Ma = ma;
      Ten = ten;
      StartMinute = startMinute;
      StartHour = startHour;
      EndMinute = endMinute;
      EndHour = endHour;
    }

    public int Stt { get; set; }
    public int Id { get; set; }
    public string Ma { get; set; }
    public string Ten { get; set; }
    public int StartMinute { get; set; }
    public int StartHour { get; set; }
    public int EndMinute { get; set; }
    public int EndHour { get; set; }
  }
}
