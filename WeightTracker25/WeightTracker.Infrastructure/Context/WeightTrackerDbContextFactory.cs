using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WeightTracker.Infrastructure.Context
{
    public class WeightTrackerDbContextFactory : IDesignTimeDbContextFactory<WeightTrackerDbContext>
    {
        public WeightTrackerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WeightTrackerDbContext>();
            optionsBuilder.UseSqlite("Data Source=weightTracker.db");

            return new WeightTrackerDbContext(optionsBuilder.Options);
        }
    }
}
