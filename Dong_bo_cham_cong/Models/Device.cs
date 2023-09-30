using Dong_bo_cham_cong.Enums;
using System;

namespace Dong_bo_cham_cong.Models
{
  public class Device
  {
    public Device() { }

    public Device(string ma, string ten, string protocol, string ip, string port, StatusType trang_thai, TypeDevice type, string model, string username, string password)
    {
      Ma = ma;
      Ten = ten;
      Protocol = protocol;
      Ip = ip;
      Port = port;
      Trang_thai = trang_thai;
      Type = type;
      Model = model;
      Username = username;
      Password = password;
    }

    public int Stt { get; set; }

    public int Id { get; set; }

    public string Ma { get; set; }

    public string Ten { get; set; }

    public string Protocol { get; set; } = "http";

    public string Ip { get; set; }

    public string Port { get; set; }

    public StatusType Trang_thai { get; set; }

    public TypeDevice Type { get; set; }

    public string Model { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }
  }
}
