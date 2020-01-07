using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [Route("AllEvents")]
        [ProducesResponseType(typeof(IEnumerable<EventDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Event>>> GetAllEvents()
        {
            var events = await GetEvents();
            return Ok((await _eventService.GetAllEventsAsync(events.Value)));
        }

        [HttpGet]
        [Route("UpcomingEvents")]
        [ProducesResponseType(typeof(IEnumerable<EventDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EventDto>>> GetUpcomingEvents()
        {
            var events = await GetEvents();
            return Ok((await _eventService.ListOfUpcomingEventsAsync(events.Value)));
        }

        [HttpGet]
        [Route("PassedEvents")]
        [ProducesResponseType(typeof(IEnumerable<EventDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EventDto>>> GetPassedEvents()
        {
            var events = await GetEvents();
            return Ok((await _eventService.ListOfPassedEventsAsync(events.Value)));
        }

        [HttpGet]
        [Route("NumberOfEvents")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<ActionResult<int>> GetNumberOfEventsHeld()
        {
            var events = await GetEvents();
            return Ok((await _eventService.NumberOfEventsHeld(events.Value)));
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(Guid? id)
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
        [Route("CreateEvent")]
        [ProducesResponseType(typeof(Event), StatusCodes.Status201Created)]
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
