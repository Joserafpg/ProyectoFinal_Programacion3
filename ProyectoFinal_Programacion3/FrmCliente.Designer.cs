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
            this.spFoto = new System.Windows.Forms.Panel();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.spFotoFoto = new System.Windows.Forms.Panel();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.spSexo = new System.Windows.Forms.Panel();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.spFechaNacimiento = new System.Windows.Forms.Panel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.spDireccion = new System.Windows.Forms.Panel();
            this.lineDireccion = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.spCorreo = new System.Windows.Forms.Panel();
            this.lineCorreo = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.spTelefono = new System.Windows.Forms.Panel();
            this.lineTelefono = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.spCedula = new System.Windows.Forms.Panel();
            this.lineCedula = new System.Windows.Forms.Panel();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.spApellido = new System.Windows.Forms.Panel();
            this.lineApellido = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.spNombre = new System.Windows.Forms.Panel();
            this.lineNombre = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.spBoton2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.spBoton = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelTituloDialogo = new System.Windows.Forms.Panel();
            this.lblTituloDialogo = new System.Windows.Forms.Label();
            this.lblCerrarDialogo = new System.Windows.Forms.Label();
            this.lineaAcento = new System.Windows.Forms.Panel();
            this.panelFondo.SuspendLayout();
            this.panelCamposDialogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.panelTituloDialogo.SuspendLayout();
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
            this.panelFondo.Location = new System.Drawing.Point(1, 1);
            this.panelFondo.Margin = new System.Windows.Forms.Padding(4);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(558, 786);
            this.panelFondo.TabIndex = 0;
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
            this.panelCamposDialogo.Location = new System.Drawing.Point(0, 73);
            this.panelCamposDialogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelCamposDialogo.Name = "panelCamposDialogo";
            this.panelCamposDialogo.Padding = new System.Windows.Forms.Padding(37, 12, 37, 12);
            this.panelCamposDialogo.Size = new System.Drawing.Size(558, 509);
            this.panelCamposDialogo.TabIndex = 1;
            // 
            // spFoto
            // 
            this.spFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFoto.Location = new System.Drawing.Point(37, 847);
            this.spFoto.Margin = new System.Windows.Forms.Padding(4);
            this.spFoto.Name = "spFoto";
            this.spFoto.Size = new System.Drawing.Size(463, 20);
            this.spFoto.TabIndex = 0;
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
            this.btnCargarFoto.Location = new System.Drawing.Point(37, 808);
            this.btnCargarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(463, 39);
            this.btnCargarFoto.TabIndex = 9;
            this.btnCargarFoto.Text = "Seleccionar imagen";
            this.btnCargarFoto.UseVisualStyleBackColor = false;
            // 
            // spFotoFoto
            // 
            this.spFotoFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFotoFoto.Location = new System.Drawing.Point(37, 798);
            this.spFotoFoto.Margin = new System.Windows.Forms.Padding(4);
            this.spFotoFoto.Name = "spFotoFoto";
            this.spFotoFoto.Size = new System.Drawing.Size(463, 10);
            this.spFotoFoto.TabIndex = 0;
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.picFoto.Location = new System.Drawing.Point(37, 663);
            this.picFoto.Margin = new System.Windows.Forms.Padding(4);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(463, 135);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFoto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblFoto.Location = new System.Drawing.Point(37, 637);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblFoto.Size = new System.Drawing.Size(41, 26);
            this.lblFoto.TabIndex = 0;
            this.lblFoto.Text = "Foto";
            // 
            // spSexo
            // 
            this.spSexo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spSexo.Location = new System.Drawing.Point(37, 617);
            this.spSexo.Margin = new System.Windows.Forms.Padding(4);
            this.spSexo.Name = "spSexo";
            this.spSexo.Size = new System.Drawing.Size(463, 20);
            this.spSexo.TabIndex = 0;
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
            this.cboSexo.Location = new System.Drawing.Point(37, 586);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(463, 31);
            this.cboSexo.TabIndex = 8;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblSexo.Location = new System.Drawing.Point(37, 560);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblSexo.Size = new System.Drawing.Size(43, 26);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo";
            // 
            // spFechaNacimiento
            // 
            this.spFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFechaNacimiento.Location = new System.Drawing.Point(37, 540);
            this.spFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.spFechaNacimiento.Name = "spFechaNacimiento";
            this.spFechaNacimiento.Size = new System.Drawing.Size(463, 20);
            this.spFechaNacimiento.TabIndex = 0;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(37, 510);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.ShowCheckBox = true;
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(463, 30);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(37, 484);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblFechaNacimiento.Size = new System.Drawing.Size(152, 26);
            this.lblFechaNacimiento.TabIndex = 0;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // spDireccion
            // 
            this.spDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDireccion.Location = new System.Drawing.Point(37, 464);
            this.spDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.spDireccion.Name = "spDireccion";
            this.spDireccion.Size = new System.Drawing.Size(463, 20);
            this.spDireccion.TabIndex = 0;
            // 
            // lineDireccion
            // 
            this.lineDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineDireccion.Location = new System.Drawing.Point(37, 462);
            this.lineDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.lineDireccion.Name = "lineDireccion";
            this.lineDireccion.Size = new System.Drawing.Size(463, 2);
            this.lineDireccion.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtDireccion.Location = new System.Drawing.Point(37, 398);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(463, 64);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDireccion.Location = new System.Drawing.Point(37, 372);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblDireccion.Size = new System.Drawing.Size(75, 26);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            // 
            // spCorreo
            // 
            this.spCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCorreo.Location = new System.Drawing.Point(37, 352);
            this.spCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.spCorreo.Name = "spCorreo";
            this.spCorreo.Size = new System.Drawing.Size(463, 20);
            this.spCorreo.TabIndex = 0;
            // 
            // lineCorreo
            // 
            this.lineCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineCorreo.Location = new System.Drawing.Point(37, 350);
            this.lineCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.lineCorreo.Name = "lineCorreo";
            this.lineCorreo.Size = new System.Drawing.Size(463, 2);
            this.lineCorreo.TabIndex = 0;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtCorreo.Location = new System.Drawing.Point(37, 326);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(463, 24);
            this.txtCorreo.TabIndex = 5;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCorreo.Location = new System.Drawing.Point(37, 300);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblCorreo.Size = new System.Drawing.Size(58, 26);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo";
            // 
            // spTelefono
            // 
            this.spTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.spTelefono.Location = new System.Drawing.Point(37, 280);
            this.spTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.spTelefono.Name = "spTelefono";
            this.spTelefono.Size = new System.Drawing.Size(463, 20);
            this.spTelefono.TabIndex = 0;
            // 
            // lineTelefono
            // 
            this.lineTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineTelefono.Location = new System.Drawing.Point(37, 278);
            this.lineTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.lineTelefono.Name = "lineTelefono";
            this.lineTelefono.Size = new System.Drawing.Size(463, 2);
            this.lineTelefono.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtTelefono.Location = new System.Drawing.Point(37, 254);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(463, 24);
            this.txtTelefono.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblTelefono.Location = new System.Drawing.Point(37, 228);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTelefono.Size = new System.Drawing.Size(68, 26);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Teléfono";
            // 
            // spCedula
            // 
            this.spCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCedula.Location = new System.Drawing.Point(37, 208);
            this.spCedula.Margin = new System.Windows.Forms.Padding(4);
            this.spCedula.Name = "spCedula";
            this.spCedula.Size = new System.Drawing.Size(463, 20);
            this.spCedula.TabIndex = 0;
            // 
            // lineCedula
            // 
            this.lineCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineCedula.Location = new System.Drawing.Point(37, 206);
            this.lineCedula.Margin = new System.Windows.Forms.Padding(4);
            this.lineCedula.Name = "lineCedula";
            this.lineCedula.Size = new System.Drawing.Size(463, 2);
            this.lineCedula.TabIndex = 0;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtCedula.Location = new System.Drawing.Point(37, 182);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(463, 24);
            this.txtCedula.TabIndex = 3;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCedula.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCedula.Location = new System.Drawing.Point(37, 156);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblCedula.Size = new System.Drawing.Size(58, 26);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cédula";
            // 
            // spApellido
            // 
            this.spApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.spApellido.Location = new System.Drawing.Point(37, 136);
            this.spApellido.Margin = new System.Windows.Forms.Padding(4);
            this.spApellido.Name = "spApellido";
            this.spApellido.Size = new System.Drawing.Size(463, 20);
            this.spApellido.TabIndex = 0;
            // 
            // lineApellido
            // 
            this.lineApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineApellido.Location = new System.Drawing.Point(37, 134);
            this.lineApellido.Margin = new System.Windows.Forms.Padding(4);
            this.lineApellido.Name = "lineApellido";
            this.lineApellido.Size = new System.Drawing.Size(463, 2);
            this.lineApellido.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtApellido.Location = new System.Drawing.Point(37, 110);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(463, 24);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblApellido.Location = new System.Drawing.Point(37, 84);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblApellido.Size = new System.Drawing.Size(67, 26);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // spNombre
            // 
            this.spNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.spNombre.Location = new System.Drawing.Point(37, 64);
            this.spNombre.Margin = new System.Windows.Forms.Padding(4);
            this.spNombre.Name = "spNombre";
            this.spNombre.Size = new System.Drawing.Size(463, 20);
            this.spNombre.TabIndex = 0;
            // 
            // lineNombre
            // 
            this.lineNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineNombre.Location = new System.Drawing.Point(37, 62);
            this.lineNombre.Margin = new System.Windows.Forms.Padding(4);
            this.lineNombre.Name = "lineNombre";
            this.lineNombre.Size = new System.Drawing.Size(463, 2);
            this.lineNombre.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtNombre.Location = new System.Drawing.Point(37, 38);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(463, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblNombre.Location = new System.Drawing.Point(37, 12);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblNombre.Size = new System.Drawing.Size(68, 26);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnDesactivar);
            this.panelBotones.Controls.Add(this.spBoton2);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.spBoton);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 582);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(4);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(37, 10, 37, 25);
            this.panelBotones.Size = new System.Drawing.Size(558, 204);
            this.panelBotones.TabIndex = 2;
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
            this.btnDesactivar.Location = new System.Drawing.Point(37, 133);
            this.btnDesactivar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(484, 47);
            this.btnDesactivar.TabIndex = 0;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            // 
            // spBoton2
            // 
            this.spBoton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton2.Location = new System.Drawing.Point(37, 123);
            this.spBoton2.Margin = new System.Windows.Forms.Padding(4);
            this.spBoton2.Name = "spBoton2";
            this.spBoton2.Size = new System.Drawing.Size(484, 10);
            this.spBoton2.TabIndex = 0;
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
            this.btnCancelar.Location = new System.Drawing.Point(37, 74);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(484, 49);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // spBoton
            // 
            this.spBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton.Location = new System.Drawing.Point(37, 62);
            this.spBoton.Margin = new System.Windows.Forms.Padding(4);
            this.spBoton.Name = "spBoton";
            this.spBoton.Size = new System.Drawing.Size(484, 12);
            this.spBoton.TabIndex = 0;
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
            this.btnGuardar.Location = new System.Drawing.Point(37, 10);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(484, 52);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelTituloDialogo
            // 
            this.panelTituloDialogo.Controls.Add(this.lblTituloDialogo);
            this.panelTituloDialogo.Controls.Add(this.lblCerrarDialogo);
            this.panelTituloDialogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloDialogo.Location = new System.Drawing.Point(0, 4);
            this.panelTituloDialogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTituloDialogo.Name = "panelTituloDialogo";
            this.panelTituloDialogo.Padding = new System.Windows.Forms.Padding(37, 22, 16, 0);
            this.panelTituloDialogo.Size = new System.Drawing.Size(558, 69);
            this.panelTituloDialogo.TabIndex = 0;
            // 
            // lblTituloDialogo
            // 
            this.lblTituloDialogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloDialogo.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloDialogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTituloDialogo.Location = new System.Drawing.Point(37, 22);
            this.lblTituloDialogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDialogo.Name = "lblTituloDialogo";
            this.lblTituloDialogo.Size = new System.Drawing.Size(457, 47);
            this.lblTituloDialogo.TabIndex = 0;
            this.lblTituloDialogo.Text = "Cliente";
            // 
            // lblCerrarDialogo
            // 
            this.lblCerrarDialogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrarDialogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCerrarDialogo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCerrarDialogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(140)))));
            this.lblCerrarDialogo.Location = new System.Drawing.Point(494, 22);
            this.lblCerrarDialogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrarDialogo.Name = "lblCerrarDialogo";
            this.lblCerrarDialogo.Size = new System.Drawing.Size(48, 47);
            this.lblCerrarDialogo.TabIndex = 0;
            this.lblCerrarDialogo.Text = "✕";
            this.lblCerrarDialogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineaAcento
            // 
            this.lineaAcento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.lineaAcento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineaAcento.Location = new System.Drawing.Point(0, 0);
            this.lineaAcento.Margin = new System.Windows.Forms.Padding(4);
            this.lineaAcento.Name = "lineaAcento";
            this.lineaAcento.Size = new System.Drawing.Size(558, 4);
            this.lineaAcento.TabIndex = 0;
            // 
            // FrmCliente
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(560, 788);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCliente";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.panelFondo.ResumeLayout(false);
            this.panelCamposDialogo.ResumeLayout(false);
            this.panelCamposDialogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.panelTituloDialogo.ResumeLayout(false);
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

