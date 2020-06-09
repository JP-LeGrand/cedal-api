using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.Dto;
using cedal_backend.Enums;
using cedal_backend.Interfaces;
using cedal_backend.Models;

namespace cedal_backend.Services
{
    public class EventService : IEventService
    {
        public async Task<IEnumerable<EventDto>> GetAllEventsAsync(IEnumerable<Event> events)
        {
            return events.Select(cedalEvent => new EventDto()
            {
                EventId = cedalEvent.Id,
                EventTypes = cedalEvent.EventType,
                Date = cedalEvent.DateTime,
                Description = cedalEvent.Description,
                Name = cedalEvent.Name,
                EventAddress = cedalEvent.EventAddress,
                EventImage = cedalEvent.EventImage
            });
        }

        public async Task<IEnumerable<EventDto>> ListOfUpcomingEventsAsync(IEnumerable<Event> events)
        {
            var allEvents = await GetAllEventsAsync(events);
            return allEvents.Where(dto => dto.EventTypes == EventTypes.Upcoming);
        }

        public async Task<IEnumerable<EventDto>> ListOfPassedEventsAsync(IEnumerable<Event> events)
        {
            var allEvents = await GetAllEventsAsync(events);
            return allEvents.Where(dto => dto.EventTypes == EventTypes.Passed);
        }

        public async Task<int> NumberOfEventsHeld(IEnumerable<Event> events)
        {
            var allEvents = await GetAllEventsAsync(events);
            return allEvents.Count();
        }
    }
}
