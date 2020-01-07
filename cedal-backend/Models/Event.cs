using System;
using cedal_backend.Enums;

namespace cedal_backend.Models
{
    public class Event
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public Address EventAddress { get; set; }
        public EventTypes EventType { get; set; }
        public string EventImage { get; set; }
        public string EventDamage { get; set; }
    }
}
