using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Domain.Entities
{
    public class InstituicaoEnsino
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public DateTime? AnoFormacao { get; set; }

    }
}
