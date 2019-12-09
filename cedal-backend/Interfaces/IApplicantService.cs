using System.Collections.Generic;
using System.Threading.Tasks;
using cedal_backend.Dto;

namespace cedal_backend.Interfaces
{
    interface IApplicantService
    {
        Task<IEnumerable<ApplicantDto>> ListOfApplicantAsync();

    }
}
