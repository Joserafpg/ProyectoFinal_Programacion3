namespace ProyectoFinal_Programacion3
{
    partial class FrmCompras
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
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.spD = new System.Windows.Forms.Panel();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.spMedio = new System.Windows.Forms.Panel();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.spC = new System.Windows.Forms.Panel();
            this.lblCompras = new System.Windows.Forms.Label();
            this.spTop = new System.Windows.Forms.Panel();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.panelDetalle.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            //
            // panelDetalle
            //
            this.panelDetalle.BackColor = System.Drawing.Color.White;
            this.panelDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetalle.Controls.Add(this.dgvDetalle);
            this.panelDetalle.Controls.Add(this.spD);
            this.panelDetalle.Controls.Add(this.lblDetalle);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(32, 471);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Padding = new System.Windows.Forms.Padding(27, 16, 27, 16);
            this.panelDetalle.Size = new System.Drawing.Size(1323, 306);
            this.panelDetalle.TabIndex = 4;
            //
            // dgvDetalle
            //
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.ColumnHeadersHeight = 29;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(27, 54);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(1267, 234);
            this.dgvDetalle.TabIndex = 1;
            //
            // spD
            //
            this.spD.Dock = System.Windows.Forms.DockStyle.Top;
            this.spD.Location = new System.Drawing.Point(27, 44);
            this.spD.Name = "spD";
            this.spD.Size = new System.Drawing.Size(1267, 10);
            this.spD.TabIndex = 0;
            //
            // lblDetalle
            //
            this.lblDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblDetalle.Location = new System.Drawing.Point(27, 16);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(1267, 28);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Text = "Detalle de la compra";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spMedio
            //
            this.spMedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.spMedio.Location = new System.Drawing.Point(32, 456);
            this.spMedio.Name = "spMedio";
            this.spMedio.Size = new System.Drawing.Size(1323, 15);
            this.spMedio.TabIndex = 0;
            //
            // panelCompras
            //
            this.panelCompras.BackColor = System.Drawing.Color.White;
            this.panelCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCompras.Controls.Add(this.dgvCompras);
            this.panelCompras.Controls.Add(this.spC);
            this.panelCompras.Controls.Add(this.lblCompras);
            this.panelCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCompras.Location = new System.Drawing.Point(32, 88);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Padding = new System.Windows.Forms.Padding(27, 16, 27, 16);
            this.panelCompras.Size = new System.Drawing.Size(1323, 368);
            this.panelCompras.TabIndex = 3;
            //
            // dgvCompras
            //
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompras.ColumnHeadersHeight = 29;
            this.dgvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompras.Location = new System.Drawing.Point(27, 54);
            this.dgvCompras.MultiSelect = false;
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(1267, 296);
            this.dgvCompras.TabIndex = 1;
            //
            // spC
            //
            this.spC.Dock = System.Windows.Forms.DockStyle.Top;
            this.spC.Location = new System.Drawing.Point(27, 44);
            this.spC.Name = "spC";
            this.spC.Size = new System.Drawing.Size(1267, 10);
            this.spC.TabIndex = 0;
            //
            // lblCompras
            //
            this.lblCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblCompras.Location = new System.Drawing.Point(27, 16);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(1267, 28);
            this.lblCompras.TabIndex = 0;
            this.lblCompras.Text = "Compras registradas";
            this.lblCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spTop
            //
            this.spTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.spTop.Location = new System.Drawing.Point(32, 73);
            this.spTop.Name = "spTop";
            this.spTop.Size = new System.Drawing.Size(1323, 15);
            this.spTop.TabIndex = 0;
            //
            // panelAcciones
            //
            this.panelAcciones.Controls.Add(this.btnNuevaCompra);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcciones.Location = new System.Drawing.Point(32, 25);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(1323, 48);
            this.panelAcciones.TabIndex = 1;
            //
            // btnNuevaCompra
            //
            this.btnNuevaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnNuevaCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaCompra.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevaCompra.FlatAppearance.BorderSize = 0;
            this.btnNuevaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnNuevaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnNuevaCompra.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(200, 48);
            this.btnNuevaCompra.TabIndex = 0;
            this.btnNuevaCompra.Text = "+  Nueva compra";
            this.btnNuevaCompra.UseVisualStyleBackColor = false;
            //
            // FrmCompras
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1387, 807);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.spMedio);
            this.Controls.Add(this.panelCompras);
            this.Controls.Add(this.spTop);
            this.Controls.Add(this.panelAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompras";
            this.Padding = new System.Windows.Forms.Padding(32, 25, 32, 30);
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.panelDetalle.ResumeLayout(false);
            this.panelCompras.ResumeLayout(false);
            this.panelAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Panel spD;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Panel spMedio;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Panel spC;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Panel spTop;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Button btnNuevaCompra;
    }
}
