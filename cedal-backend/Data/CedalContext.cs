using cedal_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace cedal_backend.Data
{
    public class CedalContext : DbContext
    {
        public CedalContext(DbContextOptions<CedalContext> options) : base(options)
        {
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<WeekDays> WeekDays { get; set; }
    }
}
