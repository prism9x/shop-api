using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prism.Domain.Abstract;
using Prism.Infrastructure.Dapper;
using Prism.Infrastructure.Persistence;
using Prism.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Infrastructure.Configuration
{
    public static class ConfigurationService
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Get connection string from appsettings.json
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<PrismDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IDapperHelper<>), typeof(DapperHelper<>));
        }
    }
}
