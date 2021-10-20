using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.DataContext
{
    public class MainDbContextFactory : IDesignTimeDbContextFactory<MainDbContext>
    {
        #region Public methods
        public MainDbContext CreateDbContext(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");

            var configuration = configurationBuilder.Build();

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseSqlServer(configuration.GetConnectionString("StarWarsDatabase"));
            
            // builder.UseSqlServer();
            MainDbContext context = new MainDbContext(builder.Options);

            return context;
        }
        #endregion
    }
}
