using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(400).IsRequired();
            builder.Property(x => x.SobreNome).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Senha).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Sexo).IsRequired();
            builder.Property(x => x.UrlFoto).HasMaxLength(400).IsRequired();
            builder.Property(x => x.DataNascimento).HasMaxLength(400).IsRequired();
        }
    }
}
