using Integrador2025.Datos;
using System.Data;

namespace Integrador2026;

public partial class Presentacion : Form
{
    public Presentacion()
    {
        InitializeComponent();
    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            Dal objdal = new Dal();
            objdal.AgregarProducto(
                txtNombre.Text,
                txtDescripcion.Text,
                Convert.ToDecimal(txtPrecioCosto.Text),
                Convert.ToDecimal(txtMargen.Text),
                Convert.ToDecimal(txtIVA.Text),
                Convert.ToDecimal(txtPrecioBruto.Text),
                Convert.ToDecimal(txtPrecioVenta.Text),
                txtProveedor.Text,
                cmbCategoria.Text,
                cmbSubCat.Text);
            MessageBox.Show("Producto registrado con éxito");
            btnBuscar_Click(null, null);
            LimpiarControles(this);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al agregar el producto:\n" + ex.Message);
        }
    }
    private void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {
            Dal db = new Dal();
            DataSet ds = db.BuscarProducto(txtBuscarProducto.Text);
            dgvProducto.DataSource = ds.Tables[0];
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al buscar:\n" + ex.Message);
        }
    }
    public void LimpiarControles(Control parent)
    {
        foreach (Control control in parent.Controls)
        {
            switch (control)
            {
                case TextBox textBox:
                    textBox.Clear();
                    break;
                case ComboBox comboBox:
                    comboBox.SelectedIndex = -1;
                    comboBox.Text = string.Empty;
                    break;
                case MaskedTextBox maskedTextBox:
                    maskedTextBox.Clear();
                    break;
            }
            if (control.HasChildren)
            {
                LimpiarControles(control);
            }
        }
    }
    private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void tbcProducto_Click(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {

    }

    private void btnModificarVend_Click(object sender, EventArgs e)
    {

    }
}