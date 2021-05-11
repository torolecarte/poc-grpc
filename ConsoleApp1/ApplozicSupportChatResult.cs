using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
  public class ApplozicSupportChatResult : ApplozicSupportChatResult<ResponseAppLozic> { }
  public class ApplozicSupportChatResult<T>
  {
    public T response { get; set; }
  }

  public class ApplozicSupportGroupResult
  {
    public List<ResponseAppLozic> response { get; set; }
  }

  public class ResponseAppLozic
  {
    public int id { get; set; }
    public string clientGroupId { get; set; }
    public string name { get; set; }
    public string[] membersId { get; set; }
    public int unreadCount { get; set; }
  }
}
