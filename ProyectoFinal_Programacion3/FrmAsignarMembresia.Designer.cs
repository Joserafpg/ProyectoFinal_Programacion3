namespace ProyectoFinal_Programacion3
{
    partial class FrmAsignarMembresia
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
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.lblMembresiaActual = new System.Windows.Forms.Label();
            this.spA = new System.Windows.Forms.Panel();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.spB = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblVigencia = new System.Windows.Forms.Label();
            this.spC = new System.Windows.Forms.Panel();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cboMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.spBtn = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblClienteNombre
            //
            this.lblClienteNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClienteNombre.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblClienteNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(372, 26);
            this.lblClienteNombre.TabIndex = 0;
            this.lblClienteNombre.Text = "Cliente";
            //
            // lblMembresiaActual
            //
            this.lblMembresiaActual.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMembresiaActual.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMembresiaActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblMembresiaActual.Name = "lblMembresiaActual";
            this.lblMembresiaActual.Size = new System.Drawing.Size(372, 20);
            this.lblMembresiaActual.TabIndex = 0;
            this.lblMembresiaActual.Text = "Sin membresía";
            //
            // spA
            //
            this.spA.Dock = System.Windows.Forms.DockStyle.Top;
            this.spA.Name = "spA";
            this.spA.Size = new System.Drawing.Size(372, 14);
            this.spA.TabIndex = 0;
            //
            // lblPlan
            //
            this.lblPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(372, 17);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "Plan";
            //
            // cboPlan
            //
            this.cboPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(372, 28);
            this.cboPlan.TabIndex = 1;
            //
            // spB
            //
            this.spB.Dock = System.Windows.Forms.DockStyle.Top;
            this.spB.Name = "spB";
            this.spB.Size = new System.Drawing.Size(372, 12);
            this.spB.TabIndex = 0;
            //
            // lblPrecio
            //
            this.lblPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(372, 24);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio: RD$0.00";
            //
            // lblVigencia
            //
            this.lblVigencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVigencia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVigencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblVigencia.Name = "lblVigencia";
            this.lblVigencia.Size = new System.Drawing.Size(372, 20);
            this.lblVigencia.TabIndex = 0;
            this.lblVigencia.Text = "Vigencia:";
            //
            // spC
            //
            this.spC.Dock = System.Windows.Forms.DockStyle.Top;
            this.spC.Name = "spC";
            this.spC.Size = new System.Drawing.Size(372, 12);
            this.spC.TabIndex = 0;
            //
            // lblMetodo
            //
            this.lblMetodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMetodo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(372, 17);
            this.lblMetodo.TabIndex = 0;
            this.lblMetodo.Text = "Método de pago";
            //
            // cboMetodoPago
            //
            this.cboMetodoPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia"});
            this.cboMetodoPago.Name = "cboMetodoPago";
            this.cboMetodoPago.Size = new System.Drawing.Size(372, 28);
            this.cboMetodoPago.TabIndex = 2;
            //
            // btnCobrar
            //
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(372, 44);
            this.btnCobrar.TabIndex = 3;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            //
            // spBtn
            //
            this.spBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spBtn.Name = "spBtn";
            this.spBtn.Size = new System.Drawing.Size(372, 8);
            this.spBtn.TabIndex = 0;
            //
            // btnCancelar
            //
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(372, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            //
            // FrmAsignarMembresia
            //
            this.AcceptButton = this.btnCobrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 372);
            this.Controls.Add(this.cboMetodoPago);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.spC);
            this.Controls.Add(this.lblVigencia);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.spB);
            this.Controls.Add(this.cboPlan);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.spA);
            this.Controls.Add(this.lblMembresiaActual);
            this.Controls.Add(this.lblClienteNombre);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.spBtn);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAsignarMembresia";
            this.Padding = new System.Windows.Forms.Padding(24, 16, 24, 18);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar membresía";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblMembresiaActual;
        private System.Windows.Forms.Panel spA;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Panel spB;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblVigencia;
        private System.Windows.Forms.Panel spC;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cboMetodoPago;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Panel spBtn;
        private System.Windows.Forms.Button btnCancelar;
    }
}
