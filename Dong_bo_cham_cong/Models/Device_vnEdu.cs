using System;

namespace Dong_bo_cham_cong.Models
{
  public class Device_vnEdu
  {
    public Device_vnEdu() { }

    public Device_vnEdu(int id, string ma, string ten, string sN_vnEdu, string key_vnEdu)
    {
      Id = id;
      Ma = ma;
      Ten = ten;
      SN_vnEdu = sN_vnEdu;
      Key_vnEdu = key_vnEdu;
    }

    public int Stt { get; set; }

    public int Id { get; set; }

    public string Ma { get; set; }

    public string Ten { get; set; }

    public string SN_vnEdu { get; set; }

    public string Key_vnEdu { get; set; }
  }
}
