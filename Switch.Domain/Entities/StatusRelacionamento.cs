using Switch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Domain.Entities
{
    public class StatusRelacionamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public bool NaoEspecificado { get { return Id == (int)StatusRelacionamentoEnum.NaoEspecificado; } }
        public bool Solteiro { get { return Id == (int)StatusRelacionamentoEnum.Solteiro; } }
        public bool Casado { get { return Id == (int)StatusRelacionamentoEnum.Casado; } }
        public bool EmRelacionamentoSerio { get { return Id == (int)StatusRelacionamentoEnum.EmRelacionamentoSerio; } }
    }
}
