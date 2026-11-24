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
    private void btnModificar_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvProducto.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto."); return;
            }

            int idSeleccionado = Convert.ToInt32(dgvProducto.CurrentRow.Cells["ID_PRODUCTO"].Value);

            Dal objdal = new Dal();
            objdal.ModificarProducto(
                idSeleccionado,
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
            MessageBox.Show("Producto modificado con éxito");


            // Recargar la grilla
            //DataSet ds = objdal.BuscarProducto("");
            //dgvProducto.DataSource = ds.Tables[0];
        }

        catch (Exception ex)
        {
            MessageBox.Show("Error al modificar:\n" + ex.Message);
        }
    }
    private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgvProducto.CurrentRow == null) return;

        txtNombre.Text = dgvProducto.CurrentRow.Cells["NOMBRE"].Value.ToString();
        txtDescripcion.Text = dgvProducto.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
        txtPrecioCosto.Text = dgvProducto.CurrentRow.Cells["PRECIOCOSTO"].Value.ToString();
        txtMargen.Text = dgvProducto.CurrentRow.Cells["MARGEN"].Value.ToString();
        txtIVA.Text = dgvProducto.CurrentRow.Cells["IVA"].Value.ToString();
        txtPrecioBruto.Text = dgvProducto.CurrentRow.Cells["PRECIOBRUTO"].Value.ToString();
        txtPrecioVenta.Text = dgvProducto.CurrentRow.Cells["PRECIOVENTA"].Value.ToString();
        txtProveedor.Text = dgvProducto.CurrentRow.Cells["PROVEEDOR"].Value.ToString();
        cmbCategoria.Text = dgvProducto.CurrentRow.Cells["CATEGORIA"].Value.ToString();
        cmbSubCat.Text = dgvProducto.CurrentRow.Cells["SUBCATEGORIA"].Value.ToString();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvProducto.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }
            if (MessageBox.Show("¿Eliminar producto seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            //obtener ID
            int idSeleccionado = Convert.ToInt32(dgvProducto.CurrentRow.Cells["ID_PRODUCTO"].Value);

            Dal objdal = new Dal();
            objdal.EliminarProducto(idSeleccionado);

            MessageBox.Show("Producto eliminado con éxito");
            btnBuscar_Click(null, null);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar:\n" + ex.Message);
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
    private void btnBuscarVend_Click(object sender, EventArgs e)
    {
        try
        {
            Dal db = new Dal();
            DataSet ds = db.BuscarVendedor(txtBuscarVend.Text);
            dgvVendedor.DataSource = ds.Tables[0];
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al buscar:\n" + ex.Message);
        }
    }
    private void btnAgregarVend_Click(object sender, EventArgs e)
    {
        try
        {
            Dal db = new Dal();

            db.AgregarVendedor(
                txtNomVendedor.Text,
                txtApellVendedor.Text,
                Convert.ToInt32(txtDNI.Text),
                mtbCUIT.Text);
            MessageBox.Show("Vendedor registrado con éxito.");
            btnBuscarVend_Click(null, null);
            LimpiarControles(this);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al agregar:\n" + ex.Message);
        }
    }
    private void btnModificarVend_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvVendedor.CurrentRow == null)
                throw new Exception("Debe seleccionar un vendedor.");

            int id = Convert.ToInt32(dgvVendedor.CurrentRow.Cells["ID_VENDEDOR"].Value);

            Dal db = new Dal();

            db.ModificarVendedor(
                id,
                txtNomVendedor.Text,
                txtApellVendedor.Text,
                Convert.ToInt32(txtDNI.Text),
                mtbCUIT.Text);
            MessageBox.Show("Vendedor modificado con éxito.");
            btnBuscarVend_Click(null, null);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al modificar:\n" + ex.Message);
        }
    }
    private void btnEliminarVend_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvVendedor.CurrentRow == null)
                throw new Exception("Debe seleccionar un vendedor.");
            if (MessageBox.Show("¿Eliminar vendedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            int id = Convert.ToInt32(dgvVendedor.CurrentRow.Cells["ID_VENDEDOR"].Value);

            Dal db = new Dal();
            db.EliminarVendedor(id);

            MessageBox.Show("Vendedor eliminado con éxito.");
            btnBuscarVend_Click(null, null);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar:\n" + ex.Message);
        }
    }
    private void dgvVendedor_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgvVendedor.CurrentRow == null) return;

        txtNomVendedor.Text = dgvVendedor.CurrentRow.Cells["Nombre"].Value.ToString();
        txtApellVendedor.Text = dgvVendedor.CurrentRow.Cells["Apellido"].Value.ToString();
        txtDNI.Text = dgvVendedor.CurrentRow.Cells["DNI"].Value.ToString();
        mtbCUIT.Text = dgvVendedor.CurrentRow.Cells["CUIT"].Value.ToString();
    }
    private void tbcProducto_Click(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {

    }

   
}