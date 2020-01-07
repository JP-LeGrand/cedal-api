using System.Collections.Generic;
using System.Threading.Tasks;
using cedal_backend.Models;

namespace cedal_backend.Interfaces
{
    public interface IAdministrationService
    {
        Task<int> NumberOfApplicants(IEnumerable<Applicant> applicants);
        Task<int> NumberOfOrganisationsAssisted(IEnumerable<Applicant> applicants);
        Task<int> NumberOfEventsHeld(IEnumerable<Event> events);
    }
}
