﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch.Domain.Entities
{
    public class Postagem
    {
        public int Id { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Texto { get; set; }
    }
}
