﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Domain.Entities
{
    public class LocalTrabalho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataSaida { get; set; }
        public bool EmpresaAtual { get; set; }

    }
}