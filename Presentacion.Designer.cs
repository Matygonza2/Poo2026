namespace Integrador2026;

partial class Presentacion
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presentacion));
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        tabControl1 = new System.Windows.Forms.TabControl();
        tbcProducto = new System.Windows.Forms.TabPage();
        pbxFotoproducto = new System.Windows.Forms.PictureBox();
        ComboBoxSubcategoria = new System.Windows.Forms.ComboBox();
        comboBoxCategoria = new System.Windows.Forms.ComboBox();
        txtProveedor = new System.Windows.Forms.TextBox();
        txtPrecioVenta = new System.Windows.Forms.TextBox();
        txtPrecioBruto = new System.Windows.Forms.TextBox();
        txtIva = new System.Windows.Forms.TextBox();
        txtMargen = new System.Windows.Forms.TextBox();
        txtPrecioCosto = new System.Windows.Forms.TextBox();
        txtDecripcion = new System.Windows.Forms.TextBox();
        txtNombre = new System.Windows.Forms.TextBox();
        lblSubcategoria = new System.Windows.Forms.Label();
        lblCategoria = new System.Windows.Forms.Label();
        lblProveedor = new System.Windows.Forms.Label();
        lblPrecioVenta = new System.Windows.Forms.Label();
        lblPrecioBruto = new System.Windows.Forms.Label();
        lblIva = new System.Windows.Forms.Label();
        lblMargen = new System.Windows.Forms.Label();
        lblPrecioCosto = new System.Windows.Forms.Label();
        lblDescripcion = new System.Windows.Forms.Label();
        lblNombre = new System.Windows.Forms.Label();
        tbcVendedor = new System.Windows.Forms.TabPage();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        MskVendedorCuit = new System.Windows.Forms.MaskedTextBox();
        txtVendedorDni = new System.Windows.Forms.TextBox();
        txtVendedorApellido = new System.Windows.Forms.TextBox();
        txtVendedorNombre = new System.Windows.Forms.TextBox();
        lblVendedorCuit = new System.Windows.Forms.Label();
        lblVendedorDni = new System.Windows.Forms.Label();
        lblVendedorApellido = new System.Windows.Forms.Label();
        lblVendedorNombre = new System.Windows.Forms.Label();
        imageList1 = new System.Windows.Forms.ImageList(components);
        menuStrip1.SuspendLayout();
        tabControl1.SuspendLayout();
        tbcProducto.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).BeginInit();
        tbcVendedor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { archivoToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(521, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // archivoToolStripMenuItem
        // 
        archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { salirToolStripMenuItem });
        archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
        archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
        archivoToolStripMenuItem.Text = "Arc&hivo";
        archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
        // 
        // salirToolStripMenuItem
        // 
        salirToolStripMenuItem.Name = "salirToolStripMenuItem";
        salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
        salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
        salirToolStripMenuItem.Text = "&Salir";
        salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tbcProducto);
        tabControl1.Controls.Add(tbcVendedor);
        tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControl1.ImageList = imageList1;
        tabControl1.Location = new System.Drawing.Point(0, 24);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(521, 398);
        tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
        tabControl1.TabIndex = 1;
        // 
        // tbcProducto
        // 
        tbcProducto.Controls.Add(pbxFotoproducto);
        tbcProducto.Controls.Add(ComboBoxSubcategoria);
        tbcProducto.Controls.Add(comboBoxCategoria);
        tbcProducto.Controls.Add(txtProveedor);
        tbcProducto.Controls.Add(txtPrecioVenta);
        tbcProducto.Controls.Add(txtPrecioBruto);
        tbcProducto.Controls.Add(txtIva);
        tbcProducto.Controls.Add(txtMargen);
        tbcProducto.Controls.Add(txtPrecioCosto);
        tbcProducto.Controls.Add(txtDecripcion);
        tbcProducto.Controls.Add(txtNombre);
        tbcProducto.Controls.Add(lblSubcategoria);
        tbcProducto.Controls.Add(lblCategoria);
        tbcProducto.Controls.Add(lblProveedor);
        tbcProducto.Controls.Add(lblPrecioVenta);
        tbcProducto.Controls.Add(lblPrecioBruto);
        tbcProducto.Controls.Add(lblIva);
        tbcProducto.Controls.Add(lblMargen);
        tbcProducto.Controls.Add(lblPrecioCosto);
        tbcProducto.Controls.Add(lblDescripcion);
        tbcProducto.Controls.Add(lblNombre);
        tbcProducto.ImageKey = "Clientes.ico";
        tbcProducto.Location = new System.Drawing.Point(4, 24);
        tbcProducto.Name = "tbcProducto";
        tbcProducto.Padding = new System.Windows.Forms.Padding(3);
        tbcProducto.Size = new System.Drawing.Size(513, 370);
        tbcProducto.TabIndex = 0;
        tbcProducto.Text = "Productos";
        tbcProducto.UseVisualStyleBackColor = true;
        tbcProducto.Click += tbcProducto_Click;
        // 
        // pbxFotoproducto
        // 
        pbxFotoproducto.Image = ((System.Drawing.Image)resources.GetObject("pbxFotoproducto.Image"));
        pbxFotoproducto.Location = new System.Drawing.Point(44, 291);
        pbxFotoproducto.Name = "pbxFotoproducto";
        pbxFotoproducto.Size = new System.Drawing.Size(367, 71);
        pbxFotoproducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pbxFotoproducto.TabIndex = 20;
        pbxFotoproducto.TabStop = false;
        // 
        // ComboBoxSubcategoria
        // 
        ComboBoxSubcategoria.FormattingEnabled = true;
        ComboBoxSubcategoria.Items.AddRange(new object[] { " SUBCATEGORIA A.A", "SUBCATEGORIA A.B", "SUBCATEGORIA A.C", "SUBCATEGORIA B.B", "SUBCATEGORIA B.C", "SUBCATEGORIA C.C" });
        ComboBoxSubcategoria.Location = new System.Drawing.Point(136, 247);
        ComboBoxSubcategoria.Name = "ComboBoxSubcategoria";
        ComboBoxSubcategoria.Size = new System.Drawing.Size(231, 23);
        ComboBoxSubcategoria.TabIndex = 19;
        // 
        // comboBoxCategoria
        // 
        comboBoxCategoria.FormattingEnabled = true;
        comboBoxCategoria.Items.AddRange(new object[] { "CATEGORIA A ", "CATEGORIA B ", "CATEGORIA C" });
        comboBoxCategoria.Location = new System.Drawing.Point(136, 218);
        comboBoxCategoria.Name = "comboBoxCategoria";
        comboBoxCategoria.Size = new System.Drawing.Size(231, 23);
        comboBoxCategoria.TabIndex = 18;
        // 
        // txtProveedor
        // 
        txtProveedor.Location = new System.Drawing.Point(136, 189);
        txtProveedor.Name = "txtProveedor";
        txtProveedor.Size = new System.Drawing.Size(226, 23);
        txtProveedor.TabIndex = 17;
        // 
        // txtPrecioVenta
        // 
        txtPrecioVenta.Location = new System.Drawing.Point(136, 163);
        txtPrecioVenta.Name = "txtPrecioVenta";
        txtPrecioVenta.Size = new System.Drawing.Size(226, 23);
        txtPrecioVenta.TabIndex = 16;
        // 
        // txtPrecioBruto
        // 
        txtPrecioBruto.Location = new System.Drawing.Point(136, 138);
        txtPrecioBruto.Name = "txtPrecioBruto";
        txtPrecioBruto.Size = new System.Drawing.Size(226, 23);
        txtPrecioBruto.TabIndex = 15;
        // 
        // txtIva
        // 
        txtIva.Location = new System.Drawing.Point(136, 112);
        txtIva.Name = "txtIva";
        txtIva.Size = new System.Drawing.Size(226, 23);
        txtIva.TabIndex = 14;
        // 
        // txtMargen
        // 
        txtMargen.Location = new System.Drawing.Point(136, 87);
        txtMargen.Name = "txtMargen";
        txtMargen.Size = new System.Drawing.Size(226, 23);
        txtMargen.TabIndex = 13;
        // 
        // txtPrecioCosto
        // 
        txtPrecioCosto.Location = new System.Drawing.Point(136, 62);
        txtPrecioCosto.Name = "txtPrecioCosto";
        txtPrecioCosto.Size = new System.Drawing.Size(226, 23);
        txtPrecioCosto.TabIndex = 12;
        // 
        // txtDecripcion
        // 
        txtDecripcion.Location = new System.Drawing.Point(136, 38);
        txtDecripcion.Name = "txtDecripcion";
        txtDecripcion.Size = new System.Drawing.Size(226, 23);
        txtDecripcion.TabIndex = 11;
        // 
        // txtNombre
        // 
        txtNombre.Location = new System.Drawing.Point(136, 10);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new System.Drawing.Size(226, 23);
        txtNombre.TabIndex = 10;
        // 
        // lblSubcategoria
        // 
        lblSubcategoria.Location = new System.Drawing.Point(15, 246);
        lblSubcategoria.Name = "lblSubcategoria";
        lblSubcategoria.Size = new System.Drawing.Size(96, 16);
        lblSubcategoria.TabIndex = 9;
        lblSubcategoria.Text = "SUBCATEGORIA";
        // 
        // lblCategoria
        // 
        lblCategoria.Location = new System.Drawing.Point(15, 221);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Size = new System.Drawing.Size(96, 16);
        lblCategoria.TabIndex = 8;
        lblCategoria.Text = "CATEGORIA";
        // 
        // lblProveedor
        // 
        lblProveedor.Location = new System.Drawing.Point(15, 197);
        lblProveedor.Name = "lblProveedor";
        lblProveedor.Size = new System.Drawing.Size(96, 15);
        lblProveedor.TabIndex = 7;
        lblProveedor.Text = "PROVEEDOR";
        // 
        // lblPrecioVenta
        // 
        lblPrecioVenta.Location = new System.Drawing.Point(15, 170);
        lblPrecioVenta.Name = "lblPrecioVenta";
        lblPrecioVenta.Size = new System.Drawing.Size(96, 16);
        lblPrecioVenta.TabIndex = 6;
        lblPrecioVenta.Text = "PRECIOVENTA";
        // 
        // lblPrecioBruto
        // 
        lblPrecioBruto.Location = new System.Drawing.Point(15, 145);
        lblPrecioBruto.Name = "lblPrecioBruto";
        lblPrecioBruto.Size = new System.Drawing.Size(96, 16);
        lblPrecioBruto.TabIndex = 5;
        lblPrecioBruto.Text = "PRECIOBRUTO";
        // 
        // lblIva
        // 
        lblIva.Location = new System.Drawing.Point(15, 115);
        lblIva.Name = "lblIva";
        lblIva.Size = new System.Drawing.Size(96, 16);
        lblIva.TabIndex = 4;
        lblIva.Text = "IVA";
        // 
        // lblMargen
        // 
        lblMargen.Location = new System.Drawing.Point(15, 90);
        lblMargen.Name = "lblMargen";
        lblMargen.Size = new System.Drawing.Size(96, 16);
        lblMargen.TabIndex = 3;
        lblMargen.Text = "MARGEN";
        // 
        // lblPrecioCosto
        // 
        lblPrecioCosto.Location = new System.Drawing.Point(15, 65);
        lblPrecioCosto.Name = "lblPrecioCosto";
        lblPrecioCosto.Size = new System.Drawing.Size(96, 16);
        lblPrecioCosto.TabIndex = 2;
        lblPrecioCosto.Text = "PRECIOCOSTO";
        // 
        // lblDescripcion
        // 
        lblDescripcion.Location = new System.Drawing.Point(15, 38);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new System.Drawing.Size(96, 16);
        lblDescripcion.TabIndex = 1;
        lblDescripcion.Text = "DESCRIPCION";
        // 
        // lblNombre
        // 
        lblNombre.Location = new System.Drawing.Point(15, 13);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new System.Drawing.Size(96, 16);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "NOMBRE";
        // 
        // tbcVendedor
        // 
        tbcVendedor.Controls.Add(pictureBox1);
        tbcVendedor.Controls.Add(MskVendedorCuit);
        tbcVendedor.Controls.Add(txtVendedorDni);
        tbcVendedor.Controls.Add(txtVendedorApellido);
        tbcVendedor.Controls.Add(txtVendedorNombre);
        tbcVendedor.Controls.Add(lblVendedorCuit);
        tbcVendedor.Controls.Add(lblVendedorDni);
        tbcVendedor.Controls.Add(lblVendedorApellido);
        tbcVendedor.Controls.Add(lblVendedorNombre);
        tbcVendedor.ImageKey = "Vendedores.ico";
        tbcVendedor.Location = new System.Drawing.Point(4, 24);
        tbcVendedor.Name = "tbcVendedor";
        tbcVendedor.Padding = new System.Windows.Forms.Padding(3);
        tbcVendedor.Size = new System.Drawing.Size(513, 370);
        tbcVendedor.TabIndex = 1;
        tbcVendedor.Text = "Vendedores";
        tbcVendedor.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(45, 183);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(275, 88);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 8;
        pictureBox1.TabStop = false;
        // 
        // MskVendedorCuit
        // 
        MskVendedorCuit.Location = new System.Drawing.Point(91, 128);
        MskVendedorCuit.Mask = " 99-99999999-9 ";
        MskVendedorCuit.Name = "MskVendedorCuit";
        MskVendedorCuit.Size = new System.Drawing.Size(187, 23);
        MskVendedorCuit.TabIndex = 7;
        // 
        // txtVendedorDni
        // 
        txtVendedorDni.Location = new System.Drawing.Point(101, 88);
        txtVendedorDni.Name = "txtVendedorDni";
        txtVendedorDni.Size = new System.Drawing.Size(145, 23);
        txtVendedorDni.TabIndex = 6;
        // 
        // txtVendedorApellido
        // 
        txtVendedorApellido.Location = new System.Drawing.Point(101, 59);
        txtVendedorApellido.Name = "txtVendedorApellido";
        txtVendedorApellido.Size = new System.Drawing.Size(145, 23);
        txtVendedorApellido.TabIndex = 5;
        // 
        // txtVendedorNombre
        // 
        txtVendedorNombre.Location = new System.Drawing.Point(101, 24);
        txtVendedorNombre.Name = "txtVendedorNombre";
        txtVendedorNombre.Size = new System.Drawing.Size(145, 23);
        txtVendedorNombre.TabIndex = 4;
        // 
        // lblVendedorCuit
        // 
        lblVendedorCuit.Location = new System.Drawing.Point(17, 118);
        lblVendedorCuit.Name = "lblVendedorCuit";
        lblVendedorCuit.Size = new System.Drawing.Size(125, 26);
        lblVendedorCuit.TabIndex = 3;
        lblVendedorCuit.Text = "CUIT";
        // 
        // lblVendedorDni
        // 
        lblVendedorDni.Location = new System.Drawing.Point(17, 85);
        lblVendedorDni.Name = "lblVendedorDni";
        lblVendedorDni.Size = new System.Drawing.Size(125, 18);
        lblVendedorDni.TabIndex = 2;
        lblVendedorDni.Text = "DNI";
        // 
        // lblVendedorApellido
        // 
        lblVendedorApellido.Location = new System.Drawing.Point(17, 57);
        lblVendedorApellido.Name = "lblVendedorApellido";
        lblVendedorApellido.Size = new System.Drawing.Size(125, 18);
        lblVendedorApellido.TabIndex = 1;
        lblVendedorApellido.Text = "APELLIDO";
        // 
        // lblVendedorNombre
        // 
        lblVendedorNombre.Location = new System.Drawing.Point(17, 24);
        lblVendedorNombre.Name = "lblVendedorNombre";
        lblVendedorNombre.Size = new System.Drawing.Size(125, 18);
        lblVendedorNombre.TabIndex = 0;
        lblVendedorNombre.Text = "NOMBRE";
        // 
        // imageList1
        // 
        imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream"));
        imageList1.TransparentColor = System.Drawing.Color.Transparent;
        imageList1.Images.SetKeyName(0, "Vendedores.ico");
        imageList1.Images.SetKeyName(1, "Clientes.ico");
        // 
        // Presentacion
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(521, 422);
        Controls.Add(tabControl1);
        Controls.Add(menuStrip1);
        HelpButton = true;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "INSUMOS DE COMPUTACION";
        
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        tabControl1.ResumeLayout(false);
        tbcProducto.ResumeLayout(false);
        tbcProducto.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).EndInit();
        tbcVendedor.ResumeLayout(false);
        tbcVendedor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.MaskedTextBox MskVendedorCuit;

    private System.Windows.Forms.TextBox txtVendedorNombre;
    private System.Windows.Forms.TextBox txtVendedorApellido;
    private System.Windows.Forms.TextBox txtVendedorDni;

    private System.Windows.Forms.Label lblVendedorNombre;
    private System.Windows.Forms.Label lblVendedorApellido;
    private System.Windows.Forms.Label lblVendedorDni;
    private System.Windows.Forms.Label lblVendedorCuit;

    private System.Windows.Forms.PictureBox pbxFotoproducto;

    private System.Windows.Forms.ComboBox ComboBoxSubcategoria;

    private System.Windows.Forms.ComboBox comboBoxCategoria;

    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtDecripcion;
    private System.Windows.Forms.TextBox txtPrecioCosto;
    private System.Windows.Forms.TextBox txtMargen;
    private System.Windows.Forms.TextBox txtIva;
    private System.Windows.Forms.TextBox txtPrecioBruto;
    private System.Windows.Forms.TextBox txtPrecioVenta;
    private System.Windows.Forms.TextBox txtProveedor;

    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Label lblDescripcion;
    private System.Windows.Forms.Label lblPrecioCosto;
    private System.Windows.Forms.Label lblMargen;
    private System.Windows.Forms.Label lblIva;
    private System.Windows.Forms.Label lblPrecioBruto;
    private System.Windows.Forms.Label lblPrecioVenta;
    private System.Windows.Forms.Label lblProveedor;
    private System.Windows.Forms.Label lblCategoria;
    private System.Windows.Forms.Label lblSubcategoria;

    private System.Windows.Forms.ImageList imageList1;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tbcProducto;
    private System.Windows.Forms.TabPage tbcVendedor;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
}