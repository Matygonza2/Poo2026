using Integrador2025.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2025.Datos
{
    public class DalLogin
    {
        public Usuario? Login(string login, string password)
        {
            Usuario? usuario = null;

            try
            {
                string consulta = @"
               SELECT LOGIN, APELLYNOM, PASSW, FCH_ALTA, FCH_BAJA
               FROM USUARIO
               WHERE LOGIN = @login AND PASSW = @passw
                 AND (FCH_BAJA IS NULL)";

                using SqlConnection conexion = new SqlConnection(Conexion.sConnecttion);
                using SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.Add("@login", System.Data.SqlDbType.NVarChar, 50).Value = login;
                comando.Parameters.Add("@passw", System.Data.SqlDbType.NVarChar, 50).Value = password;

                conexion.Open();

                using SqlDataReader reader = comando.ExecuteReader();


                if (reader.Read())
                {
                    usuario = new Usuario(
                        reader["LOGIN"].ToString() ?? "",
                        reader["APELLYNOM"].ToString() ?? "",
                        reader["PASSW"].ToString() ?? "",
                        Convert.ToDateTime(reader["FCH_ALTA"]),
                        reader["FCH_BAJA"] == DBNull.Value
                            ? (DateTime?)null
                            : Convert.ToDateTime(reader["FCH_BAJA"])
                    );
                }
            }

            catch (SqlException ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message, ex);
            }

            return usuario;
        }
    }
}

