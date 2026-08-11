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
            this.panelCamposDialogo = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.spBoton = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.spBoton2 = new System.Windows.Forms.Panel();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.spNombreUsuario = new System.Windows.Forms.Panel();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.spNombreCompleto = new System.Windows.Forms.Panel();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.spCorreo = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.spRol = new System.Windows.Forms.Panel();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.spClave = new System.Windows.Forms.Panel();
            this.panelCamposDialogo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCamposDialogo
            // 
            this.panelCamposDialogo.AutoScroll = true;
            this.panelCamposDialogo.Controls.Add(this.spClave);
            this.panelCamposDialogo.Controls.Add(this.txtClave);
            this.panelCamposDialogo.Controls.Add(this.lblClave);
            this.panelCamposDialogo.Controls.Add(this.spRol);
            this.panelCamposDialogo.Controls.Add(this.cboRol);
            this.panelCamposDialogo.Controls.Add(this.lblRol);
            this.panelCamposDialogo.Controls.Add(this.spCorreo);
            this.panelCamposDialogo.Controls.Add(this.txtCorreo);
            this.panelCamposDialogo.Controls.Add(this.lblCorreo);
            this.panelCamposDialogo.Controls.Add(this.spNombreCompleto);
            this.panelCamposDialogo.Controls.Add(this.txtNombreCompleto);
            this.panelCamposDialogo.Controls.Add(this.lblNombreCompleto);
            this.panelCamposDialogo.Controls.Add(this.spNombreUsuario);
            this.panelCamposDialogo.Controls.Add(this.txtNombreUsuario);
            this.panelCamposDialogo.Controls.Add(this.lblNombreUsuario);
            this.panelCamposDialogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamposDialogo.Name = "panelCamposDialogo";
            this.panelCamposDialogo.Size = new System.Drawing.Size(372, 346);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.Size = new System.Drawing.Size(372, 42);
            this.btnGuardar.TabIndex = 6;
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
            this.btnCancelar.TabIndex = 7;
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
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            this.btnDesactivar.Size = new System.Drawing.Size(372, 38);
            this.btnDesactivar.TabIndex = 0;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblNombreUsuario.Size = new System.Drawing.Size(60, 20);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.MaxLength = 30;
            this.txtNombreUsuario.Size = new System.Drawing.Size(372, 25);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // spNombreUsuario
            // 
            this.spNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.spNombreUsuario.Name = "spNombreUsuario";
            this.spNombreUsuario.Size = new System.Drawing.Size(372, 14);
            this.spNombreUsuario.TabIndex = 0;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblNombreCompleto.Size = new System.Drawing.Size(60, 20);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombre completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.MaxLength = 100;
            this.txtNombreCompleto.Size = new System.Drawing.Size(372, 25);
            this.txtNombreCompleto.TabIndex = 2;
            // 
            // spNombreCompleto
            // 
            this.spNombreCompleto.Dock = System.Windows.Forms.DockStyle.Top;
            this.spNombreCompleto.Name = "spNombreCompleto";
            this.spNombreCompleto.Size = new System.Drawing.Size(372, 14);
            this.spNombreCompleto.TabIndex = 0;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblCorreo.Size = new System.Drawing.Size(60, 20);
            this.lblCorreo.TabIndex = 0;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.MaxLength = 100;
            this.txtCorreo.Size = new System.Drawing.Size(372, 25);
            this.txtCorreo.TabIndex = 3;
            // 
            // spCorreo
            // 
            this.spCorreo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCorreo.Name = "spCorreo";
            this.spCorreo.Size = new System.Drawing.Size(372, 14);
            this.spCorreo.TabIndex = 0;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblRol.Name = "lblRol";
            this.lblRol.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblRol.Size = new System.Drawing.Size(60, 20);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Rol";
            // 
            // cboRol
            // 
            this.cboRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(372, 28);
            this.cboRol.TabIndex = 4;
            // 
            // spRol
            // 
            this.spRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.spRol.Name = "spRol";
            this.spRol.Size = new System.Drawing.Size(372, 14);
            this.spRol.TabIndex = 0;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblClave.Name = "lblClave";
            this.lblClave.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblClave.Size = new System.Drawing.Size(60, 20);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            this.txtClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtClave.Name = "txtClave";
            this.txtClave.MaxLength = 50;
            this.txtClave.Size = new System.Drawing.Size(372, 25);
            this.txtClave.TabIndex = 5;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // spClave
            // 
            this.spClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.spClave.Name = "spClave";
            this.spClave.Size = new System.Drawing.Size(372, 14);
            this.spClave.TabIndex = 0;
            // 
            // FrmUsuario
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 522);
            this.Controls.Add(this.panelCamposDialogo);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            this.Padding = new System.Windows.Forms.Padding(24, 12, 24, 18);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuario";
            this.panelCamposDialogo.ResumeLayout(false);
            this.panelCamposDialogo.PerformLayout();
            this.panelBotones.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Panel spNombreUsuario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Panel spNombreCompleto;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel spCorreo;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Panel spRol;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Panel spClave;
    }
}
