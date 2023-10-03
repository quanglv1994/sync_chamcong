using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ApiCheckIn;
namespace Cloud_Gateway.Controllers
{
  [AllowAnonymous]
  public class VneduController : Controller
  {
    [HttpPost]
    public bool Index(VnEdu model)
    {
      VnEdu vnEdu = new VnEdu(sN:model.SN, kEY: model.KEY, iD_NV: model.ID_NV, dateCheckIn: model.DateCheckIn);
      string result = vnEdu.checkin();

      if (result == "OK")
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
