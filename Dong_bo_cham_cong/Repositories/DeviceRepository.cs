using Dong_bo_cham_cong.Enums;
using Dong_bo_cham_cong.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using GATEWAY_SDK;
using Dong_bo_cham_cong.Ultils;
using System.Xml.Linq;
using System.Linq;

namespace Dong_bo_cham_cong.Repositories
{
  public class DeviceRepository : IBaseRepository<Device>
  {
    private readonly string path_file_data = Application.StartupPath + "/Data/Device.xml";
    private readonly string schema = "Devices";
    public IEnumerable<Device> Search()
    {
      List<Device> Devices = new List<Device>();
      if (File.Exists(path_file_data))
      {
        List<Device> devices = new List<Device>();

        DataSet dataSet = new DataSet();

        dataSet.ReadXml(path_file_data);
        DataTable dt = new DataTable();
        dt = dataSet.Tables["Device"];
        if (dt != null)
        {
          int i = 1;
          foreach (DataRow dr in dt.Rows)
          {
            StatusType _trang_thai = StatusType.Active;
            TypeDevice _type = (TypeDevice)Enum.Parse(typeof(TypeDevice), dr["Hang"].ToString(), true);
            if (_type == TypeDevice.Hikvision)
            {
              SDK_Hikvision hik = new SDK_Hikvision("http://" + dr["Ip"].ToString() + ":" + dr["Port"].ToString(), dr["Username"].ToString(), dr["Password"].ToString());
              if (hik.login())
              {
                _trang_thai = StatusType.Active;
              }
            }

            devices.Add(new Device()
            {
              Stt = i,
              Id = Convert.ToInt32(dr["Id"].ToString()),
              Ma = dr["Ma"].ToString(),
              Ten = dr["Ten"].ToString(),
              Type = _type,
              Model = dr["Model"].ToString(),
              Ip = dr["Ip"].ToString(),
              Port = dr["Port"].ToString(),
              Username = dr["Username"].ToString(),
              Password = dr["Password"].ToString(),
              Trang_thai = _trang_thai
            });
            i++;
          }

        }
      }

      return Devices;
    }

    public Device Detail(object key)
    {

      return new Device();
    }

    public bool CheckExist(int id, string ma)
    {
      if (!File.Exists(path_file_data))
      {
        FileUtil.Init_Xml(path_file_data, schema);
      }

      XDocument xmlObject = XDocument.Load(path_file_data);
      XElement deviceExist;
      if (id == 0)
      {
         deviceExist = xmlObject.Descendants("Device").Where(c => c.Element("Ma").Value == ma).FirstOrDefault();

      }
      else
      {
        deviceExist = xmlObject.Descendants("Device").Where(c => Int32.Parse(c.Element("Id").Value) != id && c.Element("Ma").Value.Equals(ma)).FirstOrDefault();
      }
      if (deviceExist != null)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool Insert(Device entity)
    {
      try
      {
        if (!File.Exists(path_file_data))
        {
          FileUtil.Init_Xml(path_file_data, schema);
        }

        XDocument xmlObject = XDocument.Load(path_file_data);

        XElement lastDevice = xmlObject.Descendants("Device").LastOrDefault();
        int newID = 1;
        if (lastDevice != null)
        {
          newID = Convert.ToInt32(lastDevice.Element("Id").Value) + 1;
        }

        XElement deviceXml = new XElement("Device",
        new XElement("Id", newID),
        new XElement("Ma", entity.Ma),
        new XElement("Ten", entity.Ten),
        new XElement("Hang", entity.Type.ToString()),
        new XElement("Model", entity.Model),
        new XElement("Protocol", entity.Protocol),
        new XElement("Ip", entity.Ip),
        new XElement("Port", entity.Port),
        new XElement("Username", entity.Username),
        new XElement("Password", entity.Password)
        );
        xmlObject.Element(schema).Add(deviceXml);
        xmlObject.Save(path_file_data);

        return true;
      }
      catch(Exception ex)
      {
        return false;
      }
        
    }

    public bool Update(Device entity)
    {
      try
      {
        XDocument xmlObject = XDocument.Load(path_file_data);

        XElement device = xmlObject.Descendants("Device").Where(c => Int32.Parse(c.Element("Id").Value) == entity.Id).FirstOrDefault();
        if (device != null)
        {
          device.Element("Ma").Value = entity.Ma;
          device.Element("Ten").Value = entity.Ten;
          device.Element("Protocol").Value = entity.Protocol;
          device.Element("Ip").Value = entity.Ip;
          device.Element("Port").Value = entity.Port;
          device.Element("Username").Value = entity.Username;
          device.Element("Password").Value = entity.Password;
          device.Element("Hang").Value = entity.Type.ToString();
          device.Element("Model").Value = entity.Model;

          xmlObject.Save(path_file_data);
        }
        else
        {
          return false;
        }

        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public bool Delete(Device Device)
    {
      return false;
    }

    public bool Delete(object key)
    {
      try
      {
        XDocument xmlObject = XDocument.Load(path_file_data);
        XElement device = xmlObject.Descendants("Device").Where(c => c.Element("Id").Value == key.ToString()).FirstOrDefault();
        device.Remove();
        xmlObject.Save(path_file_data);
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }
  }
}
