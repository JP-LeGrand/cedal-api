using System.Net.Http;
using cedal_backend;
using cedal_backend.Interfaces;
using CedalAPITests.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace CedalAPITests.Tests
{
    public class BaseTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        protected readonly HttpClient _client;
        protected readonly IApplicantService _applicantService;
        protected readonly IEventService _eventService;
        protected readonly IAdministrationService _administrationService;

        public BaseTests(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();

            //The IServiceProvider used to resolve dependencies from the scope.
            using (var scope = factory.Server.Host.Services.CreateScope())
            {
                _applicantService = scope.ServiceProvider.GetRequiredService<IApplicantService>();
                _eventService = scope.ServiceProvider.GetRequiredService<IEventService>();
                _administrationService = scope.ServiceProvider.GetRequiredService<IAdministrationService>();
            }
        }
    }
}
