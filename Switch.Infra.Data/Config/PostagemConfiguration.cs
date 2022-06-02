using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class PostagemConfiguration : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.HasNoKey();
            /*
             
            public int Id { get; set; }
            public DateTime DataPublicacao { get; set; }
            public string Texto { get; set; }
            public int UsuarioId { get; set; }
            public virtual Usuario Usuario { get; set; }

            public virtual Grupo GrupoId { get; set; }
            public virtual Grupo Grupo { get; set; }
             
             */

            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataPublicacao).IsRequired();
            builder.Property(x => x.Texto).IsRequired().HasMaxLength(400);

            builder.HasOne(x => x.Usuario).WithMany(x => x.Postagens);
            builder.HasOne(x => x.Grupo).WithMany(x => x.Postagens);
        }
    }
}
