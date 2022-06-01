using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(100).IsRequired();
            builder.Property(x => x.UrlFoto).HasMaxLength(1000).IsRequired();
            builder.HasMany(x => x.Postagens).WithOne(x => x.Grupo).HasForeignKey(x => x.GrupoId);            
        }
    }
}
