using Dong_bo_cham_cong.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dong_bo_cham_cong.Dto
{
  class Device
  {
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
