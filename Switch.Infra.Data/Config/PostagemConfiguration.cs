using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class PostagemConfiguration : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataPublicacao);
            builder.Property(x => x.DataPublicacao).IsRequired();
            builder.Property(x => x.Texto).IsRequired().HasMaxLength(400);

            builder.HasOne(x => x.Usuario).WithMany(x => x.Postagens);
        }
    }
}
