using Microsoft.Extensions.DependencyInjection;
using Net5MediatR.Data.Interfaces;
using Net5MediatR.Infrastructure.Repostiries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5MediatR.Domain
{
    public static class ServiceRegistry
    {
        public static void Register(this IServiceCollection services)
        {
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
