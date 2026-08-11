namespace ProyectoFinal_Programacion3
{
    partial class FrmProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelCamposDialogo = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.spBoton = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.spBoton2 = new System.Windows.Forms.Panel();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.spCodigo = new System.Windows.Forms.Panel();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.spCodigoBarras = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.spNombre = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.spDescripcion = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.spCategoria = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.spMarca = new System.Windows.Forms.Panel();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.spPrecioCompra = new System.Windows.Forms.Panel();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.spPrecioVenta = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.spStock = new System.Windows.Forms.Panel();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.spStockMinimo = new System.Windows.Forms.Panel();
            this.lblImagen = new System.Windows.Forms.Label();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.spFotoImagen = new System.Windows.Forms.Panel();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.spImagen = new System.Windows.Forms.Panel();
            this.panelCamposDialogo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCamposDialogo
            // 
            this.panelCamposDialogo.AutoScroll = true;
            this.panelCamposDialogo.Controls.Add(this.spImagen);
            this.panelCamposDialogo.Controls.Add(this.btnCargarImagen);
            this.panelCamposDialogo.Controls.Add(this.spFotoImagen);
            this.panelCamposDialogo.Controls.Add(this.picImagen);
            this.panelCamposDialogo.Controls.Add(this.lblImagen);
            this.panelCamposDialogo.Controls.Add(this.spStockMinimo);
            this.panelCamposDialogo.Controls.Add(this.txtStockMinimo);
            this.panelCamposDialogo.Controls.Add(this.lblStockMinimo);
            this.panelCamposDialogo.Controls.Add(this.spStock);
            this.panelCamposDialogo.Controls.Add(this.txtStock);
            this.panelCamposDialogo.Controls.Add(this.lblStock);
            this.panelCamposDialogo.Controls.Add(this.spPrecioVenta);
            this.panelCamposDialogo.Controls.Add(this.txtPrecioVenta);
            this.panelCamposDialogo.Controls.Add(this.lblPrecioVenta);
            this.panelCamposDialogo.Controls.Add(this.spPrecioCompra);
            this.panelCamposDialogo.Controls.Add(this.txtPrecioCompra);
            this.panelCamposDialogo.Controls.Add(this.lblPrecioCompra);
            this.panelCamposDialogo.Controls.Add(this.spMarca);
            this.panelCamposDialogo.Controls.Add(this.cboMarca);
            this.panelCamposDialogo.Controls.Add(this.lblMarca);
            this.panelCamposDialogo.Controls.Add(this.spCategoria);
            this.panelCamposDialogo.Controls.Add(this.cboCategoria);
            this.panelCamposDialogo.Controls.Add(this.lblCategoria);
            this.panelCamposDialogo.Controls.Add(this.spDescripcion);
            this.panelCamposDialogo.Controls.Add(this.txtDescripcion);
            this.panelCamposDialogo.Controls.Add(this.lblDescripcion);
            this.panelCamposDialogo.Controls.Add(this.spNombre);
            this.panelCamposDialogo.Controls.Add(this.txtNombre);
            this.panelCamposDialogo.Controls.Add(this.lblNombre);
            this.panelCamposDialogo.Controls.Add(this.spCodigoBarras);
            this.panelCamposDialogo.Controls.Add(this.txtCodigoBarras);
            this.panelCamposDialogo.Controls.Add(this.lblCodigoBarras);
            this.panelCamposDialogo.Controls.Add(this.spCodigo);
            this.panelCamposDialogo.Controls.Add(this.txtCodigo);
            this.panelCamposDialogo.Controls.Add(this.lblCodigo);
            this.panelCamposDialogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamposDialogo.Name = "panelCamposDialogo";
            this.panelCamposDialogo.Size = new System.Drawing.Size(372, 464);
            this.panelCamposDialogo.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnDesactivar);
            this.panelBotones.Controls.Add(this.spBoton2);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.spBoton);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panelBotones.Size = new System.Drawing.Size(372, 146);
            this.panelBotones.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(372, 42);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // spBoton
            // 
            this.spBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton.Name = "spBoton";
            this.spBoton.Size = new System.Drawing.Size(372, 10);
            this.spBoton.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(372, 40);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // spBoton2
            // 
            this.spBoton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton2.Name = "spBoton2";
            this.spBoton2.Size = new System.Drawing.Size(372, 8);
            this.spBoton2.TabIndex = 0;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesactivar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDesactivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(372, 38);
            this.btnDesactivar.TabIndex = 0;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblCodigo.Size = new System.Drawing.Size(60, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(372, 25);
            this.txtCodigo.TabIndex = 1;
            // 
            // spCodigo
            // 
            this.spCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCodigo.Name = "spCodigo";
            this.spCodigo.Size = new System.Drawing.Size(372, 14);
            this.spCodigo.TabIndex = 0;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblCodigoBarras.Size = new System.Drawing.Size(60, 20);
            this.lblCodigoBarras.TabIndex = 0;
            this.lblCodigoBarras.Text = "Código de barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(372, 25);
            this.txtCodigoBarras.TabIndex = 2;
            // 
            // spCodigoBarras
            // 
            this.spCodigoBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCodigoBarras.Name = "spCodigoBarras";
            this.spCodigoBarras.Size = new System.Drawing.Size(372, 14);
            this.spCodigoBarras.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblNombre.Size = new System.Drawing.Size(60, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 25);
            this.txtNombre.TabIndex = 3;
            // 
            // spNombre
            // 
            this.spNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.spNombre.Name = "spNombre";
            this.spNombre.Size = new System.Drawing.Size(372, 14);
            this.spNombre.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblDescripcion.Size = new System.Drawing.Size(60, 20);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(372, 56);
            this.txtDescripcion.TabIndex = 4;
            // 
            // spDescripcion
            // 
            this.spDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDescripcion.Name = "spDescripcion";
            this.spDescripcion.Size = new System.Drawing.Size(372, 14);
            this.spDescripcion.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblCategoria.Size = new System.Drawing.Size(60, 20);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            this.cboCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(372, 28);
            this.cboCategoria.TabIndex = 5;
            // 
            // spCategoria
            // 
            this.spCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCategoria.Name = "spCategoria";
            this.spCategoria.Size = new System.Drawing.Size(372, 14);
            this.spCategoria.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblMarca.Size = new System.Drawing.Size(60, 20);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(372, 28);
            this.cboMarca.TabIndex = 6;
            // 
            // spMarca
            // 
            this.spMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.spMarca.Name = "spMarca";
            this.spMarca.Size = new System.Drawing.Size(372, 14);
            this.spMarca.TabIndex = 0;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblPrecioCompra.Size = new System.Drawing.Size(60, 20);
            this.lblPrecioCompra.TabIndex = 0;
            this.lblPrecioCompra.Text = "Precio de compra";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(372, 25);
            this.txtPrecioCompra.TabIndex = 7;
            // 
            // spPrecioCompra
            // 
            this.spPrecioCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.spPrecioCompra.Name = "spPrecioCompra";
            this.spPrecioCompra.Size = new System.Drawing.Size(372, 14);
            this.spPrecioCompra.TabIndex = 0;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblPrecioVenta.Size = new System.Drawing.Size(60, 20);
            this.lblPrecioVenta.TabIndex = 0;
            this.lblPrecioVenta.Text = "Precio de venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(372, 25);
            this.txtPrecioVenta.TabIndex = 8;
            // 
            // spPrecioVenta
            // 
            this.spPrecioVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.spPrecioVenta.Name = "spPrecioVenta";
            this.spPrecioVenta.Size = new System.Drawing.Size(372, 14);
            this.spPrecioVenta.TabIndex = 0;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblStock.Name = "lblStock";
            this.lblStock.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblStock.Size = new System.Drawing.Size(60, 20);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(372, 25);
            this.txtStock.TabIndex = 9;
            // 
            // spStock
            // 
            this.spStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.spStock.Name = "spStock";
            this.spStock.Size = new System.Drawing.Size(372, 14);
            this.spStock.TabIndex = 0;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStockMinimo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStockMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblStockMinimo.Size = new System.Drawing.Size(60, 20);
            this.lblStockMinimo.TabIndex = 0;
            this.lblStockMinimo.Text = "Stock mínimo";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStockMinimo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(372, 25);
            this.txtStockMinimo.TabIndex = 10;
            // 
            // spStockMinimo
            // 
            this.spStockMinimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spStockMinimo.Name = "spStockMinimo";
            this.spStockMinimo.Size = new System.Drawing.Size(372, 14);
            this.spStockMinimo.TabIndex = 0;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImagen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblImagen.Size = new System.Drawing.Size(60, 20);
            this.lblImagen.TabIndex = 0;
            this.lblImagen.Text = "Imagen";
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.White;
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(372, 110);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 0;
            this.picImagen.TabStop = false;
            // 
            // spFotoImagen
            // 
            this.spFotoImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFotoImagen.Name = "spFotoImagen";
            this.spFotoImagen.Size = new System.Drawing.Size(372, 8);
            this.spFotoImagen.TabIndex = 0;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarImagen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(372, 30);
            this.btnCargarImagen.TabIndex = 11;
            this.btnCargarImagen.Text = "Seleccionar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            // 
            // spImagen
            // 
            this.spImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.spImagen.Name = "spImagen";
            this.spImagen.Size = new System.Drawing.Size(372, 14);
            this.spImagen.TabIndex = 0;
            // 
            // FrmProducto
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 640);
            this.Controls.Add(this.panelCamposDialogo);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProducto";
            this.Padding = new System.Windows.Forms.Padding(24, 12, 24, 18);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Producto";
            this.panelCamposDialogo.ResumeLayout(false);
            this.panelCamposDialogo.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCamposDialogo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel spBoton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel spBoton2;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel spCodigo;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Panel spCodigoBarras;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel spNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel spDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Panel spCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Panel spMarca;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Panel spPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Panel spPrecioVenta;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Panel spStock;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Panel spStockMinimo;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Panel spFotoImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Panel spImagen;
    }
}

