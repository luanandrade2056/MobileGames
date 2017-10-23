

using System.Data.Entity;

namespace WebApplication1.Models.Contexto
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {

        }
    }
}