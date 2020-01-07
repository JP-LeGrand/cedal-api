using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace cedal_backend.Data
{
    public class CedalContextFactory : IDesignTimeDbContextFactory<CedalContext>
    {
        public CedalContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CedalContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CedalDb;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new CedalContext(optionsBuilder.Options);
        }
    }
}
