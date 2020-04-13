using Doggis.DataAccess.Config;
using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Linq;

namespace Doggis.DataAccess.Context
{
    public class DoggisContext : DbContext
    {
        public DoggisContext(DbContextOptions<DoggisContext> options)
            : base(options) { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<TipoPet> TipoPet { get; set; }
        public DbSet<Raca> Raca { get; set; }
        public DbSet<Alergia> Alergia { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<AgendaServico> AgendaServico { get; set; }
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<FuncionarioTipoPet> FuncionarioTipoPet { get; set; }
        public DbSet<FuncionarioServico> FuncionarioServico { get; set; }
        public DbSet<DisponibilidadeFuncionario> DisponibilidadeFuncionario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var registerTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                                            .Where(x => typeof(IEntityConfig).IsAssignableFrom(x) && !x.IsAbstract);

            foreach (var type in registerTypes)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                  .UseLazyLoadingProxies()
                  .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning));

            base.OnConfiguring(optionsBuilder);
        }
    }
}