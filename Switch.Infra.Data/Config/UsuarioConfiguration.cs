using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        /*
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string UrlFoto { get; set; }
        public int IdentificacaoId { get; set; }
        public virtual Identificacao Identificacao { get; set; }
        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuariosGrupos { get; set; }
         */

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
            builder.HasOne(usuario => usuario.Identificacao)
                .WithOne(identificacao => identificacao.Usuario)
                .HasForeignKey<Identificacao>(identificacao => identificacao.UsuarioId);

            builder.HasMany(x => x.Postagens).WithOne(y => y.Usuario);
            //builder.HasMany(x => x.UsuariosGrupos).WithOne(x => x.Usuario);
        }
    }
}
