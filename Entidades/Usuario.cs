using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2025.Entidades
{
    public class Usuario
    {
        public string Login { get; set; } = string.Empty;
        public string ApellyNom { get; set; } = string.Empty;
        public string Passw { get; set; } = string.Empty;
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }

        public Usuario()
        { }

        public Usuario(string login, string apellyNom, string passw, DateTime fechaAlta, DateTime? fechaBaja)
        {
            Login = login;
            ApellyNom = apellyNom;
            Passw = passw;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
        }
    }
}
