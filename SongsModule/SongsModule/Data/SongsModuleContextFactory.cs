using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule.Data
{
    public sealed class SongsModuleContextFactory : IDesignTimeDbContextFactory<SongsModuleContext>
    {
        public SongsModuleContext CreateDbContext(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Module;Integrated Security=True;MultipleActiveResultSets=true";
            var optionsBuilder = new DbContextOptionsBuilder<SongsModuleContext>();
            var options = optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connectionString)
                .Options;

            return new SongsModuleContext(options);
        }
    }
}
