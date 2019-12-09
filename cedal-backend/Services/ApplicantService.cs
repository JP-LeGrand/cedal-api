using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.ClientInterfaces;
using cedal_backend.Dto;
using cedal_backend.Enums;
using cedal_backend.Interfaces;

namespace cedal_backend.Services
{
    public class ApplicantService : IApplicantService
    {
        private readonly IApplicantClient _applicantClient;

        public ApplicantService(IApplicantClient applicantClient)
        {
            _applicantClient = applicantClient;
        }
        public async Task<IEnumerable<ApplicantDto>> ListOfApplicantAsync()
        {
            var applicants = await _applicantClient.GetApplicantListAsync();

            //Looping through the applicants and then mapping
            return applicants.Where(applicant => applicant.UserType == UserTypes.Applicant).Select(applicant => new ApplicantDto()
            {
                Name = applicant.Name,
                LastName = applicant.LastName,
                IdNumber = applicant.ID,
                ContactNumber = applicant.ContactNumber,
                Email = applicant.Email
            });
        }
    }
}

