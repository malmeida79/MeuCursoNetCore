using Curso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curso.Infra.Repositories.EntityConfig
{
    class ContaInvestimentoConfigure : IEntityTypeConfiguration<ContaInvestimento>
    {

        public void Configure(EntityTypeBuilder<ContaInvestimento> builder)
        {
            builder.HasKey(e => e.CodContaInvestimento);
        }
    }
}