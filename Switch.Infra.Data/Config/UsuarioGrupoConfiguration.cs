using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioGrupoConfiguration : IEntityTypeConfiguration<UsuarioGrupo>
    {
        public void Configure(EntityTypeBuilder<UsuarioGrupo> builder)
        {
            //Chave composta
            builder.HasKey(x => new { x.UsuarioId, x.GrupoId});

            builder.Property(x => x.DataCriacao).IsRequired();
            builder.Property(x => x.Administrador);
        }
    }
}
