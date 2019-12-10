using System;
using cedal_backend.Enums;

namespace cedal_backend.Models
{
    public class User
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string IdNumber { get; set; }
        public UserTypes? UserType { get; set; }

    }
}
