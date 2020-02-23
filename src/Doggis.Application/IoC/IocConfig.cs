using Doggis.DataAccess.Context;
using Doggis.DataAccess.Repository;
using Doggis.Domain.IRepository;
using Doggis.Executors.Cliente;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Cliente;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Doggis.Application.IoC
{
    public static class IocConfig
    {
        public static void RegisterRepository(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
        }

        public static void RegisterExecutor(this IServiceCollection services)
        {
            services.AddScoped<IExecutor<IncluirClienteParameter, IncluirClienteResult>, IncluirClienteExecutor>();
            services.AddScoped<IExecutor<ObterClienteParameter, ObterClienteResult>, ObterClienteExecutor>();
        }

        public static void AddDoggisContext(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DoggisContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
