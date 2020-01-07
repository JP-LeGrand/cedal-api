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
    public class EventsControllerTests : BaseTests
    {

        public EventsControllerTests(CustomWebApplicationFactory<Startup> factory) : base(factory)
        {
        }

        [Fact]
        public async Task GetAllEventsAsync_AllEvents_Succesfull()
        {
            //Act
            var getAllEventsResponse = await _client.GetAsync(UrlHelper.GetAllEvents());
            var jsonBody = await getAllEventsResponse.Content.ReadAsStringAsync();
            var allEvents =
                JsonConvert.DeserializeObject<IEnumerable<EventDto>>(jsonBody);
            var hasEvents = allEvents.Any();

            //Assert
            Assert.Equal(HttpStatusCode.OK, getAllEventsResponse.StatusCode);
            Assert.True(hasEvents);
        }

        [Fact]
        public async Task GetUpcomingEventsAsync_UpcomingEvents_Succesfull()
        {
            //Act
            var getUpcomingEventsResponse = await _client.GetAsync(UrlHelper.GetUpcomingEvents());
            var jsonBody = await getUpcomingEventsResponse.Content.ReadAsStringAsync();
            var upcomingEvents =
                JsonConvert.DeserializeObject<IEnumerable<EventDto>>(jsonBody);
            var isUpcoming = upcomingEvents.All(dto => dto.EventTypes == EventTypes.Upcoming);
            //Assert
            Assert.Equal(HttpStatusCode.OK, getUpcomingEventsResponse.StatusCode);
            Assert.True(isUpcoming);
        }

        [Fact]
        public async Task GetPassedEventsAsync_PassedEventsHeld_Succesfull()
        {
            //Act
            var getPassedEventsResponse = await _client.GetAsync(UrlHelper.GetPassedEvents());
            var jsonBody = await getPassedEventsResponse.Content.ReadAsStringAsync();
            var passedEvents =
                JsonConvert.DeserializeObject<IEnumerable<EventDto>>(jsonBody);
            var hasPassed = passedEvents.All(dto => dto.EventTypes == EventTypes.Passed);

            //Assert
            Assert.Equal(HttpStatusCode.OK, getPassedEventsResponse.StatusCode);
            Assert.True(hasPassed);
        }

        [Fact]
        public async Task GetNumberOfEventsHeldAsync_EventsHeld_Successful()
        {
            //Act
            var numberOfEventsResponse = await _client.GetAsync(UrlHelper.GetNumberOfEventss());
            var jsonBody = await numberOfEventsResponse.Content.ReadAsStringAsync();
            var numberOfEvents =
                JsonConvert.DeserializeObject<int>(jsonBody);

            //Assert
            Assert.Equal(HttpStatusCode.OK, numberOfEventsResponse.StatusCode);
            Assert.IsType<int>(numberOfEvents);
        }
    }
}
