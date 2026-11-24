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
    internal class Dal
    {
        public static string SQL = string.Empty; //variable que almacena comandos
        private int identidad; //variable para retornar valor
        public int Identidad
        {
            get { return identidad; }
            set { identidad = value; }
        }
        public static SqlTransaction? objTransaction = null; //variable de transacción

        public int AgregarProducto(string pNombre, string pDescripcion, decimal pPrecioCosto, decimal pMargen, decimal pIVA, decimal pPrecioBruto, decimal pPrecioVenta, string pProveedor, string pCategoria, string pSubCategoria)
        {
            SQL = "INSERT INTO PRODUCTO (NOMBRE, DESCRIPCION, PRECIOCOSTO, MARGEN, IVA, PRECIOBRUTO, PRECIOVENTA, PROVEEDOR, CATEGORIA, SUBCATEGORIA) VALUES ";
            SQL = SQL + "(@pNombre, @pDescripcion, @pPrecioCosto, @pMargen, @pIVA, @pPrecioBruto, @pPrecioVenta, @pProveedor, @pCategoria, @pSubcategoria)";

            SqlConnection con = new SqlConnection(Conexion.sConnecttion);
            SqlCommand com = new SqlCommand(SQL, con);

            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 60).Value = pNombre;
            com.Parameters.Add("@pDescripcion", SqlDbType.VarChar, 150).Value = pDescripcion;
            com.Parameters.Add("@pPrecioCosto", SqlDbType.Decimal).Value = pPrecioCosto;
            com.Parameters.Add("@pMargen", SqlDbType.Decimal).Value = pMargen;
            com.Parameters.Add("@pIVA", SqlDbType.Decimal).Value = pIVA;
            com.Parameters.Add("@pPrecioBruto", SqlDbType.Decimal).Value = pPrecioBruto;
            com.Parameters.Add("@pPrecioVenta", SqlDbType.Decimal).Value = pPrecioVenta;
            com.Parameters.Add("@pProveedor", SqlDbType.VarChar, 100).Value = pProveedor;
            com.Parameters.Add("@pCategoria", SqlDbType.VarChar, 15).Value = pCategoria;
            com.Parameters.Add("@pSubCategoria", SqlDbType.VarChar, 20).Value = pSubCategoria;

            try
            {
                con.Open();
                objTransaction = con.BeginTransaction();
                com.Transaction = objTransaction;

                com.ExecuteNonQuery();
                Identidad = Convert.ToInt32(retParam.Value);

                objTransaction.Commit();
            }
            catch (SqlException ex)
            {
                if (objTransaction != null)
                    objTransaction.Rollback();
                throw new Exception("Error en base de datos" + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
                con.Dispose();
                com.Dispose();
            }
            return Identidad;
        }
        public int ModificarProducto(int pIdProducto, string pNombre, string pDescripcion, decimal pPrecioCosto, decimal pMargen, decimal pIVA, decimal pPrecioBruto, decimal pPrecioVenta, string pProveedor, string pCategoria, string pSubCategoria)
        {
            SQL = "UPDATE PRODUCTO SET NOMBRE=@pNombre, DESCRIPCION=@pDescripcion, PRECIOCOSTO=@pPrecioCosto, MARGEN=@pMargen, IVA=@pIVA, PRECIOBRUTO=@pPrecioBruto, PRECIOVENTA=@pPrecioVenta, PROVEEDOR=@pProveedor, CATEGORIA=@pCategoria, SUBCATEGORIA=@pSubCategoria WHERE ID_PRODUCTO='" + pIdProducto + "'";

            SqlConnection con = new SqlConnection(Conexion.sConnecttion);
            SqlCommand com = new SqlCommand(SQL, con);

            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 60).Value = pNombre;
            com.Parameters.Add("@pDescripcion", SqlDbType.VarChar, 150).Value = pDescripcion;
            com.Parameters.Add("@pPrecioCosto", SqlDbType.Decimal).Value = pPrecioCosto;
            com.Parameters.Add("@pMargen", SqlDbType.Decimal).Value = pMargen;
            com.Parameters.Add("@pIVA", SqlDbType.Decimal).Value = pIVA;
            com.Parameters.Add("@pPrecioBruto", SqlDbType.Decimal).Value = pPrecioBruto;
            com.Parameters.Add("@pPrecioVenta", SqlDbType.Decimal).Value = pPrecioVenta;
            com.Parameters.Add("@pProveedor", SqlDbType.VarChar, 100).Value = pProveedor;
            com.Parameters.Add("@pCategoria", SqlDbType.VarChar, 15).Value = pCategoria;
            com.Parameters.Add("@pSubCategoria", SqlDbType.VarChar, 20).Value = pSubCategoria;

            try
            {
                con.Open();
                objTransaction = con.BeginTransaction();
                com.Transaction = objTransaction;

                // LÍNEA de prueba
                int filas = com.ExecuteNonQuery();
                if (filas == 0)
                {
                    throw new Exception("No se pudo modificar ningún registro. Verifique el ID.");
                }

                Identidad = Convert.ToInt32(retParam.Value);
                objTransaction.Commit();
            }
            catch (SqlException ex)
            {
                if (objTransaction != null)
                    objTransaction.Rollback();

                throw new Exception("Error en Base de Datos: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Dispose();
                com.Dispose();
            }

            return Identidad;
        }
        public DataSet BuscarProducto(string pNombre)
        {
            SQL = "SELECT * FROM PRODUCTO WHERE NOMBRE LIKE '%" + pNombre + "%'";

            SqlConnection con = new SqlConnection(Conexion.sConnecttion);
            DataSet objDS = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDS);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en base de datos: " + ex.Message);
            }
            finally
            {
                con.Dispose();
                con.Dispose();
            }
            return objDS;
        }
        public DataSet EliminarProducto(int pIdProducto)
        {
            SQL = "DELETE FROM PRODUCTO WHERE ID_PRODUCTO='" + pIdProducto + "'";

            SqlConnection con = new SqlConnection(Conexion.sConnecttion);
            DataSet objDS = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDS);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en base de datos: " + ex.Message);
            }
            finally
            {
                con.Dispose();
                con.Dispose();
            }
            return objDS;
        }

        //VENDEDOR


        public int AgregarVendedor(string pNombre, string pApellido, int pDni, string pCuit)
        {
            SQL = "INSERT INTO VENDEDOR (NOMBRE, APELLIDO, DNI, CUIT) " +
                  "VALUES (@pNombre, @pApellido, @pDni, @pCuit)";

            SqlConnection con = new SqlConnection(Conexion.sConnecttion);
            SqlCommand com = new SqlCommand(SQL, con);

            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 80).Value = pNombre;
            com.Parameters.Add("@pApellido", SqlDbType.VarChar, 80).Value = pApellido;
            com.Parameters.Add("@pDni", SqlDbType.Int).Value = pDni;
            com.Parameters.Add("@pCuit", SqlDbType.NVarChar, 13).Value = pCuit.Trim();

            try
            {
                con.Open();
                objTransaction = con.BeginTransaction();
                com.Transaction = objTransaction;

                int filas = com.ExecuteNonQuery();
                if (filas == 0)
                    throw new Exception("No se insertó el vendedor.");

                Identidad = Convert.ToInt32(retParam.Value);
                objTransaction.Commit();
            }
            catch (SqlException ex)
            {
                if (objTransaction != null) objTransaction.Rollback();
                throw new Exception("Error en Base de Datos: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
                con.Dispose();
                com.Dispose();
            }

            return Identidad;
        }
        public int ModificarVendedor(int pIdVendedor, string pNombre, string pApellido, int pDni, string pCuit)
        {

            SQL = "UPDATE VENDEDOR SET NOMBRE=@pNombre, APELLIDO=@pApellido, DNI=@pDni, CUIT=@pCuit " +
                  "WHERE ID_VENDEDOR = @pIdVendedor";

            SqlConnection con = new SqlConnection(Conexion.sConnecttion);
            SqlCommand com = new SqlCommand(SQL, con);

            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 80).Value = pNombre;
            com.Parameters.Add("@pApellido", SqlDbType.VarChar, 80).Value = pApellido;
            com.Parameters.Add("@pDni", SqlDbType.Int).Value = pDni;
            com.Parameters.Add("@pCuit", SqlDbType.NVarChar, 13).Value = pCuit.Trim();
            com.Parameters.Add("@pIdVendedor", SqlDbType.Int).Value = pIdVendedor;

            try
            {
                con.Open();
                objTransaction = con.BeginTransaction();
                com.Transaction = objTransaction;

                int filas = com.ExecuteNonQuery();
                if (filas == 0)
                    throw new Exception("No se pudo modificar el vendedor. Verifique el ID.");

                Identidad = Convert.ToInt32(retParam.Value);
                objTransaction.Commit();
            }
            catch (SqlException ex)
            {
                if (objTransaction != null) objTransaction.Rollback();
                throw new Exception("Error en Base de Datos: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
                con.Dispose();
                com.Dispose();
            }

            return Identidad;
        }
        public DataSet BuscarVendedor(string pApellido)
        {
            SQL = "SELECT * FROM VENDEDOR WHERE APELLIDO LIKE '%' + @pApellido + '%'";

            SqlConnection con = new SqlConnection(Conexion.sConnecttion);
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            com.Parameters.Add("@pApellido", SqlDbType.VarChar, 80).Value = pApellido;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en base de datos: " + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }

            return ds;
        }
        public DataSet EliminarVendedor(int pIdVendedor)
        {
            SQL = "DELETE FROM VENDEDOR WHERE ID_VENDEDOR='" + pIdVendedor + "'";

            SqlConnection con = new SqlConnection(Conexion.sConnecttion);
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return ds;
        }
        //public Usuario? Login(string pApellido)
        //{
        //    SQL = "SELECT LOGIN, APELLYNOM, PASSW, FCH_ALTA, FCH_BAJA '%' + @pApellido + '%'";

        //    SqlConnection con = new SqlConnection(Conexion.sConnecttion);
        //    DataSet ds = new DataSet();
        //    SqlCommand com = new SqlCommand(SQL, con);
        //    com.Parameters.Add("@pApellido", SqlDbType.VarChar, 80).Value = pApellido;
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = com;

        //    try
        //    {
        //        da.Fill(ds);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Error en base de datos: " + ex.Message);
        //    }
        //    finally
        //    {
        //        con.Dispose();
        //        com.Dispose();
        //    }

        //    return ds;
        //}

    }
}
