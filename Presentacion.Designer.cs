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
        toolStripMenuItem1 = new ToolStripMenuItem();
        menuStrip1 = new MenuStrip();
        archivoToolStripMenuItem = new ToolStripMenuItem();
        salirToolStripMenuItem = new ToolStripMenuItem();
        tabControl1 = new TabControl();
        tbcProducto = new TabPage();
        pbxFotoproducto = new PictureBox();
        ComboBoxSubcategoria = new ComboBox();
        comboBoxCategoria = new ComboBox();
        txtProveedor = new TextBox();
        txtPrecioVenta = new TextBox();
        txtPrecioBruto = new TextBox();
        txtIva = new TextBox();
        txtMargen = new TextBox();
        txtPrecioCosto = new TextBox();
        txtDecripcion = new TextBox();
        txtNombre = new TextBox();
        lblSubcategoria = new Label();
        lblCategoria = new Label();
        lblProveedor = new Label();
        lblPrecioVenta = new Label();
        lblPrecioBruto = new Label();
        lblIva = new Label();
        lblMargen = new Label();
        lblPrecioCosto = new Label();
        lblDescripcion = new Label();
        lblNombre = new Label();
        tbcVendedor = new TabPage();
        pictureBox1 = new PictureBox();
        MskVendedorCuit = new MaskedTextBox();
        txtVendedorDni = new TextBox();
        txtVendedorApellido = new TextBox();
        txtVendedorNombre = new TextBox();
        lblVendedorCuit = new Label();
        lblVendedorDni = new Label();
        lblVendedorApellido = new Label();
        lblVendedorNombre = new Label();
        imageList1 = new ImageList(components);
        label1 = new Label();
        textBox1 = new TextBox();
        dataGridView1 = new DataGridView();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        dataGridView2 = new DataGridView();
        label2 = new Label();
        textBox2 = new TextBox();
        menuStrip1.SuspendLayout();
        tabControl1.SuspendLayout();
        tbcProducto.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).BeginInit();
        tbcVendedor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        SuspendLayout();
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(32, 19);
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(679, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // archivoToolStripMenuItem
        // 
        archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
        archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
        archivoToolStripMenuItem.Size = new Size(60, 20);
        archivoToolStripMenuItem.Text = "Arc&hivo";
        archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
        // 
        // salirToolStripMenuItem
        // 
        salirToolStripMenuItem.Name = "salirToolStripMenuItem";
        salirToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
        salirToolStripMenuItem.Size = new Size(138, 22);
        salirToolStripMenuItem.Text = "&Salir";
        salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tbcProducto);
        tabControl1.Controls.Add(tbcVendedor);
        tabControl1.Dock = DockStyle.Fill;
        tabControl1.ImageList = imageList1;
        tabControl1.Location = new Point(0, 24);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(679, 492);
        tabControl1.SizeMode = TabSizeMode.Fixed;
        tabControl1.TabIndex = 1;
        // 
        // tbcProducto
        // 
        tbcProducto.Controls.Add(button4);
        tbcProducto.Controls.Add(button3);
        tbcProducto.Controls.Add(button2);
        tbcProducto.Controls.Add(button1);
        tbcProducto.Controls.Add(dataGridView1);
        tbcProducto.Controls.Add(textBox1);
        tbcProducto.Controls.Add(label1);
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
        tbcProducto.Location = new Point(4, 24);
        tbcProducto.Name = "tbcProducto";
        tbcProducto.Padding = new Padding(3);
        tbcProducto.Size = new Size(671, 464);
        tbcProducto.TabIndex = 0;
        tbcProducto.Text = "Productos";
        tbcProducto.UseVisualStyleBackColor = true;
        tbcProducto.Click += tbcProducto_Click;
        // 
        // pbxFotoproducto
        // 
        pbxFotoproducto.Image = (Image)resources.GetObject("pbxFotoproducto.Image");
        pbxFotoproducto.Location = new Point(456, 14);
        pbxFotoproducto.Name = "pbxFotoproducto";
        pbxFotoproducto.Size = new Size(135, 71);
        pbxFotoproducto.SizeMode = PictureBoxSizeMode.Zoom;
        pbxFotoproducto.TabIndex = 20;
        pbxFotoproducto.TabStop = false;
        // 
        // ComboBoxSubcategoria
        // 
        ComboBoxSubcategoria.FormattingEnabled = true;
        ComboBoxSubcategoria.Items.AddRange(new object[] { " SUBCATEGORIA A.A", "SUBCATEGORIA A.B", "SUBCATEGORIA A.C", "SUBCATEGORIA B.B", "SUBCATEGORIA B.C", "SUBCATEGORIA C.C" });
        ComboBoxSubcategoria.Location = new Point(136, 247);
        ComboBoxSubcategoria.Name = "ComboBoxSubcategoria";
        ComboBoxSubcategoria.Size = new Size(231, 23);
        ComboBoxSubcategoria.TabIndex = 19;
        // 
        // comboBoxCategoria
        // 
        comboBoxCategoria.FormattingEnabled = true;
        comboBoxCategoria.Items.AddRange(new object[] { "CATEGORIA A ", "CATEGORIA B ", "CATEGORIA C" });
        comboBoxCategoria.Location = new Point(136, 218);
        comboBoxCategoria.Name = "comboBoxCategoria";
        comboBoxCategoria.Size = new Size(231, 23);
        comboBoxCategoria.TabIndex = 18;
        // 
        // txtProveedor
        // 
        txtProveedor.Location = new Point(136, 189);
        txtProveedor.Name = "txtProveedor";
        txtProveedor.Size = new Size(226, 23);
        txtProveedor.TabIndex = 17;
        // 
        // txtPrecioVenta
        // 
        txtPrecioVenta.Location = new Point(136, 163);
        txtPrecioVenta.Name = "txtPrecioVenta";
        txtPrecioVenta.Size = new Size(226, 23);
        txtPrecioVenta.TabIndex = 16;
        // 
        // txtPrecioBruto
        // 
        txtPrecioBruto.Location = new Point(136, 138);
        txtPrecioBruto.Name = "txtPrecioBruto";
        txtPrecioBruto.Size = new Size(226, 23);
        txtPrecioBruto.TabIndex = 15;
        // 
        // txtIva
        // 
        txtIva.Location = new Point(136, 112);
        txtIva.Name = "txtIva";
        txtIva.Size = new Size(226, 23);
        txtIva.TabIndex = 14;
        // 
        // txtMargen
        // 
        txtMargen.Location = new Point(136, 87);
        txtMargen.Name = "txtMargen";
        txtMargen.Size = new Size(226, 23);
        txtMargen.TabIndex = 13;
        // 
        // txtPrecioCosto
        // 
        txtPrecioCosto.Location = new Point(136, 62);
        txtPrecioCosto.Name = "txtPrecioCosto";
        txtPrecioCosto.Size = new Size(226, 23);
        txtPrecioCosto.TabIndex = 12;
        // 
        // txtDecripcion
        // 
        txtDecripcion.Location = new Point(136, 38);
        txtDecripcion.Name = "txtDecripcion";
        txtDecripcion.Size = new Size(226, 23);
        txtDecripcion.TabIndex = 11;
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(136, 10);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(226, 23);
        txtNombre.TabIndex = 10;
        // 
        // lblSubcategoria
        // 
        lblSubcategoria.Location = new Point(15, 246);
        lblSubcategoria.Name = "lblSubcategoria";
        lblSubcategoria.Size = new Size(96, 16);
        lblSubcategoria.TabIndex = 9;
        lblSubcategoria.Text = "SUBCATEGORIA";
        // 
        // lblCategoria
        // 
        lblCategoria.Location = new Point(15, 221);
        lblCategoria.Name = "lblCategoria";
        lblCategoria.Size = new Size(96, 16);
        lblCategoria.TabIndex = 8;
        lblCategoria.Text = "CATEGORIA";
        // 
        // lblProveedor
        // 
        lblProveedor.Location = new Point(15, 197);
        lblProveedor.Name = "lblProveedor";
        lblProveedor.Size = new Size(96, 15);
        lblProveedor.TabIndex = 7;
        lblProveedor.Text = "PROVEEDOR";
        // 
        // lblPrecioVenta
        // 
        lblPrecioVenta.Location = new Point(15, 170);
        lblPrecioVenta.Name = "lblPrecioVenta";
        lblPrecioVenta.Size = new Size(96, 16);
        lblPrecioVenta.TabIndex = 6;
        lblPrecioVenta.Text = "PRECIOVENTA";
        // 
        // lblPrecioBruto
        // 
        lblPrecioBruto.Location = new Point(15, 145);
        lblPrecioBruto.Name = "lblPrecioBruto";
        lblPrecioBruto.Size = new Size(96, 16);
        lblPrecioBruto.TabIndex = 5;
        lblPrecioBruto.Text = "PRECIOBRUTO";
        // 
        // lblIva
        // 
        lblIva.Location = new Point(15, 115);
        lblIva.Name = "lblIva";
        lblIva.Size = new Size(96, 16);
        lblIva.TabIndex = 4;
        lblIva.Text = "IVA";
        // 
        // lblMargen
        // 
        lblMargen.Location = new Point(15, 90);
        lblMargen.Name = "lblMargen";
        lblMargen.Size = new Size(96, 16);
        lblMargen.TabIndex = 3;
        lblMargen.Text = "MARGEN";
        // 
        // lblPrecioCosto
        // 
        lblPrecioCosto.Location = new Point(15, 65);
        lblPrecioCosto.Name = "lblPrecioCosto";
        lblPrecioCosto.Size = new Size(96, 16);
        lblPrecioCosto.TabIndex = 2;
        lblPrecioCosto.Text = "PRECIOCOSTO";
        // 
        // lblDescripcion
        // 
        lblDescripcion.Location = new Point(15, 38);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(96, 16);
        lblDescripcion.TabIndex = 1;
        lblDescripcion.Text = "DESCRIPCION";
        // 
        // lblNombre
        // 
        lblNombre.Location = new Point(15, 13);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(96, 16);
        lblNombre.TabIndex = 0;
        lblNombre.Text = "NOMBRE";
        // 
        // tbcVendedor
        // 
        tbcVendedor.Controls.Add(textBox2);
        tbcVendedor.Controls.Add(label2);
        tbcVendedor.Controls.Add(dataGridView2);
        tbcVendedor.Controls.Add(button8);
        tbcVendedor.Controls.Add(button7);
        tbcVendedor.Controls.Add(button6);
        tbcVendedor.Controls.Add(button5);
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
        tbcVendedor.Location = new Point(4, 24);
        tbcVendedor.Name = "tbcVendedor";
        tbcVendedor.Padding = new Padding(3);
        tbcVendedor.Size = new Size(671, 464);
        tbcVendedor.TabIndex = 1;
        tbcVendedor.Text = "Vendedores";
        tbcVendedor.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(45, 183);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(275, 88);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 8;
        pictureBox1.TabStop = false;
        // 
        // MskVendedorCuit
        // 
        MskVendedorCuit.Location = new Point(91, 128);
        MskVendedorCuit.Mask = " 99-99999999-9 ";
        MskVendedorCuit.Name = "MskVendedorCuit";
        MskVendedorCuit.Size = new Size(187, 23);
        MskVendedorCuit.TabIndex = 7;
        // 
        // txtVendedorDni
        // 
        txtVendedorDni.Location = new Point(101, 88);
        txtVendedorDni.Name = "txtVendedorDni";
        txtVendedorDni.Size = new Size(145, 23);
        txtVendedorDni.TabIndex = 6;
        // 
        // txtVendedorApellido
        // 
        txtVendedorApellido.Location = new Point(101, 59);
        txtVendedorApellido.Name = "txtVendedorApellido";
        txtVendedorApellido.Size = new Size(145, 23);
        txtVendedorApellido.TabIndex = 5;
        // 
        // txtVendedorNombre
        // 
        txtVendedorNombre.Location = new Point(101, 24);
        txtVendedorNombre.Name = "txtVendedorNombre";
        txtVendedorNombre.Size = new Size(145, 23);
        txtVendedorNombre.TabIndex = 4;
        // 
        // lblVendedorCuit
        // 
        lblVendedorCuit.Location = new Point(17, 118);
        lblVendedorCuit.Name = "lblVendedorCuit";
        lblVendedorCuit.Size = new Size(125, 26);
        lblVendedorCuit.TabIndex = 3;
        lblVendedorCuit.Text = "CUIT";
        // 
        // lblVendedorDni
        // 
        lblVendedorDni.Location = new Point(17, 85);
        lblVendedorDni.Name = "lblVendedorDni";
        lblVendedorDni.Size = new Size(125, 18);
        lblVendedorDni.TabIndex = 2;
        lblVendedorDni.Text = "DNI";
        // 
        // lblVendedorApellido
        // 
        lblVendedorApellido.Location = new Point(17, 57);
        lblVendedorApellido.Name = "lblVendedorApellido";
        lblVendedorApellido.Size = new Size(125, 18);
        lblVendedorApellido.TabIndex = 1;
        lblVendedorApellido.Text = "APELLIDO";
        // 
        // lblVendedorNombre
        // 
        lblVendedorNombre.Location = new Point(17, 24);
        lblVendedorNombre.Name = "lblVendedorNombre";
        lblVendedorNombre.Size = new Size(125, 18);
        lblVendedorNombre.TabIndex = 0;
        lblVendedorNombre.Text = "NOMBRE";
        // 
        // imageList1
        // 
        imageList1.ColorDepth = ColorDepth.Depth32Bit;
        imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
        imageList1.TransparentColor = Color.Transparent;
        imageList1.Images.SetKeyName(0, "Vendedores.ico");
        imageList1.Images.SetKeyName(1, "Clientes.ico");
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(504, 112);
        label1.Name = "label1";
        label1.Size = new Size(38, 15);
        label1.TabIndex = 21;
        label1.Text = "label1";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(422, 134);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(197, 23);
        textBox1.TabIndex = 22;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(19, 331);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(649, 118);
        dataGridView1.TabIndex = 23;
        // 
        // button1
        // 
        button1.Location = new Point(28, 284);
        button1.Name = "button1";
        button1.Size = new Size(112, 29);
        button1.TabIndex = 24;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(284, 284);
        button2.Name = "button2";
        button2.Size = new Size(112, 29);
        button2.TabIndex = 25;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(504, 284);
        button3.Name = "button3";
        button3.Size = new Size(112, 29);
        button3.TabIndex = 26;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(468, 170);
        button4.Name = "button4";
        button4.Size = new Size(112, 29);
        button4.TabIndex = 27;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new Point(45, 298);
        button5.Name = "button5";
        button5.Size = new Size(155, 30);
        button5.TabIndex = 9;
        button5.Text = "button5";
        button5.UseVisualStyleBackColor = true;
        // 
        // button6
        // 
        button6.Location = new Point(283, 298);
        button6.Name = "button6";
        button6.Size = new Size(155, 30);
        button6.TabIndex = 10;
        button6.Text = "button6";
        button6.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        button7.Location = new Point(498, 298);
        button7.Name = "button7";
        button7.Size = new Size(155, 30);
        button7.TabIndex = 11;
        button7.Text = "button7";
        button7.UseVisualStyleBackColor = true;
        // 
        // button8
        // 
        button8.Location = new Point(451, 144);
        button8.Name = "button8";
        button8.Size = new Size(155, 30);
        button8.TabIndex = 12;
        button8.Text = "button8";
        button8.UseVisualStyleBackColor = true;
        // 
        // dataGridView2
        // 
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new Point(11, 330);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.Size = new Size(651, 128);
        dataGridView2.TabIndex = 13;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(507, 57);
        label2.Name = "label2";
        label2.Size = new Size(38, 15);
        label2.TabIndex = 14;
        label2.Text = "label2";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(449, 97);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(157, 23);
        textBox2.TabIndex = 15;
        // 
        // Presentacion
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(679, 516);
        Controls.Add(tabControl1);
        Controls.Add(menuStrip1);
        HelpButton = true;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        Name = "Presentacion";
        StartPosition = FormStartPosition.CenterScreen;
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
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
    private Button button4;
    private Button button3;
    private Button button2;
    private Button button1;
    private DataGridView dataGridView1;
    private TextBox textBox1;
    private Label label1;
    private TextBox textBox2;
    private Label label2;
    private DataGridView dataGridView2;
    private Button button8;
    private Button button7;
    private Button button6;
    private Button button5;
}