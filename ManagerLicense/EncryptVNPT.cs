using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ManagerLicense
{
  public class EncryptVNPT
  {
    private string prefix  = "Vnpt";
    public string Encode(string text)
    {
      SHA256Managed sha256 = new SHA256Managed();
      StringBuilder hashSb = new StringBuilder();
      byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(text + prefix));
      foreach (byte b in hash)
      {
        hashSb.Append(b.ToString("x2"));
      }
      return hashSb.ToString();
    }
    public string Decode()
    {
      return "";
    }
  }
}
