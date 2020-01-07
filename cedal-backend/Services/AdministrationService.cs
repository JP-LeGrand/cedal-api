using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.Interfaces;
using cedal_backend.Models;

namespace cedal_backend.Services
{
    public class AdministrationService : IAdministrationService
    {
        private readonly IApplicantService _applicantService;
        private readonly IEventService _eventService;
        public AdministrationService(IApplicantService applicantService, IEventService eventService)
        {
            _applicantService = applicantService;
            _eventService = eventService;
        }

        public async Task<int> NumberOfApplicants(IEnumerable<Applicant> applicants)
        {
            var listOfApplicants = await _applicantService.ListOfApplicantAsync(applicants);
            return listOfApplicants.Count();
        }

        public async Task<int> NumberOfOrganisationsAssisted(IEnumerable<Applicant> applicants)
        {
            var applicantsCount = await NumberOfApplicants(applicants);
            return (int)(applicantsCount / 5);
        }

        public Task<int> NumberOfEventsHeld(IEnumerable<Event> events)
        {
            throw new System.NotImplementedException();
        }
    }
}
