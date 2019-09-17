using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace cedal_backend.Enums
{
  public enum EducationType
  {
    [EnumMember(Value = "UNKNOWN")]
    Unknown = 0,
    [EnumMember(Value = "TERTIARY")]
    Tertiary = 1,
    [EnumMember(Value = "SECONDARY")]
    Secondary = 2
  }
}
