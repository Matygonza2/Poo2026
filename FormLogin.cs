using Integrador2025.Datos;
using Integrador2025.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador2026
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Usuarioprop, Contraseña; //Declaro variables
            Usuarioprop = txtUsuario.Text.Trim();
            Contraseña = mtbContraseña.Text.TrimEnd();
            try
            {
                DalLogin dal = new DalLogin();
                Usuario? usuario = dal.Login(Usuarioprop, Contraseña); //?opcional
                if (usuario != null)
                {
                    Presentacion presentacion = new Presentacion(); //instanciar clase
                    presentacion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acceso denegado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error en la base de datos al iniciar sesión:\n\n{ex.Message}",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}
