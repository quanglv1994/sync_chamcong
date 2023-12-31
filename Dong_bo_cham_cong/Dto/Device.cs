﻿using Dong_bo_cham_cong.Enums;

namespace Dong_bo_cham_cong.Dto
{
  public class Device
  {
    public Device() { }
    public Device(int id, string ma, string ten, string ip, string port, StatusType trang_thai, VendorType hang, string model, string username, string password)
    {
      Id = id;
      Ma = ma;
      Ten = ten;
      Ip = ip;
      Port = port;
      Trang_thai = trang_thai;
      Hang = hang;
      Model = model;
      Username = username;
      Password = password;
    }

    public int Stt { get; set; }

    public int Id { get; set; }

    public string Ma { get; set; }

    public string Ten { get; set; }

    public string Ip { get; set; }

    public string Port { get; set; }

    public StatusType Trang_thai { get; set; }

    public VendorType Hang { get; set; }

    public string Model { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }
  }
}
