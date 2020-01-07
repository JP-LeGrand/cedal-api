using System;
using cedal_backend.Enums;

namespace cedal_backend.Dto
{
    public class EventDto
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public EventTypes EventTypes { get; set; }
    }
}
