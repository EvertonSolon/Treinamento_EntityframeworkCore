using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Domain.Entities
{
    public class Amigo
    {
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int UsuarioAmigoId { get; set; }
        public virtual Usuario UsuarioAmigo { get; set; }  
    }
}
