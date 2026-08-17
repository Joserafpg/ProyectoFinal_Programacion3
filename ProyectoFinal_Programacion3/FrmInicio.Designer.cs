namespace ProyectoFinal_Programacion3
{
    partial class FrmInicio
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.spFiltros = new System.Windows.Forms.Panel();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.panelHasta = new System.Windows.Forms.Panel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.panelDesde = new System.Windows.Forms.Panel();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.spF1 = new System.Windows.Forms.Panel();
            this.panelCbo = new System.Windows.Forms.Panel();
            this.cboVer = new System.Windows.Forms.ComboBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.spTarjetas = new System.Windows.Forms.Panel();
            this.panelTarjetas = new System.Windows.Forms.TableLayoutPanel();
            this.cardStock = new System.Windows.Forms.Panel();
            this.lblCantStock = new System.Windows.Forms.Label();
            this.lblCardStock = new System.Windows.Forms.Label();
            this.cardMorosos = new System.Windows.Forms.Panel();
            this.lblCantMorosos = new System.Windows.Forms.Label();
            this.lblCardMorosos = new System.Windows.Forms.Label();
            this.cardMembresias = new System.Windows.Forms.Panel();
            this.lblCantMembresias = new System.Windows.Forms.Label();
            this.lblCardMembresias = new System.Windows.Forms.Label();
            this.cardVentas = new System.Windows.Forms.Panel();
            this.lblCantVentas = new System.Windows.Forms.Label();
            this.lblCardVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.panelHasta.SuspendLayout();
            this.panelDesde.SuspendLayout();
            this.panelCbo.SuspendLayout();
            this.panelTarjetas.SuspendLayout();
            this.cardStock.SuspendLayout();
            this.cardMorosos.SuspendLayout();
            this.cardMembresias.SuspendLayout();
            this.cardVentas.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvDatos
            //
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeight = 29;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(37, 256);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1318, 517);
            this.dgvDatos.TabIndex = 4;
            //
            // spFiltros
            //
            this.spFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFiltros.Location = new System.Drawing.Point(37, 234);
            this.spFiltros.Name = "spFiltros";
            this.spFiltros.Size = new System.Drawing.Size(1318, 22);
            this.spFiltros.TabIndex = 0;
            //
            // panelFiltros
            //
            this.panelFiltros.Controls.Add(this.lblResumen);
            this.panelFiltros.Controls.Add(this.panelHasta);
            this.panelFiltros.Controls.Add(this.lblHasta);
            this.panelFiltros.Controls.Add(this.panelDesde);
            this.panelFiltros.Controls.Add(this.lblDesde);
            this.panelFiltros.Controls.Add(this.spF1);
            this.panelFiltros.Controls.Add(this.panelCbo);
            this.panelFiltros.Controls.Add(this.lblReporte);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(37, 180);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(1318, 54);
            this.panelFiltros.TabIndex = 2;
            //
            // lblResumen
            //
            this.lblResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblResumen.Location = new System.Drawing.Point(786, 0);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(532, 54);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // panelHasta
            //
            this.panelHasta.Controls.Add(this.dtpHasta);
            this.panelHasta.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHasta.Location = new System.Drawing.Point(626, 0);
            this.panelHasta.Name = "panelHasta";
            this.panelHasta.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panelHasta.Size = new System.Drawing.Size(160, 54);
            this.panelHasta.TabIndex = 3;
            //
            // dtpHasta
            //
            this.dtpHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(0, 12);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(160, 30);
            this.dtpHasta.TabIndex = 0;
            //
            // lblHasta
            //
            this.lblHasta.AutoSize = true;
            this.lblHasta.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblHasta.Location = new System.Drawing.Point(560, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Padding = new System.Windows.Forms.Padding(16, 0, 8, 0);
            this.lblHasta.Size = new System.Drawing.Size(66, 54);
            this.lblHasta.TabIndex = 0;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // panelDesde
            //
            this.panelDesde.Controls.Add(this.dtpDesde);
            this.panelDesde.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDesde.Location = new System.Drawing.Point(400, 0);
            this.panelDesde.Name = "panelDesde";
            this.panelDesde.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panelDesde.Size = new System.Drawing.Size(160, 54);
            this.panelDesde.TabIndex = 2;
            //
            // dtpDesde
            //
            this.dtpDesde.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(0, 12);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(160, 30);
            this.dtpDesde.TabIndex = 0;
            //
            // lblDesde
            //
            this.lblDesde.AutoSize = true;
            this.lblDesde.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblDesde.Location = new System.Drawing.Point(342, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblDesde.Size = new System.Drawing.Size(58, 54);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spF1
            //
            this.spF1.Dock = System.Windows.Forms.DockStyle.Left;
            this.spF1.Location = new System.Drawing.Point(322, 0);
            this.spF1.Name = "spF1";
            this.spF1.Size = new System.Drawing.Size(20, 54);
            this.spF1.TabIndex = 0;
            //
            // panelCbo
            //
            this.panelCbo.Controls.Add(this.cboVer);
            this.panelCbo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCbo.Location = new System.Drawing.Point(72, 0);
            this.panelCbo.Name = "panelCbo";
            this.panelCbo.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panelCbo.Size = new System.Drawing.Size(250, 54);
            this.panelCbo.TabIndex = 1;
            //
            // cboVer
            //
            this.cboVer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.cboVer.Items.AddRange(new object[] {
            "Ventas por fecha",
            "Productos bajo stock",
            "Membresías por vencer",
            "Clientes que deben renovar"});
            this.cboVer.Location = new System.Drawing.Point(0, 12);
            this.cboVer.Name = "cboVer";
            this.cboVer.Size = new System.Drawing.Size(250, 28);
            this.cboVer.TabIndex = 0;
            //
            // lblReporte
            //
            this.lblReporte.AutoSize = true;
            this.lblReporte.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblReporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblReporte.Location = new System.Drawing.Point(0, 0);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblReporte.Size = new System.Drawing.Size(72, 54);
            this.lblReporte.TabIndex = 0;
            this.lblReporte.Text = "Reporte:";
            this.lblReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spTarjetas
            //
            this.spTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.spTarjetas.Location = new System.Drawing.Point(37, 158);
            this.spTarjetas.Name = "spTarjetas";
            this.spTarjetas.Size = new System.Drawing.Size(1318, 22);
            this.spTarjetas.TabIndex = 0;
            //
            // panelTarjetas
            //
            this.panelTarjetas.ColumnCount = 4;
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelTarjetas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelTarjetas.Controls.Add(this.cardVentas, 0, 0);
            this.panelTarjetas.Controls.Add(this.cardMembresias, 1, 0);
            this.panelTarjetas.Controls.Add(this.cardMorosos, 2, 0);
            this.panelTarjetas.Controls.Add(this.cardStock, 3, 0);
            this.panelTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTarjetas.RowCount = 1;
            this.panelTarjetas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTarjetas.Location = new System.Drawing.Point(37, 30);
            this.panelTarjetas.Name = "panelTarjetas";
            this.panelTarjetas.Size = new System.Drawing.Size(1318, 128);
            this.panelTarjetas.TabIndex = 0;
            //
            // cardStock
            //
            this.cardStock.BackColor = System.Drawing.Color.White;
            this.cardStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardStock.Controls.Add(this.lblCantStock);
            this.cardStock.Controls.Add(this.lblCardStock);
            this.cardStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardStock.Margin = new System.Windows.Forms.Padding(0);
            this.cardStock.Location = new System.Drawing.Point(1002, 0);
            this.cardStock.Name = "cardStock";
            this.cardStock.Padding = new System.Windows.Forms.Padding(27, 22, 21, 20);
            this.cardStock.Size = new System.Drawing.Size(313, 128);
            this.cardStock.TabIndex = 0;
            //
            // lblCantStock
            //
            this.lblCantStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCantStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblCantStock.Location = new System.Drawing.Point(27, 49);
            this.lblCantStock.Name = "lblCantStock";
            this.lblCantStock.Size = new System.Drawing.Size(263, 49);
            this.lblCantStock.TabIndex = 0;
            this.lblCantStock.Text = "0";
            this.lblCantStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblCardStock
            //
            this.lblCardStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardStock.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblCardStock.Location = new System.Drawing.Point(27, 22);
            this.lblCardStock.Name = "lblCardStock";
            this.lblCardStock.Size = new System.Drawing.Size(263, 27);
            this.lblCardStock.TabIndex = 0;
            this.lblCardStock.Text = "Productos bajo stock";
            //
            // cardMorosos
            //
            this.cardMorosos.BackColor = System.Drawing.Color.White;
            this.cardMorosos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMorosos.Controls.Add(this.lblCantMorosos);
            this.cardMorosos.Controls.Add(this.lblCardMorosos);
            this.cardMorosos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardMorosos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMorosos.Margin = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.cardMorosos.Location = new System.Drawing.Point(668, 0);
            this.cardMorosos.Name = "cardMorosos";
            this.cardMorosos.Padding = new System.Windows.Forms.Padding(27, 22, 21, 20);
            this.cardMorosos.Size = new System.Drawing.Size(313, 128);
            this.cardMorosos.TabIndex = 0;
            //
            // lblCantMorosos
            //
            this.lblCantMorosos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCantMorosos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantMorosos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblCantMorosos.Location = new System.Drawing.Point(27, 49);
            this.lblCantMorosos.Name = "lblCantMorosos";
            this.lblCantMorosos.Size = new System.Drawing.Size(263, 49);
            this.lblCantMorosos.TabIndex = 0;
            this.lblCantMorosos.Text = "0";
            this.lblCantMorosos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblCardMorosos
            //
            this.lblCardMorosos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardMorosos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardMorosos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblCardMorosos.Location = new System.Drawing.Point(27, 22);
            this.lblCardMorosos.Name = "lblCardMorosos";
            this.lblCardMorosos.Size = new System.Drawing.Size(263, 27);
            this.lblCardMorosos.TabIndex = 0;
            this.lblCardMorosos.Text = "Deben renovar";
            //
            // cardMembresias
            //
            this.cardMembresias.BackColor = System.Drawing.Color.White;
            this.cardMembresias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMembresias.Controls.Add(this.lblCantMembresias);
            this.cardMembresias.Controls.Add(this.lblCardMembresias);
            this.cardMembresias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardMembresias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardMembresias.Margin = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.cardMembresias.Location = new System.Drawing.Point(334, 0);
            this.cardMembresias.Name = "cardMembresias";
            this.cardMembresias.Padding = new System.Windows.Forms.Padding(27, 22, 21, 20);
            this.cardMembresias.Size = new System.Drawing.Size(313, 128);
            this.cardMembresias.TabIndex = 0;
            //
            // lblCantMembresias
            //
            this.lblCantMembresias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCantMembresias.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantMembresias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(134)))), ((int)(((byte)(56)))));
            this.lblCantMembresias.Location = new System.Drawing.Point(27, 49);
            this.lblCantMembresias.Name = "lblCantMembresias";
            this.lblCantMembresias.Size = new System.Drawing.Size(263, 49);
            this.lblCantMembresias.TabIndex = 0;
            this.lblCantMembresias.Text = "0";
            this.lblCantMembresias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblCardMembresias
            //
            this.lblCardMembresias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardMembresias.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardMembresias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblCardMembresias.Location = new System.Drawing.Point(27, 22);
            this.lblCardMembresias.Name = "lblCardMembresias";
            this.lblCardMembresias.Size = new System.Drawing.Size(263, 27);
            this.lblCardMembresias.TabIndex = 0;
            this.lblCardMembresias.Text = "Membresías activas";
            //
            // cardVentas
            //
            this.cardVentas.BackColor = System.Drawing.Color.White;
            this.cardVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardVentas.Controls.Add(this.lblCantVentas);
            this.cardVentas.Controls.Add(this.lblCardVentas);
            this.cardVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardVentas.Margin = new System.Windows.Forms.Padding(0, 0, 21, 0);
            this.cardVentas.Location = new System.Drawing.Point(0, 0);
            this.cardVentas.Name = "cardVentas";
            this.cardVentas.Padding = new System.Windows.Forms.Padding(27, 22, 21, 20);
            this.cardVentas.Size = new System.Drawing.Size(313, 128);
            this.cardVentas.TabIndex = 0;
            //
            // lblCantVentas
            //
            this.lblCantVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCantVentas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblCantVentas.Location = new System.Drawing.Point(27, 49);
            this.lblCantVentas.Name = "lblCantVentas";
            this.lblCantVentas.Size = new System.Drawing.Size(263, 49);
            this.lblCantVentas.TabIndex = 0;
            this.lblCantVentas.Text = "RD$0.00";
            this.lblCantVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblCardVentas
            //
            this.lblCardVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardVentas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblCardVentas.Location = new System.Drawing.Point(27, 22);
            this.lblCardVentas.Name = "lblCardVentas";
            this.lblCardVentas.Size = new System.Drawing.Size(263, 27);
            this.lblCardVentas.TabIndex = 0;
            this.lblCardVentas.Text = "Ventas de hoy";
            //
            // FrmInicio
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1387, 807);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.spFiltros);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.spTarjetas);
            this.Controls.Add(this.panelTarjetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Padding = new System.Windows.Forms.Padding(37, 30, 32, 34);
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelHasta.ResumeLayout(false);
            this.panelDesde.ResumeLayout(false);
            this.panelCbo.ResumeLayout(false);
            this.panelTarjetas.ResumeLayout(false);
            this.cardStock.ResumeLayout(false);
            this.cardMorosos.ResumeLayout(false);
            this.cardMembresias.ResumeLayout(false);
            this.cardVentas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel spFiltros;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Panel panelHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Panel panelDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Panel spF1;
        private System.Windows.Forms.Panel panelCbo;
        private System.Windows.Forms.ComboBox cboVer;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.Panel spTarjetas;
        private System.Windows.Forms.TableLayoutPanel panelTarjetas;
        private System.Windows.Forms.Panel cardStock;
        private System.Windows.Forms.Label lblCantStock;
        private System.Windows.Forms.Label lblCardStock;
        private System.Windows.Forms.Panel cardMorosos;
        private System.Windows.Forms.Label lblCantMorosos;
        private System.Windows.Forms.Label lblCardMorosos;
        private System.Windows.Forms.Panel cardMembresias;
        private System.Windows.Forms.Label lblCantMembresias;
        private System.Windows.Forms.Label lblCardMembresias;
        private System.Windows.Forms.Panel cardVentas;
        private System.Windows.Forms.Label lblCantVentas;
        private System.Windows.Forms.Label lblCardVentas;
    }
}
