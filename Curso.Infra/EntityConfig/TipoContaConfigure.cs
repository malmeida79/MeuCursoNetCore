using Curso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Infra.Repositories.EntityConfig
{
    class TipoContaConfigure : IEntityTypeConfiguration<TipoConta>
    {

        public void Configure(EntityTypeBuilder<TipoConta> builder)
        {
            builder.HasKey(e => e.CodTipoConta);
        }
    }
}