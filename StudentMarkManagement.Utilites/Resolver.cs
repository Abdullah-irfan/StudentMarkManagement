using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using StudentMarkManagement.Core;
using StudentMarkManagement.Resources;
using StudentMarkManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkManagement.Utilites
{
   public class Resolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            #region Context accesor
            // this is for accessing the http context by interface in view level
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion

            #region Services

            services.AddScoped<IStudentMarkServices, StudentMarkServices>();

            #endregion

            #region Repository

            services.AddScoped<IStudentMarkRepositories, StudentMarkRepositories>();

            #endregion

        }
    }
}
