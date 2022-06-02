using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {

        /*
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }
        public string UrlFoto { get; set; }
        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuariosGrupos { get; set; }         
         */

        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(100).IsRequired();
            builder.Property(x => x.UrlFoto).HasMaxLength(1000).IsRequired();
            builder.HasMany(x => x.Postagens).WithOne(x => x.Grupo);
            //builder.HasMany(x => x.UsuariosGrupos).WithOne(x => x.Grupo);
        }
    }
}
