using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.Dto;
using cedal_backend.Models;

namespace cedal_backend.Interfaces
{
  public interface IEventService
  {
    Task<IEnumerable<EventDto>> ListOfUpcomingEventsAsync();
    Task<IEnumerable<EventDto>> ListOfPassedEventsAsync();
  }
}
