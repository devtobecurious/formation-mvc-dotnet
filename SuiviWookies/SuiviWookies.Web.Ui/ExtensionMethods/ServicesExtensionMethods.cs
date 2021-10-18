using Microsoft.Extensions.DependencyInjection;
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
        public static IServiceCollection AddInjectionDependencies(this IServiceCollection services)
        {
            //> par requête http services.AddScoped<WookieService>();
            //> unique dans l'appli services.AddSingleton<WookieService>();
            // services.Add()
            //services.AddTransient<WookieService>();
            services.AddScoped<WookieService>();

            return services;
        }
        #endregion
    }
}
