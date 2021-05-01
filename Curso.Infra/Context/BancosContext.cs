using Curso.Domain.Entities;
using Curso.Infra.Repositories.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BancosConfigure());
        }
    }
}
