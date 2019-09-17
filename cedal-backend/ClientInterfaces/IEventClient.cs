using System.Collections.Generic;
using System.Threading.Tasks;
using cedal_backend.Models;

namespace cedal_backend.ClientInterfaces
{
  public interface IEventClient
  {
    Task<IEnumerable<Event>> GetEventListAsync();
  }
}
