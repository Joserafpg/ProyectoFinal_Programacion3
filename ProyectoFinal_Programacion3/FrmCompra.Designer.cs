namespace ProyectoFinal_Programacion3
{
    partial class FrmCompra
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
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.spCar = new System.Windows.Forms.Panel();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.spMid = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.spProd = new System.Windows.Forms.Panel();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.spDatos = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.spB1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panelBuscar.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvCarrito.Location = new System.Drawing.Point(20, 400);
            this.dgvCarrito.MultiSelect = false;
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(964, 190);
            this.dgvCarrito.TabIndex = 4;
            //
            // spCar
            //
            this.spCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.spCar.Location = new System.Drawing.Point(20, 392);
            this.spCar.Name = "spCar";
            this.spCar.Size = new System.Drawing.Size(964, 8);
            this.spCar.TabIndex = 0;
            //
            // lblCarrito
            //
            this.lblCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCarrito.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblCarrito.Location = new System.Drawing.Point(20, 366);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(964, 26);
            this.lblCarrito.TabIndex = 0;
            this.lblCarrito.Text = "Productos de la compra (puede editar la cantidad y el costo; doble click quita la línea)";
            this.lblCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spMid
            //
            this.spMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.spMid.Location = new System.Drawing.Point(20, 356);
            this.spMid.Name = "spMid";
            this.spMid.Size = new System.Drawing.Size(964, 10);
            this.spMid.TabIndex = 0;
            //
            // dgvProductos
            //
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeight = 29;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProductos.Location = new System.Drawing.Point(20, 176);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(964, 180);
            this.dgvProductos.TabIndex = 3;
            //
            // spProd
            //
            this.spProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.spProd.Location = new System.Drawing.Point(20, 170);
            this.spProd.Name = "spProd";
            this.spProd.Size = new System.Drawing.Size(964, 6);
            this.spProd.TabIndex = 0;
            //
            // panelBuscar
            //
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBuscar.Location = new System.Drawing.Point(20, 136);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(964, 34);
            this.panelBuscar.TabIndex = 2;
            //
            // txtBuscar
            //
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(0, 0);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(964, 30);
            this.txtBuscar.TabIndex = 0;
            //
            // lblProductos
            //
            this.lblProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblProductos.Location = new System.Drawing.Point(20, 110);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(964, 26);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Busque un producto y doble click para agregarlo a la compra";
            this.lblProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spDatos
            //
            this.spDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDatos.Location = new System.Drawing.Point(20, 100);
            this.spDatos.Name = "spDatos";
            this.spDatos.Size = new System.Drawing.Size(964, 10);
            this.spDatos.TabIndex = 0;
            //
            // panelDatos
            //
            this.panelDatos.Controls.Add(this.lblProveedor);
            this.panelDatos.Controls.Add(this.cboProveedor);
            this.panelDatos.Controls.Add(this.lblFactura);
            this.panelDatos.Controls.Add(this.txtFactura);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatos.Location = new System.Drawing.Point(20, 20);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(964, 80);
            this.panelDatos.TabIndex = 1;
            //
            // lblProveedor
            //
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblProveedor.Location = new System.Drawing.Point(0, 8);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(81, 23);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor:";
            //
            // cboProveedor
            //
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboProveedor.Location = new System.Drawing.Point(0, 36);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(460, 28);
            this.cboProveedor.TabIndex = 1;
            //
            // lblFactura
            //
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblFactura.Location = new System.Drawing.Point(500, 8);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(220, 23);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "No. factura del proveedor (opcional):";
            //
            // txtFactura
            //
            this.txtFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFactura.Location = new System.Drawing.Point(500, 36);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(300, 30);
            this.txtFactura.TabIndex = 2;
            //
            // panelBotones
            //
            this.panelBotones.Controls.Add(this.lblTotal);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Controls.Add(this.spB1);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(20, 590);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.panelBotones.Size = new System.Drawing.Size(964, 60);
            this.panelBotones.TabIndex = 5;
            //
            // lblTotal
            //
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 14);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(511, 46);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: RD$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnCerrar
            //
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnCerrar.Location = new System.Drawing.Point(511, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 46);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            //
            // spB1
            //
            this.spB1.Dock = System.Windows.Forms.DockStyle.Right;
            this.spB1.Location = new System.Drawing.Point(651, 14);
            this.spB1.Name = "spB1";
            this.spB1.Size = new System.Drawing.Size(13, 46);
            this.spB1.TabIndex = 0;
            //
            // btnGuardar
            //
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnGuardar.Location = new System.Drawing.Point(664, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(300, 46);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Registrar compra";
            this.btnGuardar.UseVisualStyleBackColor = false;
            //
            // FrmCompra
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1004, 670);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.spCar);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.spMid);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.spProd);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.spDatos);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompra";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Panel spCar;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Panel spMid;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel spProd;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Panel spDatos;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel spB1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
