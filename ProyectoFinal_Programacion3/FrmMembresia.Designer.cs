namespace ProyectoFinal_Programacion3
{
    partial class FrmMembresia
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.spNombre = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.spDescripcion = new System.Windows.Forms.Panel();
            this.lblDuracionDias = new System.Windows.Forms.Label();
            this.txtDuracionDias = new System.Windows.Forms.TextBox();
            this.spDuracionDias = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.spPrecio = new System.Windows.Forms.Panel();
            this.panelCamposDialogo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCamposDialogo
            // 
            this.panelCamposDialogo.AutoScroll = true;
            this.panelCamposDialogo.Controls.Add(this.spPrecio);
            this.panelCamposDialogo.Controls.Add(this.txtPrecio);
            this.panelCamposDialogo.Controls.Add(this.lblPrecio);
            this.panelCamposDialogo.Controls.Add(this.spDuracionDias);
            this.panelCamposDialogo.Controls.Add(this.txtDuracionDias);
            this.panelCamposDialogo.Controls.Add(this.lblDuracionDias);
            this.panelCamposDialogo.Controls.Add(this.spDescripcion);
            this.panelCamposDialogo.Controls.Add(this.txtDescripcion);
            this.panelCamposDialogo.Controls.Add(this.lblDescripcion);
            this.panelCamposDialogo.Controls.Add(this.spNombre);
            this.panelCamposDialogo.Controls.Add(this.txtNombre);
            this.panelCamposDialogo.Controls.Add(this.lblNombre);
            this.panelCamposDialogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamposDialogo.Name = "panelCamposDialogo";
            this.panelCamposDialogo.Size = new System.Drawing.Size(372, 307);
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
            this.btnGuardar.TabIndex = 5;
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
            this.btnCancelar.TabIndex = 6;
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
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Size = new System.Drawing.Size(372, 25);
            this.txtNombre.TabIndex = 1;
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
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Size = new System.Drawing.Size(372, 56);
            this.txtDescripcion.TabIndex = 2;
            // 
            // spDescripcion
            // 
            this.spDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDescripcion.Name = "spDescripcion";
            this.spDescripcion.Size = new System.Drawing.Size(372, 14);
            this.spDescripcion.TabIndex = 0;
            // 
            // lblDuracionDias
            // 
            this.lblDuracionDias.AutoSize = true;
            this.lblDuracionDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDuracionDias.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDuracionDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDuracionDias.Name = "lblDuracionDias";
            this.lblDuracionDias.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblDuracionDias.Size = new System.Drawing.Size(60, 20);
            this.lblDuracionDias.TabIndex = 0;
            this.lblDuracionDias.Text = "Duración (días)";
            // 
            // txtDuracionDias
            // 
            this.txtDuracionDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDuracionDias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDuracionDias.Name = "txtDuracionDias";
            this.txtDuracionDias.MaxLength = 4;
            this.txtDuracionDias.Size = new System.Drawing.Size(372, 25);
            this.txtDuracionDias.TabIndex = 3;
            // 
            // spDuracionDias
            // 
            this.spDuracionDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDuracionDias.Name = "spDuracionDias";
            this.spDuracionDias.Size = new System.Drawing.Size(372, 14);
            this.spDuracionDias.TabIndex = 0;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblPrecio.Size = new System.Drawing.Size(60, 20);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio (RD$)";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Size = new System.Drawing.Size(372, 25);
            this.txtPrecio.TabIndex = 4;
            // 
            // spPrecio
            // 
            this.spPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.spPrecio.Name = "spPrecio";
            this.spPrecio.Size = new System.Drawing.Size(372, 14);
            this.spPrecio.TabIndex = 0;
            // 
            // FrmMembresia
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 483);
            this.Controls.Add(this.panelCamposDialogo);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMembresia";
            this.Padding = new System.Windows.Forms.Padding(24, 12, 24, 18);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Membresía";
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
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel spNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel spDescripcion;
        private System.Windows.Forms.Label lblDuracionDias;
        private System.Windows.Forms.TextBox txtDuracionDias;
        private System.Windows.Forms.Panel spDuracionDias;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Panel spPrecio;
    }
}
