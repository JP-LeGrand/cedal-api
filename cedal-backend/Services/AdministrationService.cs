using System;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.Interfaces;

namespace cedal_backend.Services
{
    public class AdministrationService : IAdministrationService
    {
        private readonly IApplicantService _applicantService;
        public AdministrationService(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public async Task<int> NumberOfApplicants()
        {
            var applicants = await _applicantService.ListOfApplicantAsync();
            return applicants.Count();
        }

        public async Task<int> NumberOfOrganisationsAssisted()
        {
            var applicants = await NumberOfApplicants();
            return (int)(applicants / 5);
        }
    }
}
