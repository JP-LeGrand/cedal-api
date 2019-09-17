using cedal_backend.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cedal_backend.Models
{
  public class Applicant : User
  {
    public IEnumerable<Education> Education { get; set; }

    public Applicant()
    {
      UserType = UserTypes.Applicant;
    }
  }
}
