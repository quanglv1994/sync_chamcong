using Dong_bo_cham_cong.Enums;
using System;

namespace Dong_bo_cham_cong.Models
{
  public class Log
  {
    public Log() { }

    public Log(Guid id, LogType type, DateTime created_at, string message)
    {
      Id = id;
      Type = type;
      Created_at = created_at;
      Message = message;
    }

    public Guid Id { get; set; }
    public LogType Type { get; set; }
    public DateTime Created_at { get; set; } = DateTime.Now;
    public string Message { get; set; }
  }
}
