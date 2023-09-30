using System;

namespace Dong_bo_cham_cong.Models
{
  public class Job
  {
    public Job() {
      DaiLy = false;
      Second = 60;
    }

    public Job(int id, string ma, string ten, bool daiLy, string thoigian, int second)
    {
      Id = id;
      Ma = ma;
      Ten = ten;
      DaiLy = daiLy;
      Thoigian = thoigian;
      Second = second;
    }

    public int Stt { get; set; }
    public int Id { get; set; }
    public string Ma { get; set; }
    public string Ten { get; set; }
    public bool DaiLy { get; set; }
    public string Thoigian { get; set; }
    public int Second { get; set; }
  }
}
