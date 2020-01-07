using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.Dto;
using cedal_backend.Enums;
using cedal_backend.Interfaces;
using cedal_backend.Models;

namespace cedal_backend.Services
{
    public class ApplicantService : IApplicantService
    {
        public async Task<IEnumerable<ApplicantDto>> ListOfApplicantAsync(IEnumerable<Applicant> applicants)
        {
            //Looping through the applicants and then mapping
            return applicants.Where(applicant => applicant.UserType == UserTypes.Applicant).Select(applicant => new ApplicantDto()
            {
                Name = applicant.Name,
                LastName = applicant.LastName,
                IdNumber = applicant.IdNumber,
                ContactNumber = applicant.ContactNumber,
                Email = applicant.Email
            });
        }

        public async Task<int> NumberOfApplicantAsync(IEnumerable<Applicant> applicants)
        {
            var numberOfApplicants = await ListOfApplicantAsync(applicants);
            return numberOfApplicants.Count();
        }
    }
}

