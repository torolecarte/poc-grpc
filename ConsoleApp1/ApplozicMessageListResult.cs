using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
  public class ApplozicMessageListResult
  {
    public List<ApplozicMessageResult> Message { get; set; }
  }

  public class ApplozicMessageResult
  {
    public string Key { get; set; }
    public string UserKey { get; set; }
    public string To { get; set; }
    public string ContactIds { get; set; }
    public string Message { get; set; }
    public bool Sent { get; set; }
    public bool Delivered { get; set; }
    public bool Read { get; set; }
    public int Type { get; set; }
    public int Source { get; set; }
    public int Status { get; set; }
    public string PairedMessageKey { get; set; }

    [JsonConverter(typeof(MyDateTimeConverter))]
    public DateTime CreatedAtTime { get; set; }
  }
}
