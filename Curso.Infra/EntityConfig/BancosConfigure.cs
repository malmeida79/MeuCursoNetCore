using Curso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Infra.Repositories.EntityConfig
{
    class BancosConfigure : IEntityTypeConfiguration<Banco>
    {

        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.HasKey(e => e.CodBanco);
            //builder.ToTable("Bancos");
        }
    }
}