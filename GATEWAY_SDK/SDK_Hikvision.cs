using DigestAuth;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

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

    //public bool login()
    //{
    //  string dir = "/ISAPI/System/deviceinfo";

    //  DigestAuthFixer digest = new DigestAuthFixer(host, username, password);
    //  HttpStatusCode status = digest.GrabResponseStatus(dir);

    //  if (status == HttpStatusCode.OK)
    //  {
    //    return true;
    //  }
    //  else
    //  {
    //    return false;
    //  }
    //}

    public bool login()
    {
      try
      {
        string dir = "/ISAPI/System/deviceinfo";
        var client = new RestClient(host + dir);
        client.Authenticator = new DigestAuthenticator(username, password);
        var request = new RestRequest("", Method.Get);
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
      catch(Exception ex)
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

    public string search_log(string start_time, string end_time, int page = 1, int numRecord = 30)
    {
      try
      {
        //string start_time = "2023-04-06T00:00:00+07:00";
        //string end_time = "2023-04-07T23:59:59+07:00";
        string dir = "/ISAPI/AccessControl/AcsEvent?format=json&security=1";
        var client = new RestClient(host + dir);
        client.Authenticator = new DigestAuthenticator(username, password);
        var request = new RestRequest("", Method.Post);
        string queryString = "{" +
          "\"AcsEventCond\": " +
            "{" +
              "\"searchID\": \"281424d2-12e8-4360-bc68-f41475e462e2\"," +
              "\"searchResultPosition\": " + ((page - 1) * numRecord).ToString() + "," +
              "\"maxResults\": " + numRecord.ToString() + "," +
              "\"major\": 0," +
              "\"minor\": 0," +
              "\"startTime\": \"" + start_time + "\"," +
              "\"endTime\": \"" + end_time + "\"\n    " +
            "}" +
          "}";
        request.AddParameter("text/plain", queryString, ParameterType.RequestBody);
        var response = client.Execute(request);
        return response.Content;
      }
      catch(Exception ex)
      {
        return null;
      }
      
    }
  }
}
