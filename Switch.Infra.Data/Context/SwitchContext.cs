using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        public SwitchContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Identificacao> Identificacoes { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamentos { get; set; }
        public DbSet<UsuarioGrupo> UsuariosGrupos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PostagemConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
