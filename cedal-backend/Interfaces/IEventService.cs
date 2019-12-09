using System.Collections.Generic;
using System.Threading.Tasks;
using cedal_backend.Dto;

namespace cedal_backend.Interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventDto>> ListOfUpcomingEventsAsync();
        Task<IEnumerable<EventDto>> ListOfPassedEventsAsync();
    }
}
