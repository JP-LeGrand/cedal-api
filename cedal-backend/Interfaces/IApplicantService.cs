using System.Collections.Generic;
using System.Threading.Tasks;
using cedal_backend.Dto;
using cedal_backend.Models;

namespace cedal_backend.Interfaces
{
    public interface IApplicantService
    {
        Task<IEnumerable<ApplicantDto>> ListOfApplicantAsync(IEnumerable<Applicant> applicants);
        Task<int> NumberOfApplicantAsync(IEnumerable<Applicant> applicants);

    }
}
