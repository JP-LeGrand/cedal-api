using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.ClientInterfaces;
using cedal_backend.Dto;
using cedal_backend.Enums;
using cedal_backend.Interfaces;

namespace cedal_backend.Services
{
    public class EventService : IEventService
    {
        private readonly IEventClient _eventClient;

        public EventService(IEventClient eventClient)
        {
            _eventClient = eventClient;
        }

        public async Task<IEnumerable<EventDto>> ListOfUpcomingEventsAsync()
        {
            var events = await _eventClient.GetEventListAsync();

            return events.Where(cedalEvent => cedalEvent.EventTypes == EventTypes.Upcoming).Select(cedalEvent =>
              new EventDto()
              {
                  Name = cedalEvent.Name,
                  Date = cedalEvent.DateTime,
                  Description = cedalEvent.Description
              });
        }

        public async Task<IEnumerable<EventDto>> ListOfPassedEventsAsync()
        {
            var events = await _eventClient.GetEventListAsync();

            return events.Where(cedalEvent => cedalEvent.EventTypes == EventTypes.Passed).Select(cedalEvent =>
              new EventDto()
              {
                  Name = cedalEvent.Name,
                  Date = cedalEvent.DateTime,
                  Description = cedalEvent.Description
              });
        }
    }
}
