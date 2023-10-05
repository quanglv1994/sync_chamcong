using DigestAuth;
using RestSharp;
using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace GATEWAY_SDK
{
  public class SDK_Hikvision
  {
    public string host = "";
    public string username = "";
    public string password = "";

    public SDK_Hikvision(string host, string username, string password)
    {
      this.host = host;
      this.username = username;
      this.password = password;
    }

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

    public bool login()
    {
      try
      {
        string dir = "/ISAPI/System/deviceinfo";
        RestClient client = new RestClient(host + dir);
        client.Authenticator = new DigestAuthenticator(username, password, timeout: 2000);//2s

        RestRequest request = new RestRequest("", Method.Get);
        var response = client.Execute(request);

        HttpStatusCode status = response.StatusCode;

        if (status == HttpStatusCode.OK)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      catch (Exception ex)
      {
        return false;
      }

    }

    public string get_device()
    {
      try
      {
        string dir = "/ISAPI/System/deviceinfo";
        var client = new RestClient(host + dir);
        client.Authenticator = new DigestAuthenticator(username, password);
        var request = new RestRequest("", Method.Get);
        var response = client.Execute(request);

        return response.Content;
      }
      catch
      {
        return null;
      }

    }

    public string search_log(string start_time, string end_time, int page = 1, int numRecord = 30, Guid searchIdCache = new Guid())
    {
      try
      {
        //string start_time = "2023-04-06T00:00:00+07:00";
        //string end_time = "2023-04-07T23:59:59+07:00";
        //string dir = "/ISAPI/AccessControl/AcsEvent?format=json";//&security=1
        string timeStamp = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
        string iv = "";
        using (MD5 md5Hash = MD5.Create())
        {
          iv = GetMd5Hash(md5Hash, timeStamp);
        }

        string dir = "/ISAPI/AccessControl/AcsEvent?format=json&security=0&iv=" + iv.ToString();//security = 1 => encrypt data
        var client = new RestClient(host + dir);
        client.Authenticator = new DigestAuthenticator(username, password);
        var request = new RestRequest("", Method.Post);
        string queryString = "{" +
          "\"AcsEventCond\": " +
            "{" +
              "\"searchID\": \"" + searchIdCache.ToString() + "\"," +
              "\"searchResultPosition\": " + ((page - 1) * numRecord).ToString() + "," +
              "\"maxResults\": " + numRecord.ToString() + "," +
              "\"major\": 5," + //0
              "\"minor\": 75," + //75 event checkin exist user, 0 tất cả event
              "\"startTime\": \"" + start_time + "\"," +
              "\"endTime\": \"" + end_time + "\"\n    " +
            "}" +
          "}";
        request.AddParameter("text/plain", queryString, ParameterType.RequestBody);
        var response = client.Execute(request);
        return response.Content;
      }
      catch (Exception ex)
      {
        return null;
      }

    }

    public string totalRecords(string start_time, string end_time)
    {
      try
      {
        string dir = "/ISAPI/AccessControl/AcsEventTotalNum?format=json";
        var client = new RestClient(host + dir);
        client.Authenticator = new DigestAuthenticator(username, password);
        var request = new RestRequest("", Method.Post);
        string queryString = "{" +
          "\"AcsEventTotalNumCond\": " +
            "{" +
              "\"major\": 5," +
              "\"minor\": 75," +
              "\"startTime\": \"" + start_time + "\"," +
              "\"endTime\": \"" + end_time + "\"\n    " +
            "}" +
          "}";
        request.AddParameter("text/plain", queryString, ParameterType.RequestBody);
        var response = client.Execute(request);
        return response.Content;
      }
      catch (Exception ex)
      {
        return null;
      }
    }
  }
}
