using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAspNetMVCDevMedia.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int IdConsultor { get; set; }
        public virtual Consultor Consultor { get; set; }
        public virtual List<Telefone> Telefone { get; set; }

    }
}