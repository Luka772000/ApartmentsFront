using APARTMENTS.Helpers;
using APARTMENTS.Interfaces;
using APARTMENTS.Models;
using APARTMENTS.Repository;
using APARTMENTS.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration Configuration) {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAdressRepository, AdressRepository>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IUserApartmentService, UserApartmentService>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<Context>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            return services;
        }
    }
}
