using ProjetoAspNetMVCDevMedia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoAspNetMVCDevMedia.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext() : base("conexao") { }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Consultor> Consultor { get; set; }
        public DbSet<Telefone> Telefone { get; set; }

    }
}