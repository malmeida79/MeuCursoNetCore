using Curso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curso.Infra.Repositories.EntityConfig
{
    class BancosConfigure : IEntityTypeConfiguration<Banco>
    {

        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.HasKey(e => e.CodBanco);

            builder.HasMany<ContaCorrente>(d => d.Contas)
            .WithOne(p => p.Banco)
            .HasForeignKey(d => d.CodBanco);
        }
    }
}