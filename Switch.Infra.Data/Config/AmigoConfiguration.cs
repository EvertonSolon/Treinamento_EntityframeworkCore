using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class AmigoConfiguration : IEntityTypeConfiguration<Amigo>
    {
        /*
         public int UsuarioId { get; set; }
         public virtual Usuario Usuario { get; set; }
         public int UsuarioAmigoId { get; set; }
         public virtual Usuario UsuarioAmigo { get; set; }  
         */

        public void Configure(EntityTypeBuilder<Amigo> builder)
        {
            builder.HasKey(x => new { x.UsuarioId, x.UsuarioAmigoId });
        }
    }
}
