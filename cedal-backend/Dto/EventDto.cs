using System;
using cedal_backend.Enums;
using cedal_backend.Models;

namespace cedal_backend.Dto
{
    public class EventDto
    {
        public Guid? EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public EventTypes EventTypes { get; set; }
        public Address EventAddress { get; set; }
        public string EventImage { get; set; }
    }
}
