using cedal_backend.Enums;
using System.Collections.Generic;

namespace cedal_backend.Models
{
    public class Applicant : User
    {
        //Personal Information
        public Address Address { get; set; }
        public MaritalStatus? MaritalStatus { get; set; }
        public bool? Disabilities { get; set; }
        public string DisabilityDetails { get; set; }
        public string Hobbies { get; set; }
        public bool? DriverLicence { get; set; }
        public bool? OwnCar { get; set; }
        public IEnumerable<LanguageType> Languages { get; set; }

        //Contact Person
        public User ContactPerson { get; set; }

        //Education and Experience:
        public string EducationDescription { get; set; }
        public EmploymentStatus? EmploymentStatus { get; set; }
        public string WorkExperience { get; set; }

        //Volunteering Experience
        public bool? VolunteeringExperience { get; set; }
        public string NameOfInstitution { get; set; }
        public string DescriptionOfTrainingExperience { get; set; }

        //Screening
        public string ReasonOfVolunteering { get; set; }
        public AvailabilityTypes? Availability { get; set; }
        public TimePreferences? TimePreferences { get; set; }
        public string OtherPreference { get; set; }
        public IEnumerable<DaysOfTheWeek> DaysAvailable { get; set; }
        public IEnumerable<SchoolSubjects> SubjectsToTeach { get; set; }
        public string OtherMeansOfHelp { get; set; }
        public IEnumerable<EducationType> EducationPreference { get; set; }

        //References
        public string RefName { get; set; }
        public string RefNumber { get; set; }
        public string RefEmail { get; set; }
        public string RefOccupation { get; set; }

        //Documentaiton Document
        public string IdentificationDocument { get; set; }

        public Applicant()
        {
            UserType = UserTypes.Applicant;
        }
    }
}
