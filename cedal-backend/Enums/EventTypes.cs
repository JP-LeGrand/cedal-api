using System.Runtime.Serialization;

namespace cedal_backend.Enums
{
  public enum EventTypes
  {
    [EnumMember(Value = "UNKNOWN")]
    Unknown = 0,
    [EnumMember(Value = "PASSED")]
    Passed = 1,
    [EnumMember(Value = "UPCOMING")]
    Upcoming = 2
  }
}
