using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.Enums;

namespace cedal_backend.Dto
{
  public class ApplicantDto
  {
    public string Name { get; set; }
    public string LastName { get; set; }
    public string IdNumber { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
  }
}
