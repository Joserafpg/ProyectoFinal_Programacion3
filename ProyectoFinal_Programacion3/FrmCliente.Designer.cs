namespace ProyectoFinal_Programacion3
{
    partial class FrmCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lineNombre = new System.Windows.Forms.Panel();
            this.spNombre = new System.Windows.Forms.Panel();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lineApellido = new System.Windows.Forms.Panel();
            this.spApellido = new System.Windows.Forms.Panel();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lineCedula = new System.Windows.Forms.Panel();
            this.spCedula = new System.Windows.Forms.Panel();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lineTelefono = new System.Windows.Forms.Panel();
            this.spTelefono = new System.Windows.Forms.Panel();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lineCorreo = new System.Windows.Forms.Panel();
            this.spCorreo = new System.Windows.Forms.Panel();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lineDireccion = new System.Windows.Forms.Panel();
            this.spDireccion = new System.Windows.Forms.Panel();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.spFechaNacimiento = new System.Windows.Forms.Panel();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.spSexo = new System.Windows.Forms.Panel();
            this.lblFoto = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.spFotoFoto = new System.Windows.Forms.Panel();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.spFoto = new System.Windows.Forms.Panel();
            this.panelFondo.SuspendLayout();
            this.panelCamposDialogo.SuspendLayout();
            this.panelTituloDialogo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
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
            this.lblTituloDialogo.Text = "Cliente";
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
            this.panelCamposDialogo.Controls.Add(this.spFoto);
            this.panelCamposDialogo.Controls.Add(this.btnCargarFoto);
            this.panelCamposDialogo.Controls.Add(this.spFotoFoto);
            this.panelCamposDialogo.Controls.Add(this.picFoto);
            this.panelCamposDialogo.Controls.Add(this.lblFoto);
            this.panelCamposDialogo.Controls.Add(this.spSexo);
            this.panelCamposDialogo.Controls.Add(this.cboSexo);
            this.panelCamposDialogo.Controls.Add(this.lblSexo);
            this.panelCamposDialogo.Controls.Add(this.spFechaNacimiento);
            this.panelCamposDialogo.Controls.Add(this.dtpFechaNacimiento);
            this.panelCamposDialogo.Controls.Add(this.lblFechaNacimiento);
            this.panelCamposDialogo.Controls.Add(this.spDireccion);
            this.panelCamposDialogo.Controls.Add(this.lineDireccion);
            this.panelCamposDialogo.Controls.Add(this.txtDireccion);
            this.panelCamposDialogo.Controls.Add(this.lblDireccion);
            this.panelCamposDialogo.Controls.Add(this.spCorreo);
            this.panelCamposDialogo.Controls.Add(this.lineCorreo);
            this.panelCamposDialogo.Controls.Add(this.txtCorreo);
            this.panelCamposDialogo.Controls.Add(this.lblCorreo);
            this.panelCamposDialogo.Controls.Add(this.spTelefono);
            this.panelCamposDialogo.Controls.Add(this.lineTelefono);
            this.panelCamposDialogo.Controls.Add(this.txtTelefono);
            this.panelCamposDialogo.Controls.Add(this.lblTelefono);
            this.panelCamposDialogo.Controls.Add(this.spCedula);
            this.panelCamposDialogo.Controls.Add(this.lineCedula);
            this.panelCamposDialogo.Controls.Add(this.txtCedula);
            this.panelCamposDialogo.Controls.Add(this.lblCedula);
            this.panelCamposDialogo.Controls.Add(this.spApellido);
            this.panelCamposDialogo.Controls.Add(this.lineApellido);
            this.panelCamposDialogo.Controls.Add(this.txtApellido);
            this.panelCamposDialogo.Controls.Add(this.lblApellido);
            this.panelCamposDialogo.Controls.Add(this.spNombre);
            this.panelCamposDialogo.Controls.Add(this.lineNombre);
            this.panelCamposDialogo.Controls.Add(this.txtNombre);
            this.panelCamposDialogo.Controls.Add(this.lblNombre);
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
            this.btnGuardar.TabIndex = 10;
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
            this.btnCancelar.TabIndex = 11;
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
            this.txtNombre.TabIndex = 1;
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
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblApellido.Size = new System.Drawing.Size(60, 21);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(362, 24);
            this.txtApellido.TabIndex = 2;
            // 
            // lineApellido
            // 
            this.lineApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineApellido.Name = "lineApellido";
            this.lineApellido.Size = new System.Drawing.Size(362, 2);
            this.lineApellido.TabIndex = 0;
            // 
            // spApellido
            // 
            this.spApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.spApellido.Name = "spApellido";
            this.spApellido.Size = new System.Drawing.Size(362, 16);
            this.spApellido.TabIndex = 0;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCedula.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCedula.Size = new System.Drawing.Size(60, 21);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cédula";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(362, 24);
            this.txtCedula.TabIndex = 3;
            // 
            // lineCedula
            // 
            this.lineCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineCedula.Name = "lineCedula";
            this.lineCedula.Size = new System.Drawing.Size(362, 2);
            this.lineCedula.TabIndex = 0;
            // 
            // spCedula
            // 
            this.spCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCedula.Name = "spCedula";
            this.spCedula.Size = new System.Drawing.Size(362, 16);
            this.spCedula.TabIndex = 0;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblTelefono.Size = new System.Drawing.Size(60, 21);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(362, 24);
            this.txtTelefono.TabIndex = 4;
            // 
            // lineTelefono
            // 
            this.lineTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineTelefono.Name = "lineTelefono";
            this.lineTelefono.Size = new System.Drawing.Size(362, 2);
            this.lineTelefono.TabIndex = 0;
            // 
            // spTelefono
            // 
            this.spTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.spTelefono.Name = "spTelefono";
            this.spTelefono.Size = new System.Drawing.Size(362, 16);
            this.spTelefono.TabIndex = 0;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCorreo.Size = new System.Drawing.Size(60, 21);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(362, 24);
            this.txtCorreo.TabIndex = 5;
            // 
            // lineCorreo
            // 
            this.lineCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineCorreo.Name = "lineCorreo";
            this.lineCorreo.Size = new System.Drawing.Size(362, 2);
            this.lineCorreo.TabIndex = 0;
            // 
            // spCorreo
            // 
            this.spCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCorreo.Name = "spCorreo";
            this.spCorreo.Size = new System.Drawing.Size(362, 16);
            this.spCorreo.TabIndex = 0;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblDireccion.Size = new System.Drawing.Size(60, 21);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(362, 52);
            this.txtDireccion.TabIndex = 6;
            // 
            // lineDireccion
            // 
            this.lineDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineDireccion.Name = "lineDireccion";
            this.lineDireccion.Size = new System.Drawing.Size(362, 2);
            this.lineDireccion.TabIndex = 0;
            // 
            // spDireccion
            // 
            this.spDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDireccion.Name = "spDireccion";
            this.spDireccion.Size = new System.Drawing.Size(362, 16);
            this.spDireccion.TabIndex = 0;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblFechaNacimiento.Size = new System.Drawing.Size(60, 21);
            this.lblFechaNacimiento.TabIndex = 0;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.ShowCheckBox = true;
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(362, 25);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // spFechaNacimiento
            // 
            this.spFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFechaNacimiento.Name = "spFechaNacimiento";
            this.spFechaNacimiento.Size = new System.Drawing.Size(362, 16);
            this.spFechaNacimiento.TabIndex = 0;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblSexo.Size = new System.Drawing.Size(60, 21);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo";
            // 
            // cboSexo
            // 
            this.cboSexo.BackColor = System.Drawing.Color.White;
            this.cboSexo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.cboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(362, 27);
            this.cboSexo.TabIndex = 8;
            // 
            // spSexo
            // 
            this.spSexo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spSexo.Name = "spSexo";
            this.spSexo.Size = new System.Drawing.Size(362, 16);
            this.spSexo.TabIndex = 0;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFoto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblFoto.Size = new System.Drawing.Size(60, 21);
            this.lblFoto.TabIndex = 0;
            this.lblFoto.Text = "Foto";
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(362, 110);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // spFotoFoto
            // 
            this.spFotoFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFotoFoto.Name = "spFotoFoto";
            this.spFotoFoto.Size = new System.Drawing.Size(362, 8);
            this.spFotoFoto.TabIndex = 0;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnCargarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargarFoto.FlatAppearance.BorderSize = 0;
            this.btnCargarFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btnCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarFoto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCargarFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(362, 32);
            this.btnCargarFoto.TabIndex = 9;
            this.btnCargarFoto.Text = "Seleccionar imagen";
            this.btnCargarFoto.UseVisualStyleBackColor = false;
            // 
            // spFoto
            // 
            this.spFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFoto.Name = "spFoto";
            this.spFoto.Size = new System.Drawing.Size(362, 16);
            this.spFoto.TabIndex = 0;
            // 
            // FrmCliente
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 640);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.panelFondo.ResumeLayout(false);
            this.panelCamposDialogo.ResumeLayout(false);
            this.panelCamposDialogo.PerformLayout();
            this.panelTituloDialogo.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
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
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel lineNombre;
        private System.Windows.Forms.Panel spNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel lineApellido;
        private System.Windows.Forms.Panel spApellido;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Panel lineCedula;
        private System.Windows.Forms.Panel spCedula;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Panel lineTelefono;
        private System.Windows.Forms.Panel spTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel lineCorreo;
        private System.Windows.Forms.Panel spCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel lineDireccion;
        private System.Windows.Forms.Panel spDireccion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Panel spFechaNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Panel spSexo;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Panel spFotoFoto;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Panel spFoto;
    }
}

