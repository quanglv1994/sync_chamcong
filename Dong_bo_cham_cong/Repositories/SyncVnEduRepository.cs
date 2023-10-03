using ApiCheckIn;
using Dong_bo_cham_cong.Dto;
using RestSharp;
using System.Security.Policy;

namespace Dong_bo_cham_cong.Repositories
{
  public class SyncVnEduRepository
  {
    public bool Send(VnEdu vnEdu)
    {
      try
      {
        CauHinhChungRepository cauHinhChungRepository = new CauHinhChungRepository();
        CauHinhChung cauHinhChung = cauHinhChungRepository.Load();

        if (cauHinhChung.IsCloud)
        {
          //send via cloud
          string url = string.Format("{0}?SN={1}&KEY={2}&ID_NV={3}&DateCheckIn={4}", cauHinhChung.UrlCloud, vnEdu.SN, vnEdu.KEY, vnEdu.ID_NV, vnEdu.DateCheckIn);
          var client = new RestClient(url);
          var request = new RestRequest("", Method.Post);
          request.AddHeader("Content-Type", "text/plain");
          request.AddBody(new
          {
            SN = vnEdu.SN,
            KEY =vnEdu.KEY,
            ID_NV = vnEdu.ID_NV,
            DateCheckIn = vnEdu.DateCheckIn
          });


          //request.AddJsonBody("text/plain", vnEdu, ParameterType.RequestBody);
          var response = client.Execute(request);

          if (response.Content == "true")
          {
            return true;
          }
          else
          {
            return false;
          }

        }
        else
        {
          //send via local
          string result = vnEdu.checkin();

          if (result == "OK")
          {
            return true;
          }
          else
          {
            //log not ok
            return false;
          }
        }
      }
      catch
      {
        return false;
      }
    }
  }
}
