using cedal_backend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cedal_backend.Models
{
  public class Tertiary : Education
  {
    public string Major { get; set; }
  }
}
