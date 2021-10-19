using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SuiviWookies.Core.DataContext;
using SuiviWookies.Core.Interfaces;
using SuiviWookies.Core.Interfaces.Services;
using SuiviWookies.Core.Models;
using SuiviWookies.Core.Models.Configuration;
using SuiviWookies.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuiviWookies.Web.Ui.ExtensionMethods
{
    public static class ServicesExtensionMethods
    {
        #region Public methods
        public static IServiceCollection AddInjectionDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            //> par requête http services.AddScoped<WookieService>();
            //> unique dans l'appli services.AddSingleton<WookieService>();
            // services.Add()
            //services.AddTransient<WookieService>();

            string connectionString = configuration.GetConnectionString("StarWarsDatabase");

            services.Configure<GameConfiguration>(configuration.GetSection("Game"));

            services.AddDbContext<MainDbContext>(options =>
            {
                options.UseSqlServer(connectionString, options => { });
            });

            services.AddScoped<IBirthService, BirthService>();
            services.AddScoped<IWeaponService<Weapon>, WeaponService>();
            services.AddScoped<ICityService<City>, CityService>();
            services.AddScoped<WookieService>();

            return services;
        }
        #endregion
    }
}
