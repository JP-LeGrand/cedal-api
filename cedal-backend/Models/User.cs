using System;
using System.ComponentModel.DataAnnotations;
using cedal_backend.Enums;

namespace cedal_backend.Models
{
  public class User
  {
    public string ID { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public UserTypes UserType { get; set; }

  }
}
