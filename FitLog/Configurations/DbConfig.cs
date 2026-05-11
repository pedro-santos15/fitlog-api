using FitLog.Model.Context;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace FitLog.Configurations
{
    public static class DbConfig
    {

        public static IServiceCollection AddDatabaseConfiguration(
            this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["MSSQLServerSQLConnection:MSSQLServerSQLConnectionString"];

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("Connection string 'MSSSQLServerSQlConnectionString' not found");
            }

            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
            return services;
        }
    }
}
