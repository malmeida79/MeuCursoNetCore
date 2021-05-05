using Curso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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