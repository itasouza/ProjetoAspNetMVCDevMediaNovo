﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAspNetMVCDevMedia.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int ddd { get; set; }
        public string Numero { get; set; }
        public TipoTelefone Tipo { get; set; }
    }
}