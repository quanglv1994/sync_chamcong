using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace ApiCheckIn
{
   public class VnFace
    {
    //RestSharp 105.2.3
    public string UriApiVnFace = System.Configuration.ConfigurationSettings.AppSettings["UriApiVnFace"];
        public string Authorization = System.Configuration.ConfigurationSettings.AppSettings["Authorization"];
        public string Token_Channel = System.Configuration.ConfigurationSettings.AppSettings["Token_Channel"];

        public CheckInFace getListCheckIn(string _startDate, string _endDate, int _page = 0, int _maxSize = 0)
        {
      //string _function = "/checkin-service/external/his-checkin/list-filter";
      //string _request = "?startDate=" + _startDate + "&endDate=" + _endDate;
      //if (_page != 0)
      //    _request += "&page=" + _page;
      //if (_maxSize != 0)
      //    _request += "&maxSize=" + _maxSize;

      //var client = new RestClient(UriApiVnFace + _function + _request);
      //var request = new RestRequest(Method.Get);
      //request.AddHeader("Content-Type", "application/json");
      //request.AddHeader("Authorization", Authorization);
      //request.AddHeader("Token-Channel", Token_Channel);
      //CheckInFace checkIn = JsonConvert.DeserializeObject<CheckInFace>(response.Content);
      //return checkIn;
        return null;
    }


    public void testApi(string url)
    {
      var client = new RestClient("http://wong-trading.com/api_vn.php?client=nam1986&history=VCB");
      //client.Timeout = -1;
      //var request = new RestRequest(Method.GET);
      //request.AddHeader("Content-Type", "application/json");
      ////request.AddHeader("Authorization", Authorization);
      ////request.AddHeader("Token-Channel", Token_Channel);
      //IRestResponse response = client.Execute(request);
      //var result = response.Content;

    }
    }
}
