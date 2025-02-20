using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreSystem.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using storesystem.dal.interfaces;
//using storesystem.dal.implementation;
//using storesystem.bll.interfaces;
//using storesystem.bll.implementation;



namespace StoreSystem.IOC
{
    public static class Dependency
    {
        public static void InjectDependency(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DbVentaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CadenaSQL"));
            });
        }
    }
}
