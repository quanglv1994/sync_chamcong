using Dong_bo_cham_cong.Dto;
using GATEWAY_SDK;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dong_bo_cham_cong.Repositories
{
  public class LogHikvisionRepository
  {
    public int getTotalEvent(DateTime tu_Ngay, DateTime den_Ngay, Dto.Device device)
    {
      string start_time = tu_Ngay.ToString("yyyy-MM-ddTHH:mm:00+07:00");
      string end_time = den_Ngay.ToString("yyyy-MM-ddTHH:mm:59+07:00");
      SDK_Hikvision hik = new SDK_Hikvision("http://" + device.Ip + ":" + device.Port, device.Username, device.Password);
      string totalRecordJsons = hik.totalRecords(start_time, end_time);
      AcsEventTotalNumHikvision acsEventTotalNum = JsonSerializer.Deserialize<AcsEventTotalNumHikvision>(totalRecordJsons);
      return acsEventTotalNum.AcsEventTotalNum.totalNum;
    }

    public List<Info> getListEvents(DateTime tu_Ngay, DateTime den_Ngay, Dto.Device device, int page, int numberRecord = 30)
    {
      //string start_time = "2023-04-06T00:00:00+07:00";
      //string end_time = "2023-04-07T23:59:59+07:00";
      string start_time = tu_Ngay.ToString("yyyy-MM-ddTHH:mm:00+07:00");
      string end_time = den_Ngay.ToString("yyyy-MM-ddTHH:mm:59+07:00");
      SDK_Hikvision hik = new SDK_Hikvision("http://" + device.Ip + ":" + device.Port, device.Username, device.Password);
			string logJsons = hik.search_log(start_time, end_time, page, numberRecord);
      LogHikvision logHikvision = JsonSerializer.Deserialize<LogHikvision>(logJsons);
      if (logHikvision.AcsEvent.InfoList?.Count > 0)
      {
        return logHikvision.AcsEvent.InfoList;
      }
      else
      {
        return new List<Info>();
      }
    }
  }
}
