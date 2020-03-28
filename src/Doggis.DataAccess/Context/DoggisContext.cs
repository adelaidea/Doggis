using Doggis.DataAccess.Config;
using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<Servico> Servico { get; set; }
        public DbSet<AgendaServico> AgendaServico { get; set; }

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
    }
}