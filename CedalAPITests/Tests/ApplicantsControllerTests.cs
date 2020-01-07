using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using cedal_backend;
using cedal_backend.Dto;
using cedal_backend.Enums;
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
    }
}
