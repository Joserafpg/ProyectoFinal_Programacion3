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
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblLupa = new System.Windows.Forms.Label();
            this.spVentas = new System.Windows.Forms.Panel();
            this.btnVerVentas = new System.Windows.Forms.Button();
            this.spDiv = new System.Windows.Forms.Panel();
            this.panelCarrito = new System.Windows.Forms.Panel();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.spTitulo = new System.Windows.Forms.Panel();
            this.lblTituloCarrito = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.panelTotales = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.panelPago = new System.Windows.Forms.Panel();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.spPago = new System.Windows.Forms.Panel();
            this.panelClienteFila = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.spCobrar = new System.Windows.Forms.Panel();
            this.btnCobrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panelBarra.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panelTotales.SuspendLayout();
            this.panelPago.SuspendLayout();
            this.panelClienteFila.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeight = 29;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(32, 96);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(769, 681);
            this.dgvProductos.TabIndex = 0;
            // 
            // spBusq
            // 
            this.spBusq.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBusq.Location = new System.Drawing.Point(32, 79);
            this.spBusq.Margin = new System.Windows.Forms.Padding(4);
            this.spBusq.Name = "spBusq";
            this.spBusq.Size = new System.Drawing.Size(769, 17);
            this.spBusq.TabIndex = 0;
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.panelBusqueda);
            this.panelBarra.Controls.Add(this.spVentas);
            this.panelBarra.Controls.Add(this.btnVerVentas);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(32, 25);
            this.panelBarra.Margin = new System.Windows.Forms.Padding(4);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(769, 54);
            this.panelBarra.TabIndex = 1;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.White;
            this.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Controls.Add(this.lblLupa);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Padding = new System.Windows.Forms.Padding(19, 15, 19, 15);
            this.panelBusqueda.Size = new System.Drawing.Size(540, 54);
            this.panelBusqueda.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtBuscar.Location = new System.Drawing.Point(59, 15);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(460, 24);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblLupa
            // 
            this.lblLupa.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLupa.Image = global::ProyectoFinal_Programacion3.Properties.Resources.icono_buscar;
            this.lblLupa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLupa.Location = new System.Drawing.Point(19, 15);
            this.lblLupa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(40, 22);
            this.lblLupa.TabIndex = 0;
            // 
            // spVentas
            // 
            this.spVentas.Dock = System.Windows.Forms.DockStyle.Right;
            this.spVentas.Location = new System.Drawing.Point(540, 0);
            this.spVentas.Margin = new System.Windows.Forms.Padding(4);
            this.spVentas.Name = "spVentas";
            this.spVentas.Size = new System.Drawing.Size(16, 54);
            this.spVentas.TabIndex = 0;
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVerVentas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnVerVentas.Location = new System.Drawing.Point(556, 0);
            this.btnVerVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Size = new System.Drawing.Size(213, 54);
            this.btnVerVentas.TabIndex = 7;
            this.btnVerVentas.Text = "Ver ventas anteriores";
            this.btnVerVentas.UseVisualStyleBackColor = true;
            // 
            // spDiv
            // 
            this.spDiv.Dock = System.Windows.Forms.DockStyle.Right;
            this.spDiv.Location = new System.Drawing.Point(801, 25);
            this.spDiv.Margin = new System.Windows.Forms.Padding(4);
            this.spDiv.Name = "spDiv";
            this.spDiv.Size = new System.Drawing.Size(21, 752);
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
            this.panelCarrito.Location = new System.Drawing.Point(822, 25);
            this.panelCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.panelCarrito.Name = "panelCarrito";
            this.panelCarrito.Padding = new System.Windows.Forms.Padding(21, 17, 21, 20);
            this.panelCarrito.Size = new System.Drawing.Size(533, 752);
            this.panelCarrito.TabIndex = 2;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.AllowUserToResizeRows = false;
            this.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrito.ColumnHeadersHeight = 29;
            this.dgvCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarrito.Location = new System.Drawing.Point(21, 59);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCarrito.MultiSelect = false;
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(489, 327);
            this.dgvCarrito.TabIndex = 2;
            this.dgvCarrito.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrito_CellDoubleClick);
            // 
            // spTitulo
            // 
            this.spTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.spTitulo.Location = new System.Drawing.Point(21, 49);
            this.spTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.spTitulo.Name = "spTitulo";
            this.spTitulo.Size = new System.Drawing.Size(489, 10);
            this.spTitulo.TabIndex = 0;
            // 
            // lblTituloCarrito
            // 
            this.lblTituloCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloCarrito.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTituloCarrito.Location = new System.Drawing.Point(21, 17);
            this.lblTituloCarrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCarrito.Name = "lblTituloCarrito";
            this.lblTituloCarrito.Size = new System.Drawing.Size(489, 32);
            this.lblTituloCarrito.TabIndex = 0;
            this.lblTituloCarrito.Text = "Venta actual";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuitar.Location = new System.Drawing.Point(21, 386);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(489, 37);
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
            this.panelTotales.Location = new System.Drawing.Point(21, 423);
            this.panelTotales.Margin = new System.Windows.Forms.Padding(4);
            this.panelTotales.Name = "panelTotales";
            this.panelTotales.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelTotales.Size = new System.Drawing.Size(489, 108);
            this.panelTotales.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 70);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(489, 39);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: RD$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblImpuesto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblImpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblImpuesto.Location = new System.Drawing.Point(0, 40);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(489, 30);
            this.lblImpuesto.TabIndex = 0;
            this.lblImpuesto.Text = "ITBIS: RD$0.00";
            this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblSubtotal.Location = new System.Drawing.Point(0, 10);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(489, 30);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal: RD$0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPago
            // 
            this.panelPago.Controls.Add(this.cboTipoPago);
            this.panelPago.Controls.Add(this.lblTipoPago);
            this.panelPago.Controls.Add(this.spPago);
            this.panelPago.Controls.Add(this.panelClienteFila);
            this.panelPago.Controls.Add(this.lblCliente);
            this.panelPago.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPago.Location = new System.Drawing.Point(21, 531);
            this.panelPago.Margin = new System.Windows.Forms.Padding(4);
            this.panelPago.Name = "panelPago";
            this.panelPago.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.panelPago.Size = new System.Drawing.Size(489, 128);
            this.panelPago.TabIndex = 0;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTipoPago.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.cboTipoPago.Location = new System.Drawing.Point(0, 92);
            this.cboTipoPago.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(489, 29);
            this.cboTipoPago.TabIndex = 5;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTipoPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblTipoPago.Location = new System.Drawing.Point(0, 71);
            this.lblTipoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(489, 21);
            this.lblTipoPago.TabIndex = 0;
            this.lblTipoPago.Text = "Tipo de pago";
            // 
            // spPago
            // 
            this.spPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.spPago.Location = new System.Drawing.Point(0, 61);
            this.spPago.Margin = new System.Windows.Forms.Padding(4);
            this.spPago.Name = "spPago";
            this.spPago.Size = new System.Drawing.Size(489, 10);
            this.spPago.TabIndex = 0;
            // 
            // panelClienteFila
            // 
            this.panelClienteFila.Controls.Add(this.txtCliente);
            this.panelClienteFila.Controls.Add(this.btnBuscarCliente);
            this.panelClienteFila.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClienteFila.Location = new System.Drawing.Point(0, 28);
            this.panelClienteFila.Margin = new System.Windows.Forms.Padding(4);
            this.panelClienteFila.Name = "panelClienteFila";
            this.panelClienteFila.Size = new System.Drawing.Size(489, 33);
            this.panelClienteFila.TabIndex = 0;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCliente.Location = new System.Drawing.Point(0, 0);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(389, 29);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TabStop = false;
            this.txtCliente.Text = "Consumidor final";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarCliente.Location = new System.Drawing.Point(389, 0);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(100, 33);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCliente.Location = new System.Drawing.Point(0, 7);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(489, 21);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // spCobrar
            // 
            this.spCobrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spCobrar.Location = new System.Drawing.Point(21, 659);
            this.spCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.spCobrar.Name = "spCobrar";
            this.spCobrar.Size = new System.Drawing.Size(489, 12);
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
            this.btnCobrar.Location = new System.Drawing.Point(21, 671);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(489, 59);
            this.btnCobrar.TabIndex = 6;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = false;
            // 
            // FrmPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1387, 807);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.spBusq);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.spDiv);
            this.Controls.Add(this.panelCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPos";
            this.Padding = new System.Windows.Forms.Padding(32, 25, 32, 30);
            this.Text = "Punto de venta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panelTotales.ResumeLayout(false);
            this.panelPago.ResumeLayout(false);
            this.panelClienteFila.ResumeLayout(false);
            this.panelClienteFila.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel spBusq;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel spVentas;
        private System.Windows.Forms.Button btnVerVentas;
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
        private System.Windows.Forms.Panel panelClienteFila;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Panel spPago;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Panel spCobrar;
        private System.Windows.Forms.Button btnCobrar;
    }
}
