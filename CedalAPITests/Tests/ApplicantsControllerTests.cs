using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using cedal_backend;
using cedal_backend.Dto;
using cedal_backend.Enums;
using cedal_backend.Models;
using CedalAPITests.Configuration;
using CedalAPITests.Helpers;
using Newtonsoft.Json;
using Xunit;

namespace CedalAPITests.Tests
{
    public class ApplicantsControllerTests : BaseTests
    {

        public ApplicantsControllerTests(CustomWebApplicationFactory<Startup> factory) : base(factory)
        {
        }

        [Fact]
        public async Task GetListOfApplicants()
        {
            //Act
            var getApplicantsResponse = await _client.GetAsync(UrlHelper.GetListOfApplicants());
            var jsonBody = await getApplicantsResponse.Content.ReadAsStringAsync();
            var applicants =
                JsonConvert.DeserializeObject<IEnumerable<ApplicantDto>>(jsonBody);

            //Assert
            Assert.Equal(HttpStatusCode.OK, getApplicantsResponse.StatusCode);
            Assert.True(applicants.Any());
        }

        [Fact]
        public async Task GetNumberOfApplicants_NumberOfApplicants_Succesful()
        {
            //Act
            var getNumberOfApplicantsResponse = await _client.GetAsync(UrlHelper.GetNumberOfApplicants());
            var jsonBody = await getNumberOfApplicantsResponse.Content.ReadAsStringAsync();
            var numberOfApplicants =
                JsonConvert.DeserializeObject<int>(jsonBody);

            //Assert
            Assert.Equal(HttpStatusCode.OK, getNumberOfApplicantsResponse.StatusCode);
            Assert.IsType<int>(numberOfApplicants);
        }

        [Fact]
        public async Task CreateApplicantAsync_NewApplication_Successful()
        {
            //Arrange
            var postContent = new StringContent(JsonConvert.SerializeObject(new Applicant
            {
                Id = Guid.NewGuid(),
                Availability = AvailabilityTypes.More,
                DaysAvailable = new List<WeekDays>
                {
                    new WeekDays
                {
                    DaysOfTheWeek = DaysOfTheWeek.Monday
                },    new WeekDays
                {
                    DaysOfTheWeek = DaysOfTheWeek.Thursday
                }
                },
                ContactNumber = "0787641009",
                ContactPerson = new User()
                {
                    Email = "benjaminlegrand073@gmail.com",
                    IdNumber = "95036263081",
                    ContactNumber = "0736243028",
                    DateOfBirth = DateTime.Now.AddYears(-24),
                    LastName = "LeGrand",
                    Name = "Benjamin"
                },
                Disabilities = false,
                Email = "josephlegrand291@gmail.com",
                DriverLicence = false,
                IdNumber = "9503216262083",
                Languages = new Languages[]
                {
                    new Languages()
                {
                    LanguageType = LanguageType.English
                },new Languages()
                    {
                        LanguageType = LanguageType.Sotho
                    }
                },
                Address = new Address()
                {
                    City = "Johannesburg",
                    Country = "South Africa",
                    PostalCode = "5252",
                    Province = "Gauteng",
                    Street = "1 Eastate Street"
                },

                DateOfBirth = DateTime.Now.AddYears(-25),
                Name = "Joseph",
                LastName = "LeGrand",
                MaritalStatus = MaritalStatus.Single,
                TimePreferences = TimePreferences.Afternoon,
                EducationPreference = new Education[]
                {
                    new Education()
                    {
                        EducationType = EducationType.HighSchool
                    }
                },
                EmploymentStatus = EmploymentStatus.Employed,
                OwnCar = false,
                UserType = UserTypes.Applicant,
                SubjectsToTeach = new List<Subjects>()
                {
                    new Subjects()
                    {
                        SchoolSubjects = SchoolSubjects.Accounting
                    },
                    new Subjects()
                    {
                        SchoolSubjects = SchoolSubjects.English
                    }
                },
                VolunteeringExperience = true
            }), Encoding.UTF8, "application/json");

            //Act
            var createApplicantResponse = await _client.PostAsync(UrlHelper.CreateApplicants(), postContent);
            var jsonBody = await createApplicantResponse.Content.ReadAsStringAsync();
            var creaappltedApplicant =
                JsonConvert.DeserializeObject<Applicant>(jsonBody);

            //Assert
            Assert.Equal(HttpStatusCode.Created, createApplicantResponse.StatusCode);
            Assert.Equal(UserTypes.Applicant, creaappltedApplicant.UserType);
        }
    }
}
