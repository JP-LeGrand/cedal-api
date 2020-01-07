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
                EventTypes = cedalEvent.EventTypes,
                Date = cedalEvent.DateTime,
                Description = cedalEvent.Description,
                Name = cedalEvent.Name
            });
        }

        public async Task<IEnumerable<EventDto>> ListOfUpcomingEventsAsync(IEnumerable<Event> events)
        {
            return events.Where(cedalEvent => cedalEvent.EventTypes == EventTypes.Upcoming).Select(cedalEvent =>
              new EventDto()
              {
                  Name = cedalEvent.Name,
                  Date = cedalEvent.DateTime,
                  Description = cedalEvent.Description,
                  EventTypes = cedalEvent.EventTypes
              });
        }

        public async Task<IEnumerable<EventDto>> ListOfPassedEventsAsync(IEnumerable<Event> events)
        {
            return events.Where(cedalEvent => cedalEvent.EventTypes == EventTypes.Passed).Select(cedalEvent =>
           new EventDto()
           {
               Name = cedalEvent.Name,
               Date = cedalEvent.DateTime,
               Description = cedalEvent.Description
           });
        }

        public async Task<int> NumberOfEventsHeld(IEnumerable<Event> events)
        {
            return events.Where(cedalEvent => cedalEvent.EventTypes == EventTypes.Passed).Select(cedalEvent =>
                  new EventDto()
                  {
                      Name = cedalEvent.Name,
                      Date = cedalEvent.DateTime,
                      Description = cedalEvent.Description
                  }).Count();
        }
    }
}
