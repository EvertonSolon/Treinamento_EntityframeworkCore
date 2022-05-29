using Switch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Domain.Entities
{
    public class Identificacao
    {
        public int Id { get; set; }
        public TipoDocumentoEnum TipoDocumento { get; set; }
        public string Numero { get; set; }

        //Propriedade de relacionamento com Usuario
        public int UsuarioId { get; set; }

        //Propriedade de navegação para obter informações do objeto Usuario
        public virtual Usuario Usuario { get; set; }

    }
}
