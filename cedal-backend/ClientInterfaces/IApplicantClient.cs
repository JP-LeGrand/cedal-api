using cedal_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cedal_backend.ClientInterfaces
{
  public interface IApplicantClient
  {
    Task<IEnumerable<Applicant>> GetApplicantListAsync();
  }
}
