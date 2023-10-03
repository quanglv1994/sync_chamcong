using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using RestSharp;
namespace ApiCheckIn
{
  public class VnEdu
  {
    const string urlCheckin = "https://s19.vnedu.vn/v3/smartidapi/cdata";

    public VnEdu()
    {
    }

    public VnEdu(string sN, string kEY, string iD_NV, string dateCheckIn)
    {
      SN = sN;
      KEY = kEY;
      ID_NV = iD_NV;
      DateCheckIn = dateCheckIn;
    }

    public string SN { get; set; }
    public string KEY { get; set; }
    public string ID_NV { get; set; }
    public string DateCheckIn { get; set; }

    private string GetMd5Hash(MD5 md5Hash, string input)
    {
      // Convert the input string to a byte array and compute the hash.
      byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
      StringBuilder sBuilder = new StringBuilder();
      for (int i = 0; i < data.Length; i++)
      {
        sBuilder.Append(data[i].ToString("x2"));
      }
      return sBuilder.ToString();
    }

    public string checkin()
    {
      //hash = md5(SN + KEY + DATA)
      //SN = DS-K1T341AMF20210406V030230
      //KEY = 3c9223d26313c839d08a6ee219ef49a7
      //data = 3801530	2022-10-28 14:12:45
      //Ví dụ như bên dưới: Hash = md5("VNEDU0000001537fa94562a0fa48802f87d8b6eb08732	2020-03-10 14:12:55\r\n3	2020-03-10 14:12:45")

      string hash = "";
      string DATA = ID_NV + "\t" + DateCheckIn;

      using (MD5 md5Hash = MD5.Create())
      {
        hash = GetMd5Hash(md5Hash, SN + KEY + DATA);
      }

      var client = new RestClient(urlCheckin + "?SN=" + SN + "&table=ATTLOG&type=device&hash=" + hash);
      var request = new RestRequest("", Method.Post);
      request.AddHeader("Content-Type", "text/plain");

      request.AddParameter("text/plain", DATA, ParameterType.RequestBody);
      var response = client.Execute(request);

      return response.Content;


    }
  }
}
