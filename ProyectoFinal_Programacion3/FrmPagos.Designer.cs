namespace ProyectoFinal_Programacion3
{
    partial class FrmPagos
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
            this.panelCarrito = new System.Windows.Forms.Panel();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.spC2 = new System.Windows.Forms.Panel();
            this.panelCobro = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.panelMet = new System.Windows.Forms.Panel();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.spC3 = new System.Windows.Forms.Panel();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.spC1 = new System.Windows.Forms.Panel();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnQuitarPago = new System.Windows.Forms.Button();
            this.spA1 = new System.Windows.Forms.Panel();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.spT = new System.Windows.Forms.Panel();
            this.lblTituloCarrito = new System.Windows.Forms.Label();
            this.spP = new System.Windows.Forms.Panel();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEstadoCli = new System.Windows.Forms.Label();
            this.spC = new System.Windows.Forms.Panel();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.spH = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panelCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.panelCobro.SuspendLayout();
            this.panelMet.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            //
            // panelCarrito
            //
            this.panelCarrito.BackColor = System.Drawing.Color.White;
            this.panelCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCarrito.Controls.Add(this.dgvCarrito);
            this.panelCarrito.Controls.Add(this.spC2);
            this.panelCarrito.Controls.Add(this.panelCobro);
            this.panelCarrito.Controls.Add(this.spC1);
            this.panelCarrito.Controls.Add(this.panelAcciones);
            this.panelCarrito.Controls.Add(this.spT);
            this.panelCarrito.Controls.Add(this.lblTituloCarrito);
            this.panelCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarrito.Location = new System.Drawing.Point(32, 130);
            this.panelCarrito.Name = "panelCarrito";
            this.panelCarrito.Padding = new System.Windows.Forms.Padding(27, 16, 27, 16);
            this.panelCarrito.Size = new System.Drawing.Size(1323, 647);
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
            this.dgvCarrito.Location = new System.Drawing.Point(27, 116);
            this.dgvCarrito.MultiSelect = false;
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.RowHeadersVisible = false;
            this.dgvCarrito.RowHeadersWidth = 51;
            this.dgvCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito.Size = new System.Drawing.Size(1267, 445);
            this.dgvCarrito.TabIndex = 2;
            //
            // spC2
            //
            this.spC2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spC2.Location = new System.Drawing.Point(27, 561);
            this.spC2.Name = "spC2";
            this.spC2.Size = new System.Drawing.Size(1267, 10);
            this.spC2.TabIndex = 0;
            //
            // panelCobro
            //
            this.panelCobro.Controls.Add(this.lblTotal);
            this.panelCobro.Controls.Add(this.lblMetodo);
            this.panelCobro.Controls.Add(this.panelMet);
            this.panelCobro.Controls.Add(this.spC3);
            this.panelCobro.Controls.Add(this.btnCobrar);
            this.panelCobro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCobro.Location = new System.Drawing.Point(27, 571);
            this.panelCobro.Name = "panelCobro";
            this.panelCobro.Size = new System.Drawing.Size(1267, 58);
            this.panelCobro.TabIndex = 3;
            //
            // lblTotal
            //
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(797, 58);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total: RD$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblMetodo
            //
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMetodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblMetodo.Location = new System.Drawing.Point(797, 0);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblMetodo.Size = new System.Drawing.Size(77, 58);
            this.lblMetodo.TabIndex = 0;
            this.lblMetodo.Text = "Método:";
            this.lblMetodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // panelMet
            //
            this.panelMet.Controls.Add(this.cboMetodo);
            this.panelMet.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMet.Location = new System.Drawing.Point(874, 0);
            this.panelMet.Name = "panelMet";
            this.panelMet.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelMet.Size = new System.Drawing.Size(160, 58);
            this.panelMet.TabIndex = 1;
            //
            // cboMetodo
            //
            this.cboMetodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMetodo.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia"});
            this.cboMetodo.Location = new System.Drawing.Point(0, 15);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(160, 28);
            this.cboMetodo.TabIndex = 0;
            //
            // spC3
            //
            this.spC3.Dock = System.Windows.Forms.DockStyle.Right;
            this.spC3.Location = new System.Drawing.Point(1034, 0);
            this.spC3.Name = "spC3";
            this.spC3.Size = new System.Drawing.Size(13, 58);
            this.spC3.TabIndex = 0;
            //
            // btnCobrar
            //
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnCobrar.Location = new System.Drawing.Point(1047, 0);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(220, 58);
            this.btnCobrar.TabIndex = 2;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            //
            // spC1
            //
            this.spC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spC1.Location = new System.Drawing.Point(27, 108);
            this.spC1.Name = "spC1";
            this.spC1.Size = new System.Drawing.Size(1267, 8);
            this.spC1.TabIndex = 0;
            //
            // panelAcciones
            //
            this.panelAcciones.Controls.Add(this.btnQuitarPago);
            this.panelAcciones.Controls.Add(this.spA1);
            this.panelAcciones.Controls.Add(this.btnAgregarPago);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcciones.Location = new System.Drawing.Point(27, 60);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(1267, 48);
            this.panelAcciones.TabIndex = 1;
            //
            // btnQuitarPago
            //
            this.btnQuitarPago.BackColor = System.Drawing.Color.White;
            this.btnQuitarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarPago.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuitarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.btnQuitarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnQuitarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnQuitarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnQuitarPago.Location = new System.Drawing.Point(213, 0);
            this.btnQuitarPago.Name = "btnQuitarPago";
            this.btnQuitarPago.Size = new System.Drawing.Size(140, 48);
            this.btnQuitarPago.TabIndex = 1;
            this.btnQuitarPago.Text = "Quitar";
            this.btnQuitarPago.UseVisualStyleBackColor = false;
            //
            // spA1
            //
            this.spA1.Dock = System.Windows.Forms.DockStyle.Left;
            this.spA1.Location = new System.Drawing.Point(200, 0);
            this.spA1.Name = "spA1";
            this.spA1.Size = new System.Drawing.Size(13, 48);
            this.spA1.TabIndex = 0;
            //
            // btnAgregarPago
            //
            this.btnAgregarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnAgregarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPago.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarPago.Enabled = false;
            this.btnAgregarPago.FlatAppearance.BorderSize = 0;
            this.btnAgregarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnAgregarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPago.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnAgregarPago.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(200, 48);
            this.btnAgregarPago.TabIndex = 0;
            this.btnAgregarPago.Text = "+  Agregar pago";
            this.btnAgregarPago.UseVisualStyleBackColor = false;
            //
            // spT
            //
            this.spT.Dock = System.Windows.Forms.DockStyle.Top;
            this.spT.Location = new System.Drawing.Point(27, 44);
            this.spT.Name = "spT";
            this.spT.Size = new System.Drawing.Size(1267, 16);
            this.spT.TabIndex = 0;
            //
            // lblTituloCarrito
            //
            this.lblTituloCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloCarrito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloCarrito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTituloCarrito.Location = new System.Drawing.Point(27, 16);
            this.lblTituloCarrito.Name = "lblTituloCarrito";
            this.lblTituloCarrito.Size = new System.Drawing.Size(1267, 28);
            this.lblTituloCarrito.TabIndex = 0;
            this.lblTituloCarrito.Text = "Pagos a realizar";
            this.lblTituloCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spP
            //
            this.spP.Dock = System.Windows.Forms.DockStyle.Top;
            this.spP.Location = new System.Drawing.Point(32, 115);
            this.spP.Name = "spP";
            this.spP.Size = new System.Drawing.Size(1323, 15);
            this.spP.TabIndex = 0;
            //
            // panelCliente
            //
            this.panelCliente.BackColor = System.Drawing.Color.White;
            this.panelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCliente.Controls.Add(this.panelInfo);
            this.panelCliente.Controls.Add(this.spC);
            this.panelCliente.Controls.Add(this.btnBuscarCli);
            this.panelCliente.Controls.Add(this.spH);
            this.panelCliente.Controls.Add(this.btnHistorial);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCliente.Location = new System.Drawing.Point(32, 25);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Padding = new System.Windows.Forms.Padding(27, 16, 27, 16);
            this.panelCliente.Size = new System.Drawing.Size(1323, 90);
            this.panelCliente.TabIndex = 0;
            //
            // panelInfo
            //
            this.panelInfo.Controls.Add(this.lblCliente);
            this.panelInfo.Controls.Add(this.lblEstadoCli);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(243, 16);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(838, 56);
            this.panelInfo.TabIndex = 2;
            //
            // lblCliente
            //
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblCliente.Location = new System.Drawing.Point(0, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(838, 32);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Ningún cliente seleccionado";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblEstadoCli
            //
            this.lblEstadoCli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEstadoCli.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstadoCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblEstadoCli.Location = new System.Drawing.Point(0, 32);
            this.lblEstadoCli.Name = "lblEstadoCli";
            this.lblEstadoCli.Size = new System.Drawing.Size(838, 24);
            this.lblEstadoCli.TabIndex = 1;
            this.lblEstadoCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spC
            //
            this.spC.Dock = System.Windows.Forms.DockStyle.Left;
            this.spC.Location = new System.Drawing.Point(227, 16);
            this.spC.Name = "spC";
            this.spC.Size = new System.Drawing.Size(16, 56);
            this.spC.TabIndex = 0;
            //
            // btnBuscarCli
            //
            this.btnBuscarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnBuscarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCli.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarCli.FlatAppearance.BorderSize = 0;
            this.btnBuscarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCli.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnBuscarCli.Image = global::ProyectoFinal_Programacion3.Properties.Resources.icono_buscar;
            this.btnBuscarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCli.Location = new System.Drawing.Point(27, 16);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBuscarCli.Size = new System.Drawing.Size(200, 56);
            this.btnBuscarCli.TabIndex = 0;
            this.btnBuscarCli.Text = "Buscar cliente";
            this.btnBuscarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCli.UseVisualStyleBackColor = false;
            //
            // spH
            //
            this.spH.Dock = System.Windows.Forms.DockStyle.Right;
            this.spH.Location = new System.Drawing.Point(1081, 16);
            this.spH.Name = "spH";
            this.spH.Size = new System.Drawing.Size(16, 56);
            this.spH.TabIndex = 0;
            //
            // btnHistorial
            //
            this.btnHistorial.BackColor = System.Drawing.Color.White;
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnHistorial.Location = new System.Drawing.Point(1097, 16);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(199, 56);
            this.btnHistorial.TabIndex = 1;
            this.btnHistorial.Text = "Historial de pagos";
            this.btnHistorial.UseVisualStyleBackColor = false;
            //
            // FrmPagos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1387, 807);
            this.Controls.Add(this.panelCarrito);
            this.Controls.Add(this.spP);
            this.Controls.Add(this.panelCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagos";
            this.Padding = new System.Windows.Forms.Padding(32, 25, 32, 30);
            this.Text = "Pagos";
            this.panelCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.panelCobro.ResumeLayout(false);
            this.panelCobro.PerformLayout();
            this.panelMet.ResumeLayout(false);
            this.panelAcciones.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCarrito;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Panel spC2;
        private System.Windows.Forms.Panel panelCobro;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Panel panelMet;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.Panel spC3;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Panel spC1;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Button btnQuitarPago;
        private System.Windows.Forms.Panel spA1;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.Panel spT;
        private System.Windows.Forms.Label lblTituloCarrito;
        private System.Windows.Forms.Panel spP;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEstadoCli;
        private System.Windows.Forms.Panel spC;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Panel spH;
        private System.Windows.Forms.Button btnHistorial;
    }
}
