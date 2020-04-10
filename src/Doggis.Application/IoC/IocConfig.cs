using Doggis.DataAccess.Context;
using Doggis.DataAccess.Repository;
using Doggis.Domain.IRepository;
using Doggis.Executors.Cliente;
using Doggis.Executors.Fabricante;
using Doggis.Executors.Produto;
using Doggis.Executors.Servico;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Cliente;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Servico;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Fabricante;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Produto;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Servico;
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
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IVendaRepository, VendaRepository>();
            services.AddScoped<IServicoRepository, ServicoRepository>();
            services.AddScoped<IFabricanteRepository, FabricanteRepository>();
        }

        public static void RegisterExecutor(this IServiceCollection services)
        {
            services.AddScoped<IExecutor<IncluirClienteParameter, IncluirClienteResult>, IncluirClienteExecutor>();
            services.AddScoped<IExecutor<ObterClienteParameter, ObterClienteResult>, ObterClienteExecutor>();

            services.AddScoped<IExecutor<ListarProdutoParameter, ListarProdutoResult>, ListarProdutoExecutor>();
            services.AddScoped<IExecutor<IncluirProdutoParameter, IncluirProdutoResult>, IncluirProdutoExecutor>();
            services.AddScoped<IExecutor<EditarProdutoParameter, EditarProdutoResult>, EditarProdutoExecutor>();
            services.AddScoped<IExecutor<RemoverProdutoParameter, RemoverProdutoResult>, RemoverProdutoExecutor>();
            services.AddScoped<IExecutor<ObterProdutoParameter, ObterProdutoResult>, ObterProdutoExecutor>();
            services.AddScoped<IExecutor<AtualizarEstoqueProdutoParameter, AtualizarEstoqueProdutoResult>, AtualizarEstoqueProdutoExecutor>();
            services.AddScoped<IExecutor<EditarPrecoProdutoParameter, EditarPrecoProdutoResult>, EditarPrecoProdutoExecutor>();
            services.AddScoped<IExecutor<VendaParameter, VendaResult>, VendaExecutor>();
            services.AddScoped<IExecutor<AgendarServicoParameter, AgendarServicoResult>, AgendarServicoExecutor>();
            services.AddScoped<IExecutor<ObterServicosAgendadosParameter, ObterServicosAgendadosResult>, ObterServicosAgendadosExecutor>();
            services.AddScoped<IExecutor<ListarFabricanteResult>, ListarFabricanteExecutor>();
        }

        public static void AddDoggisContext(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DoggisContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}