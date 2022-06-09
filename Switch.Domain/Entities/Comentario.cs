using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Domain.Entities
{
    public class Comentario
    {
        public int Id { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; private set; }

        public Comentario()
        {
            DataPublicacao = DateTime.Now;
        }

        public void SetUsuario(Usuario usuario)
        {
            if (usuario == null) return;

            Usuario = new Usuario();
        }
    }
}
