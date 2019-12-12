using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.ClientInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cedal_backend.Data;
using cedal_backend.Dto;
using cedal_backend.Interfaces;
using cedal_backend.Models;

namespace cedal_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly CedalContext _context;
        private readonly IEventService _eventService;
        private readonly IEventClient _eventClient;

        public EventsController(CedalContext context, IEventService eventService)
        {
            _context = context;
            _eventService = eventService;
        }

        // GET: api/Events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }

        [HttpGet]
        [Route("UpcomingEvents")]
        [ProducesResponseType(typeof(EventDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetUpcomingEvents()
        {
            return Ok((await _eventService.ListOfUpcomingEventsAsync()));
        }

        [HttpGet]
        [Route("PassedEvents")]
        [ProducesResponseType(typeof(EventDto), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Event>>> GetPassedEvents()
        {
            return Ok((await _eventService.ListOfPassedEventsAsync()));
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var @event = await _context.Events.FindAsync(id);

            if (@event == null)
            {
                return NotFound();
            }

            return @event;
        }

        // POST: api/Events
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(Event @event)
        {
            _context.Events.Add(@event);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvent", new { id = @event.Id }, @event);
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Event>> DeleteEvent(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();

            return @event;
        }

        private bool EventExists(Guid? id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
