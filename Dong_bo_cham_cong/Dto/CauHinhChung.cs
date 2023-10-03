namespace Dong_bo_cham_cong.Dto
{
  public class CauHinhChung
  {
    public CauHinhChung() { }
    public CauHinhChung(bool isCloud, string urlCloud)
    {
      IsCloud = isCloud;
      UrlCloud = urlCloud;
    }

    public bool IsCloud { get; set; }
    public string UrlCloud { get; set; }
  }
}
