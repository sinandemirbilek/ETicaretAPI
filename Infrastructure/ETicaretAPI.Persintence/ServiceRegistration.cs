using ETicaretAPI.Application.Abstraction;
using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persintence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persintence.Repositories;

namespace ETicaretAPI.Persintence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseSqlServer(@"Server=DESKTOP-0NRDKLF;Database=ETicaretAPIDb;Trusted_Connection=true;TrustServerCertificate=True"));

            
        }

    }
}
