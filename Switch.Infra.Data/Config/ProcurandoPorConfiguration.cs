using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class ProcurandoPorConfiguration : IEntityTypeConfiguration<ProcurandoPor>
    {
        public void Configure(EntityTypeBuilder<ProcurandoPor> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao);

            /*
             NaoEspecificado = 1,
             Namoro = 2,
             Amizade = 3,
             RelacionamentoSerio = 4
             */

            builder.HasData(
                new ProcurandoPor() { Id = 1, Descricao = "NaoEspecificado" },
                new ProcurandoPor() { Id = 2, Descricao = "Namoro" },
                new ProcurandoPor() { Id = 3, Descricao = "Amizade" },
                new ProcurandoPor() { Id = 4, Descricao = "RelacionamentoSerio" }
                );
        }
    }
}
