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
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamentos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Identificacao> Identificacoes { get; set; }
        public DbSet<UsuarioGrupo> UsuariosGrupos { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<InstituicaoEnsino> InstituicoesEnsino { get; set; }
        public DbSet<LocalTrabalho> LocaisTrabalho { get; set; }
        public DbSet<ProcurandoPor> ProcurandoPor { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PostagemConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoConfiguration());

            modelBuilder.ApplyConfiguration(new AmigoConfiguration());
            modelBuilder.ApplyConfiguration(new ComentarioConfiguration());
            modelBuilder.ApplyConfiguration(new StatusRelacionamentoConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
