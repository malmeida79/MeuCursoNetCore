using Curso.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Curso.Infra.Repositories.EntityConfig
{
    class RelContaClienteConfigure : IEntityTypeConfiguration<RelContaCliente>
    {

        public void Configure(EntityTypeBuilder<RelContaCliente> builder)
        {
            builder.HasKey(e => e.CodBanco);

            // informar o nome correto da tabela pq o mesmo e diferente da classe
            builder.ToTable("VW_ListaClienteConta");
        }
    }
}