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
            this.lblDuracionDias = new System.Windows.Forms.Label();
            this.txtDuracionDias = new System.Windows.Forms.TextBox();
            this.lineDuracionDias = new System.Windows.Forms.Panel();
            this.spDuracionDias = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.linePrecio = new System.Windows.Forms.Panel();
            this.spPrecio = new System.Windows.Forms.Panel();
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
            this.panelFondo.Size = new System.Drawing.Size(418, 491);
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
            this.lblTituloDialogo.Text = "Membresía";
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
            this.panelCamposDialogo.Controls.Add(this.spPrecio);
            this.panelCamposDialogo.Controls.Add(this.linePrecio);
            this.panelCamposDialogo.Controls.Add(this.txtPrecio);
            this.panelCamposDialogo.Controls.Add(this.lblPrecio);
            this.panelCamposDialogo.Controls.Add(this.spDuracionDias);
            this.panelCamposDialogo.Controls.Add(this.lineDuracionDias);
            this.panelCamposDialogo.Controls.Add(this.txtDuracionDias);
            this.panelCamposDialogo.Controls.Add(this.lblDuracionDias);
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
            this.panelCamposDialogo.Size = new System.Drawing.Size(418, 312);
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
            this.btnGuardar.TabIndex = 5;
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
            this.btnCancelar.TabIndex = 6;
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
            // lblDuracionDias
            // 
            this.lblDuracionDias.AutoSize = true;
            this.lblDuracionDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDuracionDias.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDuracionDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDuracionDias.Name = "lblDuracionDias";
            this.lblDuracionDias.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblDuracionDias.Size = new System.Drawing.Size(60, 21);
            this.lblDuracionDias.TabIndex = 0;
            this.lblDuracionDias.Text = "Duración (días)";
            // 
            // txtDuracionDias
            // 
            this.txtDuracionDias.BackColor = System.Drawing.Color.White;
            this.txtDuracionDias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuracionDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDuracionDias.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDuracionDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtDuracionDias.Name = "txtDuracionDias";
            this.txtDuracionDias.Size = new System.Drawing.Size(362, 24);
            this.txtDuracionDias.TabIndex = 3;
            // 
            // lineDuracionDias
            // 
            this.lineDuracionDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.lineDuracionDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineDuracionDias.Name = "lineDuracionDias";
            this.lineDuracionDias.Size = new System.Drawing.Size(362, 2);
            this.lineDuracionDias.TabIndex = 0;
            // 
            // spDuracionDias
            // 
            this.spDuracionDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDuracionDias.Name = "spDuracionDias";
            this.spDuracionDias.Size = new System.Drawing.Size(362, 16);
            this.spDuracionDias.TabIndex = 0;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblPrecio.Size = new System.Drawing.Size(60, 21);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio (RD$)";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(362, 24);
            this.txtPrecio.TabIndex = 4;
            // 
            // linePrecio
            // 
            this.linePrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.linePrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.linePrecio.Name = "linePrecio";
            this.linePrecio.Size = new System.Drawing.Size(362, 2);
            this.linePrecio.TabIndex = 0;
            // 
            // spPrecio
            // 
            this.spPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.spPrecio.Name = "spPrecio";
            this.spPrecio.Size = new System.Drawing.Size(362, 16);
            this.spPrecio.TabIndex = 0;
            // 
            // FrmMembresia
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 539);
            this.Controls.Add(this.panelFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMembresia";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Membresía";
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
        private System.Windows.Forms.Label lblDuracionDias;
        private System.Windows.Forms.TextBox txtDuracionDias;
        private System.Windows.Forms.Panel lineDuracionDias;
        private System.Windows.Forms.Panel spDuracionDias;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Panel linePrecio;
        private System.Windows.Forms.Panel spPrecio;
    }
}

