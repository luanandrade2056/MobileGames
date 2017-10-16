using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1mvc.Models
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConexao")

        {

        }

        public DbSet<item> Itens { get; set; }
    }
}