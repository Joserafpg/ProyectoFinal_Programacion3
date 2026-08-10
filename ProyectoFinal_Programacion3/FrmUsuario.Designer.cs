namespace ProyectoFinal_Programacion3
{
    partial class FrmUsuario
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lineNombreUsuario = new System.Windows.Forms.Panel();
            this.spNombreUsuario = new System.Windows.Forms.Panel();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lineNombreCompleto = new System.Windows.Forms.Panel();
            this.spNombreCompleto = new System.Windows.Forms.Panel();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lineCorreo = new System.Windows.Forms.Panel();
            this.spCorreo = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.spRol = new System.Windows.Forms.Panel();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lineClave = new System.Windows.Forms.Panel();
            this.spClave = new System.Windows.Forms.Panel();
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
            this.panelFondo.Size = new System.Drawing.Size(418, 530);
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
            this.lblTituloDialogo.Text = "Usuario";
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
            this.panelCamposDialogo.Controls.Add(this.spClave);
            this.panelCamposDialogo.Controls.Add(this.lineClave);
            this.panelCamposDialogo.Controls.Add(this.txtClave);
            this.panelCamposDialogo.Controls.Add(this.lblClave);
            this.panelCamposDialogo.Controls.Add(this.spRol);
            this.panelCamposDialogo.Controls.Add(this.cboRol);
            this.panelCamposDialogo.Controls.Add(this.lblRol);
            this.panelCamposDialogo.Controls.Add(this.spCorreo);
            this.panelCamposDialogo.Controls.Add(this.lineCorreo);
            this.panelCamposDialogo.Controls.Add(this.txtCorreo);
            this.panelCamposDialogo.Controls.Add(this.lblCorreo);
            this.panelCamposDialogo.Controls.Add(this.spNombreCompleto);
            this.panelCamposDialogo.Controls.Add(this.lineNombreCompleto);
            this.panelCamposDialogo.Controls.Add(this.txtNombreCompleto);
            this.panelCamposDialogo.Controls.Add(this.lblNombreCompleto);
            this.panelCamposDialogo.Controls.Add(this.spNombreUsuario);
            this.panelCamposDialogo.Controls.Add(this.lineNombreUsuario);
            this.panelCamposDialogo.Controls.Add(this.txtNombreUsuario);
            this.panelCamposDialogo.Controls.Add(this.lblNombreUsuario);
            this.panelCamposDialogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamposDialogo.Name = "panelCamposDialogo";
            this.panelCamposDialogo.Padding = new System.Windows.Forms.Padding(28, 10, 28, 10);
            this.panelCamposDialogo.Size = new System.Drawing.Size(418, 351);
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
            this.btnGuardar.TabIndex = 6;
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
            this.btnCancelar.TabIndex = 7;
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
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblNombreUsuario.Size = new System.Drawing.Size(60, 21);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.Color.White;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(362, 24);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // lineNombreUsuario
            // 
            this.lineNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineNombreUsuario.Name = "lineNombreUsuario";
            this.lineNombreUsuario.Size = new System.Drawing.Size(362, 2);
            this.lineNombreUsuario.TabIndex = 0;
            // 
            // spNombreUsuario
            // 
            this.spNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.spNombreUsuario.Name = "spNombreUsuario";
            this.spNombreUsuario.Size = new System.Drawing.Size(362, 16);
            this.spNombreUsuario.TabIndex = 0;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblNombreCompleto.Size = new System.Drawing.Size(60, 21);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombre completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BackColor = System.Drawing.Color.White;
            this.txtNombreCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCompleto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(362, 24);
            this.txtNombreCompleto.TabIndex = 2;
            // 
            // lineNombreCompleto
            // 
            this.lineNombreCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineNombreCompleto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineNombreCompleto.Name = "lineNombreCompleto";
            this.lineNombreCompleto.Size = new System.Drawing.Size(362, 2);
            this.lineNombreCompleto.TabIndex = 0;
            // 
            // spNombreCompleto
            // 
            this.spNombreCompleto.Dock = System.Windows.Forms.DockStyle.Top;
            this.spNombreCompleto.Name = "spNombreCompleto";
            this.spNombreCompleto.Size = new System.Drawing.Size(362, 16);
            this.spNombreCompleto.TabIndex = 0;
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
            this.txtCorreo.TabIndex = 3;
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
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblRol.Name = "lblRol";
            this.lblRol.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblRol.Size = new System.Drawing.Size(60, 21);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Rol";
            // 
            // cboRol
            // 
            this.cboRol.BackColor = System.Drawing.Color.White;
            this.cboRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(362, 27);
            this.cboRol.TabIndex = 4;
            // 
            // spRol
            // 
            this.spRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.spRol.Name = "spRol";
            this.spRol.Size = new System.Drawing.Size(362, 16);
            this.spRol.TabIndex = 0;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblClave.Name = "lblClave";
            this.lblClave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblClave.Size = new System.Drawing.Size(60, 21);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.White;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(362, 24);
            this.txtClave.TabIndex = 5;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lineClave
            // 
            this.lineClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineClave.Name = "lineClave";
            this.lineClave.Size = new System.Drawing.Size(362, 2);
            this.lineClave.TabIndex = 0;
            // 
            // spClave
            // 
            this.spClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.spClave.Name = "spClave";
            this.spClave.Size = new System.Drawing.Size(362, 16);
            this.spClave.TabIndex = 0;
            // 
            // FrmUsuario
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 578);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuario";
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
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Panel lineNombreUsuario;
        private System.Windows.Forms.Panel spNombreUsuario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Panel lineNombreCompleto;
        private System.Windows.Forms.Panel spNombreCompleto;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel lineCorreo;
        private System.Windows.Forms.Panel spCorreo;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Panel spRol;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Panel lineClave;
        private System.Windows.Forms.Panel spClave;
    }
}

