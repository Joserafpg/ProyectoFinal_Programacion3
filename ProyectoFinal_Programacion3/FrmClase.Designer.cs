namespace ProyectoFinal_Programacion3
{
    partial class FrmClase
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lineDescripcion = new System.Windows.Forms.Panel();
            this.spDescripcion = new System.Windows.Forms.Panel();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.spDiaSemana = new System.Windows.Forms.Panel();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.spHoraInicio = new System.Windows.Forms.Panel();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.spHoraFin = new System.Windows.Forms.Panel();
            this.lblCupoMaximo = new System.Windows.Forms.Label();
            this.txtCupoMaximo = new System.Windows.Forms.TextBox();
            this.lineCupoMaximo = new System.Windows.Forms.Panel();
            this.spCupoMaximo = new System.Windows.Forms.Panel();
            this.lblEntrenador = new System.Windows.Forms.Label();
            this.cboEntrenador = new System.Windows.Forms.ComboBox();
            this.spEntrenador = new System.Windows.Forms.Panel();
            this.panelFondo.SuspendLayout();
            this.panelCamposDialogo.SuspendLayout();
            this.panelTituloDialogo.SuspendLayout();
            this.panelBotones.SuspendLayout();
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
            this.lblTituloDialogo.Text = "Clase";
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
            this.panelCamposDialogo.Controls.Add(this.spEntrenador);
            this.panelCamposDialogo.Controls.Add(this.cboEntrenador);
            this.panelCamposDialogo.Controls.Add(this.lblEntrenador);
            this.panelCamposDialogo.Controls.Add(this.spCupoMaximo);
            this.panelCamposDialogo.Controls.Add(this.lineCupoMaximo);
            this.panelCamposDialogo.Controls.Add(this.txtCupoMaximo);
            this.panelCamposDialogo.Controls.Add(this.lblCupoMaximo);
            this.panelCamposDialogo.Controls.Add(this.spHoraFin);
            this.panelCamposDialogo.Controls.Add(this.dtpHoraFin);
            this.panelCamposDialogo.Controls.Add(this.lblHoraFin);
            this.panelCamposDialogo.Controls.Add(this.spHoraInicio);
            this.panelCamposDialogo.Controls.Add(this.dtpHoraInicio);
            this.panelCamposDialogo.Controls.Add(this.lblHoraInicio);
            this.panelCamposDialogo.Controls.Add(this.spDiaSemana);
            this.panelCamposDialogo.Controls.Add(this.cboDiaSemana);
            this.panelCamposDialogo.Controls.Add(this.lblDiaSemana);
            this.panelCamposDialogo.Controls.Add(this.spDescripcion);
            this.panelCamposDialogo.Controls.Add(this.lineDescripcion);
            this.panelCamposDialogo.Controls.Add(this.txtDescripcion);
            this.panelCamposDialogo.Controls.Add(this.lblDescripcion);
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
            this.btnGuardar.TabIndex = 8;
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
            this.btnCancelar.TabIndex = 9;
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
            this.txtDescripcion.TabIndex = 2;
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
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiaSemana.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiaSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblDiaSemana.Size = new System.Drawing.Size(60, 21);
            this.lblDiaSemana.TabIndex = 0;
            this.lblDiaSemana.Text = "Día de la semana";
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.BackColor = System.Drawing.Color.White;
            this.cboDiaSemana.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiaSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDiaSemana.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDiaSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.cboDiaSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(362, 27);
            this.cboDiaSemana.TabIndex = 3;
            // 
            // spDiaSemana
            // 
            this.spDiaSemana.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDiaSemana.Name = "spDiaSemana";
            this.spDiaSemana.Size = new System.Drawing.Size(362, 16);
            this.spDiaSemana.TabIndex = 0;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoraInicio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHoraInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblHoraInicio.Size = new System.Drawing.Size(60, 21);
            this.lblHoraInicio.TabIndex = 0;
            this.lblHoraInicio.Text = "Hora de inicio";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpHoraInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(362, 25);
            this.dtpHoraInicio.TabIndex = 4;
            // 
            // spHoraInicio
            // 
            this.spHoraInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.spHoraInicio.Name = "spHoraInicio";
            this.spHoraInicio.Size = new System.Drawing.Size(362, 16);
            this.spHoraInicio.TabIndex = 0;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoraFin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHoraFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblHoraFin.Size = new System.Drawing.Size(60, 21);
            this.lblHoraFin.TabIndex = 0;
            this.lblHoraFin.Text = "Hora de fin";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpHoraFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(362, 25);
            this.dtpHoraFin.TabIndex = 5;
            // 
            // spHoraFin
            // 
            this.spHoraFin.Dock = System.Windows.Forms.DockStyle.Top;
            this.spHoraFin.Name = "spHoraFin";
            this.spHoraFin.Size = new System.Drawing.Size(362, 16);
            this.spHoraFin.TabIndex = 0;
            // 
            // lblCupoMaximo
            // 
            this.lblCupoMaximo.AutoSize = true;
            this.lblCupoMaximo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCupoMaximo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCupoMaximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCupoMaximo.Name = "lblCupoMaximo";
            this.lblCupoMaximo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblCupoMaximo.Size = new System.Drawing.Size(60, 21);
            this.lblCupoMaximo.TabIndex = 0;
            this.lblCupoMaximo.Text = "Cupo máximo";
            // 
            // txtCupoMaximo
            // 
            this.txtCupoMaximo.BackColor = System.Drawing.Color.White;
            this.txtCupoMaximo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCupoMaximo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCupoMaximo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCupoMaximo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtCupoMaximo.Name = "txtCupoMaximo";
            this.txtCupoMaximo.Size = new System.Drawing.Size(362, 24);
            this.txtCupoMaximo.TabIndex = 6;
            // 
            // lineCupoMaximo
            // 
            this.lineCupoMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineCupoMaximo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineCupoMaximo.Name = "lineCupoMaximo";
            this.lineCupoMaximo.Size = new System.Drawing.Size(362, 2);
            this.lineCupoMaximo.TabIndex = 0;
            // 
            // spCupoMaximo
            // 
            this.spCupoMaximo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCupoMaximo.Name = "spCupoMaximo";
            this.spCupoMaximo.Size = new System.Drawing.Size(362, 16);
            this.spCupoMaximo.TabIndex = 0;
            // 
            // lblEntrenador
            // 
            this.lblEntrenador.AutoSize = true;
            this.lblEntrenador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEntrenador.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEntrenador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblEntrenador.Name = "lblEntrenador";
            this.lblEntrenador.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblEntrenador.Size = new System.Drawing.Size(60, 21);
            this.lblEntrenador.TabIndex = 0;
            this.lblEntrenador.Text = "Entrenador";
            // 
            // cboEntrenador
            // 
            this.cboEntrenador.BackColor = System.Drawing.Color.White;
            this.cboEntrenador.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboEntrenador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEntrenador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEntrenador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.cboEntrenador.Name = "cboEntrenador";
            this.cboEntrenador.Size = new System.Drawing.Size(362, 27);
            this.cboEntrenador.TabIndex = 7;
            // 
            // spEntrenador
            // 
            this.spEntrenador.Dock = System.Windows.Forms.DockStyle.Top;
            this.spEntrenador.Name = "spEntrenador";
            this.spEntrenador.Size = new System.Drawing.Size(362, 16);
            this.spEntrenador.TabIndex = 0;
            // 
            // FrmClase
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 640);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClase";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clase";
            this.panelFondo.ResumeLayout(false);
            this.panelCamposDialogo.ResumeLayout(false);
            this.panelCamposDialogo.PerformLayout();
            this.panelTituloDialogo.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel lineDescripcion;
        private System.Windows.Forms.Panel spDescripcion;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.ComboBox cboDiaSemana;
        private System.Windows.Forms.Panel spDiaSemana;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Panel spHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Panel spHoraFin;
        private System.Windows.Forms.Label lblCupoMaximo;
        private System.Windows.Forms.TextBox txtCupoMaximo;
        private System.Windows.Forms.Panel lineCupoMaximo;
        private System.Windows.Forms.Panel spCupoMaximo;
        private System.Windows.Forms.Label lblEntrenador;
        private System.Windows.Forms.ComboBox cboEntrenador;
        private System.Windows.Forms.Panel spEntrenador;
    }
}

