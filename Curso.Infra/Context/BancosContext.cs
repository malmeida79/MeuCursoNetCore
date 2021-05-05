using Curso.Domain.Entities;
using Curso.Infra.Repositories.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Curso.Infra.Repositories.Context
{
    public class BancosContext : DbContext
    {
        public BancosContext()
        {

        }

        public BancosContext(DbContextOptions<BancosContext> options)
            : base(options)
        {

        }

        #region DbSets

        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<TipoConta> TipoConta { get; set; }
        public virtual DbSet<ContaCorrente> ContaCorrente { get; set; }
        public virtual DbSet<ContaInvestimento> ContaInvestimento { get; set; }
        public virtual DbSet<RelContaCliente> RelContaCliente { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BancosConfigure());
            modelBuilder.ApplyConfiguration(new ClientesConfigure());
            modelBuilder.ApplyConfiguration(new TipoContaConfigure());
            modelBuilder.ApplyConfiguration(new ContaCorrenteConfigure());
            modelBuilder.ApplyConfiguration(new ContaInvestimentoConfigure());
            modelBuilder.ApplyConfiguration(new RelContaClienteConfigure());
        }
    }
}
