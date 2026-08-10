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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.panelCamposDialogo = new System.Windows.Forms.Panel();
            this.panelTituloDialogo = new System.Windows.Forms.Panel();
            this.lblTituloDialogo = new System.Windows.Forms.Label();
            this.lblCerrarDialogo = new System.Windows.Forms.Label();
            this.lineaAcento = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.spBoton = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.spBoton2 = new System.Windows.Forms.Panel();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lineCodigo = new System.Windows.Forms.Panel();
            this.spCodigo = new System.Windows.Forms.Panel();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lineCodigoBarras = new System.Windows.Forms.Panel();
            this.spCodigoBarras = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lineNombre = new System.Windows.Forms.Panel();
            this.spNombre = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lineDescripcion = new System.Windows.Forms.Panel();
            this.spDescripcion = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.spCategoria = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.spMarca = new System.Windows.Forms.Panel();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.linePrecioCompra = new System.Windows.Forms.Panel();
            this.spPrecioCompra = new System.Windows.Forms.Panel();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.linePrecioVenta = new System.Windows.Forms.Panel();
            this.spPrecioVenta = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lineStock = new System.Windows.Forms.Panel();
            this.spStock = new System.Windows.Forms.Panel();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.lineStockMinimo = new System.Windows.Forms.Panel();
            this.spStockMinimo = new System.Windows.Forms.Panel();
            this.lblImagen = new System.Windows.Forms.Label();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.spFotoImagen = new System.Windows.Forms.Panel();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.spImagen = new System.Windows.Forms.Panel();
            this.panelFondo.SuspendLayout();
            this.panelCamposDialogo.SuspendLayout();
            this.panelTituloDialogo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.Color.White;
            this.panelFondo.Controls.Add(this.panelCamposDialogo);
            this.panelFondo.Controls.Add(this.panelBotones);
            this.panelFondo.Controls.Add(this.panelTituloDialogo);
            this.panelFondo.Controls.Add(this.lineaAcento);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(418, 638);
            this.panelFondo.TabIndex = 0;
            // 
            // lineaAcento
            // 
            this.lineaAcento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.lineaAcento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineaAcento.Name = "lineaAcento";
            this.lineaAcento.Size = new System.Drawing.Size(418, 3);
            this.lineaAcento.TabIndex = 0;
            // 
            // panelTituloDialogo
            // 
            this.panelTituloDialogo.Controls.Add(this.lblTituloDialogo);
            this.panelTituloDialogo.Controls.Add(this.lblCerrarDialogo);
            this.panelTituloDialogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDialogo.Name = "panelTituloDialogo";
            this.panelTituloDialogo.Padding = new System.Windows.Forms.Padding(28, 18, 12, 0);
            this.panelTituloDialogo.Size = new System.Drawing.Size(418, 56);
            this.panelTituloDialogo.TabIndex = 0;
            // 
            // lblTituloDialogo
            // 
            this.lblTituloDialogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloDialogo.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloDialogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTituloDialogo.Name = "lblTituloDialogo";
            this.lblTituloDialogo.Size = new System.Drawing.Size(342, 38);
            this.lblTituloDialogo.TabIndex = 0;
            this.lblTituloDialogo.Text = "Producto";
            // 
            // lblCerrarDialogo
            // 
            this.lblCerrarDialogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrarDialogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCerrarDialogo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCerrarDialogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(140)))));
            this.lblCerrarDialogo.Name = "lblCerrarDialogo";
            this.lblCerrarDialogo.Size = new System.Drawing.Size(36, 38);
            this.lblCerrarDialogo.TabIndex = 0;
            this.lblCerrarDialogo.Text = "✕";
            this.lblCerrarDialogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelCamposDialogo.Controls.Add(this.lineStockMinimo);
            this.panelCamposDialogo.Controls.Add(this.txtStockMinimo);
            this.panelCamposDialogo.Controls.Add(this.lblStockMinimo);
            this.panelCamposDialogo.Controls.Add(this.spStock);
            this.panelCamposDialogo.Controls.Add(this.lineStock);
            this.panelCamposDialogo.Controls.Add(this.txtStock);
            this.panelCamposDialogo.Controls.Add(this.lblStock);
            this.panelCamposDialogo.Controls.Add(this.spPrecioVenta);
            this.panelCamposDialogo.Controls.Add(this.linePrecioVenta);
            this.panelCamposDialogo.Controls.Add(this.txtPrecioVenta);
            this.panelCamposDialogo.Controls.Add(this.lblPrecioVenta);
            this.panelCamposDialogo.Controls.Add(this.spPrecioCompra);
            this.panelCamposDialogo.Controls.Add(this.linePrecioCompra);
            this.panelCamposDialogo.Controls.Add(this.txtPrecioCompra);
            this.panelCamposDialogo.Controls.Add(this.lblPrecioCompra);
            this.panelCamposDialogo.Controls.Add(this.spMarca);
            this.panelCamposDialogo.Controls.Add(this.cboMarca);
            this.panelCamposDialogo.Controls.Add(this.lblMarca);
            this.panelCamposDialogo.Controls.Add(this.spCategoria);
            this.panelCamposDialogo.Controls.Add(this.cboCategoria);
            this.panelCamposDialogo.Controls.Add(this.lblCategoria);
            this.panelCamposDialogo.Controls.Add(this.spDescripcion);
            this.panelCamposDialogo.Controls.Add(this.lineDescripcion);
            this.panelCamposDialogo.Controls.Add(this.txtDescripcion);
            this.panelCamposDialogo.Controls.Add(this.lblDescripcion);
            this.panelCamposDialogo.Controls.Add(this.spNombre);
            this.panelCamposDialogo.Controls.Add(this.lineNombre);
            this.panelCamposDialogo.Controls.Add(this.txtNombre);
            this.panelCamposDialogo.Controls.Add(this.lblNombre);
            this.panelCamposDialogo.Controls.Add(this.spCodigoBarras);
            this.panelCamposDialogo.Controls.Add(this.lineCodigoBarras);
            this.panelCamposDialogo.Controls.Add(this.txtCodigoBarras);
            this.panelCamposDialogo.Controls.Add(this.lblCodigoBarras);
            this.panelCamposDialogo.Controls.Add(this.spCodigo);
            this.panelCamposDialogo.Controls.Add(this.lineCodigo);
            this.panelCamposDialogo.Controls.Add(this.txtCodigo);
            this.panelCamposDialogo.Controls.Add(this.lblCodigo);
            this.panelCamposDialogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamposDialogo.Name = "panelCamposDialogo";
            this.panelCamposDialogo.Padding = new System.Windows.Forms.Padding(28, 10, 28, 10);
            this.panelCamposDialogo.Size = new System.Drawing.Size(418, 459);
            this.panelCamposDialogo.TabIndex = 1;
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
            this.panelBotones.Padding = new System.Windows.Forms.Padding(28, 8, 28, 20);
            this.panelBotones.Size = new System.Drawing.Size(418, 166);
            this.panelBotones.TabIndex = 2;
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
            this.btnGuardar.Size = new System.Drawing.Size(362, 42);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // spBoton
            // 
            this.spBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton.Name = "spBoton";
            this.spBoton.Size = new System.Drawing.Size(362, 10);
            this.spBoton.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(362, 40);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            //
            // spBoton2
            //
            this.spBoton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton2.Name = "spBoton2";
            this.spBoton2.Size = new System.Drawing.Size(362, 8);
            this.spBoton2.TabIndex = 0;
            //
            // btnDesactivar
            //
            this.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.btnDesactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesactivar.FlatAppearance.BorderSize = 0;
            this.btnDesactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDesactivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(362, 38);
            this.btnDesactivar.TabIndex = 0;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCodigo.Size = new System.Drawing.Size(60, 21);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(362, 24);
            this.txtCodigo.TabIndex = 1;
            // 
            // lineCodigo
            // 
            this.lineCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineCodigo.Name = "lineCodigo";
            this.lineCodigo.Size = new System.Drawing.Size(362, 2);
            this.lineCodigo.TabIndex = 0;
            // 
            // spCodigo
            // 
            this.spCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCodigo.Name = "spCodigo";
            this.spCodigo.Size = new System.Drawing.Size(362, 16);
            this.spCodigo.TabIndex = 0;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCodigoBarras.Size = new System.Drawing.Size(60, 21);
            this.lblCodigoBarras.TabIndex = 0;
            this.lblCodigoBarras.Text = "Código de barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.BackColor = System.Drawing.Color.White;
            this.txtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigoBarras.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(362, 24);
            this.txtCodigoBarras.TabIndex = 2;
            // 
            // lineCodigoBarras
            // 
            this.lineCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineCodigoBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineCodigoBarras.Name = "lineCodigoBarras";
            this.lineCodigoBarras.Size = new System.Drawing.Size(362, 2);
            this.lineCodigoBarras.TabIndex = 0;
            // 
            // spCodigoBarras
            // 
            this.spCodigoBarras.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCodigoBarras.Name = "spCodigoBarras";
            this.spCodigoBarras.Size = new System.Drawing.Size(362, 16);
            this.spCodigoBarras.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblNombre.Size = new System.Drawing.Size(60, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(362, 24);
            this.txtNombre.TabIndex = 3;
            // 
            // lineNombre
            // 
            this.lineNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineNombre.Name = "lineNombre";
            this.lineNombre.Size = new System.Drawing.Size(362, 2);
            this.lineNombre.TabIndex = 0;
            // 
            // spNombre
            // 
            this.spNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.spNombre.Name = "spNombre";
            this.spNombre.Size = new System.Drawing.Size(362, 16);
            this.spNombre.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblDescripcion.Size = new System.Drawing.Size(60, 21);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(362, 52);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lineDescripcion
            // 
            this.lineDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineDescripcion.Name = "lineDescripcion";
            this.lineDescripcion.Size = new System.Drawing.Size(362, 2);
            this.lineDescripcion.TabIndex = 0;
            // 
            // spDescripcion
            // 
            this.spDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDescripcion.Name = "spDescripcion";
            this.spDescripcion.Size = new System.Drawing.Size(362, 16);
            this.spDescripcion.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCategoria.Size = new System.Drawing.Size(60, 21);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.White;
            this.cboCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(362, 27);
            this.cboCategoria.TabIndex = 5;
            // 
            // spCategoria
            // 
            this.spCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCategoria.Name = "spCategoria";
            this.spCategoria.Size = new System.Drawing.Size(362, 16);
            this.spCategoria.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblMarca.Size = new System.Drawing.Size(60, 21);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.Color.White;
            this.cboMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(362, 27);
            this.cboMarca.TabIndex = 6;
            // 
            // spMarca
            // 
            this.spMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.spMarca.Name = "spMarca";
            this.spMarca.Size = new System.Drawing.Size(362, 16);
            this.spMarca.TabIndex = 0;
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblPrecioCompra.Size = new System.Drawing.Size(60, 21);
            this.lblPrecioCompra.TabIndex = 0;
            this.lblPrecioCompra.Text = "Precio de compra";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.White;
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(362, 24);
            this.txtPrecioCompra.TabIndex = 7;
            // 
            // linePrecioCompra
            // 
            this.linePrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.linePrecioCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.linePrecioCompra.Name = "linePrecioCompra";
            this.linePrecioCompra.Size = new System.Drawing.Size(362, 2);
            this.linePrecioCompra.TabIndex = 0;
            // 
            // spPrecioCompra
            // 
            this.spPrecioCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.spPrecioCompra.Name = "spPrecioCompra";
            this.spPrecioCompra.Size = new System.Drawing.Size(362, 16);
            this.spPrecioCompra.TabIndex = 0;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblPrecioVenta.Size = new System.Drawing.Size(60, 21);
            this.lblPrecioVenta.TabIndex = 0;
            this.lblPrecioVenta.Text = "Precio de venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.White;
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(362, 24);
            this.txtPrecioVenta.TabIndex = 8;
            // 
            // linePrecioVenta
            // 
            this.linePrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.linePrecioVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.linePrecioVenta.Name = "linePrecioVenta";
            this.linePrecioVenta.Size = new System.Drawing.Size(362, 2);
            this.linePrecioVenta.TabIndex = 0;
            // 
            // spPrecioVenta
            // 
            this.spPrecioVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.spPrecioVenta.Name = "spPrecioVenta";
            this.spPrecioVenta.Size = new System.Drawing.Size(362, 16);
            this.spPrecioVenta.TabIndex = 0;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblStock.Name = "lblStock";
            this.lblStock.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblStock.Size = new System.Drawing.Size(60, 21);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(362, 24);
            this.txtStock.TabIndex = 9;
            // 
            // lineStock
            // 
            this.lineStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineStock.Name = "lineStock";
            this.lineStock.Size = new System.Drawing.Size(362, 2);
            this.lineStock.TabIndex = 0;
            // 
            // spStock
            // 
            this.spStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.spStock.Name = "spStock";
            this.spStock.Size = new System.Drawing.Size(362, 16);
            this.spStock.TabIndex = 0;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStockMinimo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStockMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblStockMinimo.Size = new System.Drawing.Size(60, 21);
            this.lblStockMinimo.TabIndex = 0;
            this.lblStockMinimo.Text = "Stock mínimo";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.BackColor = System.Drawing.Color.White;
            this.txtStockMinimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockMinimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtStockMinimo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtStockMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(362, 24);
            this.txtStockMinimo.TabIndex = 10;
            // 
            // lineStockMinimo
            // 
            this.lineStockMinimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineStockMinimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineStockMinimo.Name = "lineStockMinimo";
            this.lineStockMinimo.Size = new System.Drawing.Size(362, 2);
            this.lineStockMinimo.TabIndex = 0;
            // 
            // spStockMinimo
            // 
            this.spStockMinimo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spStockMinimo.Name = "spStockMinimo";
            this.spStockMinimo.Size = new System.Drawing.Size(362, 16);
            this.spStockMinimo.TabIndex = 0;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImagen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblImagen.Size = new System.Drawing.Size(60, 21);
            this.lblImagen.TabIndex = 0;
            this.lblImagen.Text = "Imagen";
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.picImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(362, 110);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 0;
            this.picImagen.TabStop = false;
            // 
            // spFotoImagen
            // 
            this.spFotoImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFotoImagen.Name = "spFotoImagen";
            this.spFotoImagen.Size = new System.Drawing.Size(362, 8);
            this.spFotoImagen.TabIndex = 0;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarImagen.FlatAppearance.BorderSize = 0;
            this.btnCargarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCargarImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(362, 32);
            this.btnCargarImagen.TabIndex = 11;
            this.btnCargarImagen.Text = "Seleccionar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            // 
            // spImagen
            // 
            this.spImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.spImagen.Name = "spImagen";
            this.spImagen.Size = new System.Drawing.Size(362, 16);
            this.spImagen.TabIndex = 0;
            // 
            // FrmProducto
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 640);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducto";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Producto";
            this.panelFondo.ResumeLayout(false);
            this.panelCamposDialogo.ResumeLayout(false);
            this.panelCamposDialogo.PerformLayout();
            this.panelTituloDialogo.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Panel lineaAcento;
        private System.Windows.Forms.Panel panelTituloDialogo;
        private System.Windows.Forms.Label lblTituloDialogo;
        private System.Windows.Forms.Label lblCerrarDialogo;
        private System.Windows.Forms.Panel panelCamposDialogo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel spBoton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel spBoton2;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Panel lineCodigo;
        private System.Windows.Forms.Panel spCodigo;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Panel lineCodigoBarras;
        private System.Windows.Forms.Panel spCodigoBarras;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel lineNombre;
        private System.Windows.Forms.Panel spNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel lineDescripcion;
        private System.Windows.Forms.Panel spDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Panel spCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Panel spMarca;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Panel linePrecioCompra;
        private System.Windows.Forms.Panel spPrecioCompra;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Panel linePrecioVenta;
        private System.Windows.Forms.Panel spPrecioVenta;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Panel lineStock;
        private System.Windows.Forms.Panel spStock;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Panel lineStockMinimo;
        private System.Windows.Forms.Panel spStockMinimo;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Panel spFotoImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Panel spImagen;
    }
}

