using Curso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curso.Infra.Repositories.EntityConfig
{
    class ContaCorrenteConfigure : IEntityTypeConfiguration<ContaCorrente>
    {

        public void Configure(EntityTypeBuilder<ContaCorrente> builder)
        {
            builder.HasKey(e => e.CodContaCorrente);

            builder.HasOne<Banco>(d => d.Banco)
           .WithMany(p => p.Contas)
           .HasForeignKey(d => d.CodBanco);
        }
    }
}