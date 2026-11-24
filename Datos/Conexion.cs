using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Integrador2025.Entidades;
using System.Data.SqlTypes;

namespace Integrador2025.Datos
{
    public class Conexion
    {
        public static string sConnecttion =
            @"Server=.\SQLEXPRESS;Database=INTEGRADORNET;Integrated Security=True;TrustServerCertificate=True;";
    }
}