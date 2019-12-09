using cedal_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace cedal_backend.Data
{
    public class CedalContext : DbContext
    {
        public CedalContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Tertiary> Tertiaries { get; set; }
    }
}
