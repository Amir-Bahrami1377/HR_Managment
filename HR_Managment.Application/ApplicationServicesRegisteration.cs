using HR_Managment.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HR_Managment.Application
{
    public static class ApplicationServicesRegisteration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services) 
        {
            //services.AddAutoMapper(typeof(MappingProfile));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
