namespace ProyectoFinal_Programacion3
{
    partial class FrmPos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.spBusq = new System.Windows.Forms.Panel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblLupa = new System.Windows.Forms.Label();
            this.spDiv = new System.Windows.Forms.Panel();
            this.panelCarrito = new System.Windows.Forms.Panel();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.spTitulo = new System.Windows.Forms.Panel();
            this.lblTituloCarrito = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelPago = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.spPago = new System.Windows.Forms.Panel();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.spCobrar = new System.Windows.Forms.Panel();
            this.btnCobrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            this.panelCarrito.SuspendLayout();
            this.panelTotales.SuspendLayout();
            this.panelPago.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvProductos
            //
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(576, 554);
            this.dgvProductos.TabIndex = 0;
            //
            // spBusq
            //
            this.spBusq.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBusq.Name = "spBusq";
            this.spBusq.Size = new System.Drawing.Size(576, 14);
            this.spBusq.TabIndex = 0;
            //
            // panelBusqueda
            //
            this.panelBusqueda.BackColor = System.Drawing.Color.White;
            this.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Controls.Add(this.lblLupa);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.panelBusqueda.Size = new System.Drawing.Size(576, 44);
            this.panelBusqueda.TabIndex = 1;
            //
            // txtBuscar
            //
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(516, 20);
            this.txtBuscar.TabIndex = 1;
            //
            // lblLupa
            //
            this.lblLupa.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLupa.Image = global::ProyectoFinal_Programacion3.Properties.Resources.icono_buscar;
            this.lblLupa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(30, 18);
            this.lblLupa.TabIndex = 0;
            //
            // spDiv
            //
            this.spDiv.Dock = System.Windows.Forms.DockStyle.Right;
            this.spDiv.Name = "spDiv";
            this.spDiv.Size = new System.Drawing.Size(16, 612);
            this.spDiv.TabIndex = 0;
            //
            // panelCarrito
            //
            this.panelCarrito.BackColor = System.Drawing.Color.White;
            this.panelCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCarrito.Controls.Add(this.dgvCarrito);
            this.panelCarrito.Controls.Add(this.spTitulo);
            this.panelCarrito.Controls.Add(this.lblTituloCarrito);
            this.panelCarrito.Controls.Add(this.btnQuitar);
            this.panelCarrito.Controls.Add(this.panelTotales);
            this.panelCarrito.Controls.Add(this.panelPago);
            this.panelCarrito.Controls.Add(this.spCobrar);
            this.panelCarrito.Controls.Add(this.btnCobrar);
            this.panelCarrito.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCarrito.Name = "panelCarrito";
            this.panelCarrito.Padding = new System.Windows.Forms.Padding(16, 14, 16, 16);
            this.panelCarrito.Size = new System.Drawing.Size(400, 612);
            this.panelCarrito.TabIndex = 2;
            //
            // dgvCarrito
            //
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AllowUserToResizeRows = false;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.MultiSelect = false;
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(366, 200);
            this.dgvCarrito.TabIndex = 2;
            //
            // spTitulo
            //
            this.spTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spTitulo.Name = "spTitulo";
            this.spTitulo.Size = new System.Drawing.Size(366, 8);
            this.spTitulo.TabIndex = 0;
            //
            // lblTituloCarrito
            //
            this.lblTituloCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloCarrito.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTituloCarrito.Name = "lblTituloCarrito";
            this.lblTituloCarrito.Size = new System.Drawing.Size(366, 26);
            this.lblTituloCarrito.TabIndex = 0;
            this.lblTituloCarrito.Text = "Venta actual";
            //
            // btnQuitar
            //
            this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(366, 30);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar producto";
            this.btnQuitar.UseVisualStyleBackColor = true;
            //
            // panelTotales
            //
            this.panelTotales.Controls.Add(this.lblTotal);
            this.panelTotales.Controls.Add(this.lblImpuesto);
            this.panelTotales.Controls.Add(this.lblSubtotal);
            this.panelTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panelTotales.Size = new System.Drawing.Size(366, 88);
            this.panelTotales.TabIndex = 0;
            //
            // lblSubtotal
            //
            this.lblSubtotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(366, 24);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal: RD$0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblImpuesto
            //
            this.lblImpuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImpuesto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(366, 24);
            this.lblImpuesto.TabIndex = 0;
            this.lblImpuesto.Text = "ITBIS: RD$0.00";
            this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblTotal
            //
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(366, 32);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: RD$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // panelPago
            //
            this.panelPago.Controls.Add(this.cboTipoPago);
            this.panelPago.Controls.Add(this.lblTipoPago);
            this.panelPago.Controls.Add(this.spPago);
            this.panelPago.Controls.Add(this.cboCliente);
            this.panelPago.Controls.Add(this.lblCliente);
            this.panelPago.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPago.Name = "panelPago";
            this.panelPago.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panelPago.Size = new System.Drawing.Size(366, 104);
            this.panelPago.TabIndex = 0;
            //
            // lblCliente
            //
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(366, 17);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            //
            // cboCliente
            //
            this.cboCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(366, 25);
            this.cboCliente.TabIndex = 4;
            //
            // spPago
            //
            this.spPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.spPago.Name = "spPago";
            this.spPago.Size = new System.Drawing.Size(366, 8);
            this.spPago.TabIndex = 0;
            //
            // lblTipoPago
            //
            this.lblTipoPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTipoPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(366, 17);
            this.lblTipoPago.TabIndex = 0;
            this.lblTipoPago.Text = "Tipo de pago";
            //
            // cboTipoPago
            //
            this.cboTipoPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTipoPago.Items.AddRange(new object[] {
            "Contado"});
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(366, 25);
            this.cboTipoPago.TabIndex = 5;
            //
            // spCobrar
            //
            this.spCobrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spCobrar.Name = "spCobrar";
            this.spCobrar.Size = new System.Drawing.Size(366, 10);
            this.spCobrar.TabIndex = 0;
            //
            // btnCobrar
            //
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(366, 48);
            this.btnCobrar.TabIndex = 6;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = false;
            //
            // FrmPos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1040, 656);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.spBusq);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.spDiv);
            this.Controls.Add(this.panelCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPos";
            this.Padding = new System.Windows.Forms.Padding(24, 20, 24, 24);
            this.Text = "Punto de venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelCarrito.ResumeLayout(false);
            this.panelTotales.ResumeLayout(false);
            this.panelPago.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel spBusq;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.Panel spDiv;
        private System.Windows.Forms.Panel panelCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Panel spTitulo;
        private System.Windows.Forms.Label lblTituloCarrito;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Panel panelTotales;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Panel spPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Panel spCobrar;
        private System.Windows.Forms.Button btnCobrar;
    }
}
