namespace ProyectoFinal_Programacion3
{
    partial class FrmCategoria
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
            this.spDescripcion = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.spNombre = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.spBoton2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.spBoton = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelCamposDialogo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCamposDialogo
            // 
            this.panelCamposDialogo.AutoScroll = true;
            this.panelCamposDialogo.Controls.Add(this.spDescripcion);
            this.panelCamposDialogo.Controls.Add(this.txtDescripcion);
            this.panelCamposDialogo.Controls.Add(this.lblDescripcion);
            this.panelCamposDialogo.Controls.Add(this.spNombre);
            this.panelCamposDialogo.Controls.Add(this.txtNombre);
            this.panelCamposDialogo.Controls.Add(this.lblNombre);
            this.panelCamposDialogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamposDialogo.Location = new System.Drawing.Point(32, 15);
            this.panelCamposDialogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelCamposDialogo.Name = "panelCamposDialogo";
            this.panelCamposDialogo.Size = new System.Drawing.Size(496, 213);
            this.panelCamposDialogo.TabIndex = 0;
            // 
            // spDescripcion
            // 
            this.spDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDescripcion.Location = new System.Drawing.Point(0, 165);
            this.spDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.spDescripcion.Name = "spDescripcion";
            this.spDescripcion.Size = new System.Drawing.Size(496, 17);
            this.spDescripcion.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(0, 97);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.MaxLength = 250;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(496, 68);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDescripcion.Location = new System.Drawing.Point(0, 72);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblDescripcion.Size = new System.Drawing.Size(91, 25);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            // 
            // spNombre
            // 
            this.spNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.spNombre.Location = new System.Drawing.Point(0, 55);
            this.spNombre.Margin = new System.Windows.Forms.Padding(4);
            this.spNombre.Name = "spNombre";
            this.spNombre.Size = new System.Drawing.Size(496, 17);
            this.spNombre.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(0, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(496, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblNombre.Location = new System.Drawing.Point(0, 0);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblNombre.Size = new System.Drawing.Size(68, 25);
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
            this.panelBotones.Location = new System.Drawing.Point(32, 228);
            this.panelBotones.Margin = new System.Windows.Forms.Padding(4);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelBotones.Size = new System.Drawing.Size(496, 180);
            this.panelBotones.TabIndex = 1;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesactivar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDesactivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDesactivar.Location = new System.Drawing.Point(0, 133);
            this.btnDesactivar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(496, 47);
            this.btnDesactivar.TabIndex = 0;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // spBoton2
            // 
            this.spBoton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton2.Location = new System.Drawing.Point(0, 123);
            this.spBoton2.Margin = new System.Windows.Forms.Padding(4);
            this.spBoton2.Name = "spBoton2";
            this.spBoton2.Size = new System.Drawing.Size(496, 10);
            this.spBoton2.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(0, 74);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(496, 49);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // spBoton
            // 
            this.spBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton.Location = new System.Drawing.Point(0, 62);
            this.spBoton.Margin = new System.Windows.Forms.Padding(4);
            this.spBoton.Name = "spBoton";
            this.spBoton.Size = new System.Drawing.Size(496, 12);
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
            this.btnGuardar.Location = new System.Drawing.Point(0, 10);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(496, 52);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmCategoria
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(560, 430);
            this.Controls.Add(this.panelCamposDialogo);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategoria";
            this.Padding = new System.Windows.Forms.Padding(32, 15, 32, 22);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categoría";
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
    }
}

