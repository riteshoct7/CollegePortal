using AutoMapper.Configuration;
using CollegePortal.Entity.Models;
using CollegePortal.Repository;
using CollegePortal.Repository.Implementations;
using CollegePortal.Repository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;




namespace CollegePortal.Services.ConfigureDependencies
{
    public class ConfigureRepositories
    {
        #region Methods

        public static void AddServices(IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {            
            services.AddDbContext<CollegePortalDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<CollegePortalDbContext>().AddDefaultTokenProviders();
            services.AddScoped<DbContext, CollegePortalDbContext>();
            services.AddTransient<IStudentRepository, StudentRepository>();

        }

        #endregion
    }
}
