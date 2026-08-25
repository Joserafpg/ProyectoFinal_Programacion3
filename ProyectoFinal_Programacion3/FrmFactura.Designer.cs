namespace ProyectoFinal_Programacion3
{
    partial class FrmFactura
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
            this.vistaPrevia = new System.Windows.Forms.PrintPreviewControl();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnSecundario = new System.Windows.Forms.Button();
            this.spSecundario = new System.Windows.Forms.Panel();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.spBotones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            //
            // vistaPrevia
            //
            this.vistaPrevia.AutoZoom = true;
            this.vistaPrevia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.vistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaPrevia.Name = "vistaPrevia";
            this.vistaPrevia.Size = new System.Drawing.Size(868, 742);
            this.vistaPrevia.TabIndex = 0;
            this.vistaPrevia.UseAntiAlias = true;
            //
            // panelBotones
            //
            this.panelBotones.Controls.Add(this.lblEstado);
            this.panelBotones.Controls.Add(this.btnSecundario);
            this.panelBotones.Controls.Add(this.spSecundario);
            this.panelBotones.Controls.Add(this.btnPrincipal);
            this.panelBotones.Controls.Add(this.spBotones);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panelBotones.Size = new System.Drawing.Size(868, 54);
            this.panelBotones.TabIndex = 1;
            //
            // lblEstado
            //
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblEstado.Size = new System.Drawing.Size(338, 42);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstado.AutoEllipsis = true;
            //
            // btnSecundario
            //
            this.btnSecundario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSecundario.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSecundario.Name = "btnSecundario";
            this.btnSecundario.Size = new System.Drawing.Size(180, 42);
            this.btnSecundario.TabIndex = 1;
            this.btnSecundario.Text = "Confirmar sin imprimir";
            this.btnSecundario.UseVisualStyleBackColor = true;
            this.btnSecundario.Visible = false;
            //
            // spSecundario
            //
            this.spSecundario.Dock = System.Windows.Forms.DockStyle.Right;
            this.spSecundario.Name = "spSecundario";
            this.spSecundario.Size = new System.Drawing.Size(10, 42);
            this.spSecundario.TabIndex = 0;
            this.spSecundario.Visible = false;
            //
            // btnPrincipal
            //
            this.btnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(220, 42);
            this.btnPrincipal.TabIndex = 0;
            this.btnPrincipal.Text = "IMPRIMIR";
            this.btnPrincipal.UseVisualStyleBackColor = false;
            //
            // spBotones
            //
            this.spBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.spBotones.Name = "spBotones";
            this.spBotones.Size = new System.Drawing.Size(10, 42);
            this.spBotones.TabIndex = 0;
            //
            // btnCerrar
            //
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 42);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            //
            // FrmFactura
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(900, 828);
            this.Controls.Add(this.vistaPrevia);
            this.Controls.Add(this.panelBotones);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 500);
            this.Name = "FrmFactura";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura";
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewControl vistaPrevia;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnSecundario;
        private System.Windows.Forms.Panel spSecundario;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Panel spBotones;
        private System.Windows.Forms.Button btnCerrar;
    }
}
