using CollegePortal.Services.Implementations;
using CollegePortal.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CollegePortal.Web.ConfigureDependencies
{
    public class ConfigureServiceDependencies
    {
        #region Methods

        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IAuthenticateService, AuthenticationService>();
        } 

        #endregion
    }
}
