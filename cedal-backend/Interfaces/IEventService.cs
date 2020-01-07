using System.Collections.Generic;
using System.Threading.Tasks;
using cedal_backend.Dto;
using cedal_backend.Models;

namespace cedal_backend.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventDto>> GetAllEventsAsync(IEnumerable<Event> events);
        Task<IEnumerable<EventDto>> ListOfUpcomingEventsAsync(IEnumerable<Event> events);
        Task<IEnumerable<EventDto>> ListOfPassedEventsAsync(IEnumerable<Event> events);
        Task<int> NumberOfEventsHeld(IEnumerable<Event> events);
    }
}
