using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using cedal_backend.Enums;

namespace cedal_backend.Models
{
  public class Event
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateTime { get; set; }
    public Address Address { get; set; }
    public EventTypes EventTypes { get; set; }
    public string EventImage { get; set; }
  }
}
