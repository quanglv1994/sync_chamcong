using System;
namespace Dong_bo_cham_cong.Models
{
  public class Checkin
  {
    public Checkin() { }

    public Checkin(Guid id, string userCode, string name, DateTime time, string attendance, string ipDevice, string serialDevice)
    {
      Id = id;
      UserCode = userCode;
      Name = name;
      Time = time;
      Attendance = attendance;
    }

    public int Stt { get; set; }
    public Guid Id { get; set; }
    public string UserCode { get; set; }
    public string Name { get; set; }
    public DateTime Time { get; set; }
    public string Attendance { get; set; }//loai diem danh ra hoặc vào
  }
}
