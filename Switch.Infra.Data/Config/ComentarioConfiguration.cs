using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        /*
         public int Id { get; set; }
         public DateTime DataPublicacao { get; set; }
         public string Texto { get; set; }
         public int UsuarioId { get; set; }
         public Usuario Usuario { get; private set; }
         */

        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataPublicacao).IsRequired();
            builder.Property(x => x.Texto).IsRequired().HasMaxLength(400);

            builder.HasOne(x => x.Usuario).WithMany( x => x.Comentarios);
        }
    }
}
