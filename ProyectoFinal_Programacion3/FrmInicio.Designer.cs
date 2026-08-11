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
            this.cboVer = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblLupa = new System.Windows.Forms.Label();
            this.spTarjetas = new System.Windows.Forms.Panel();
            this.panelTarjetas = new System.Windows.Forms.Panel();
            this.cardClientes = new System.Windows.Forms.Panel();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.lblCardClientes = new System.Windows.Forms.Label();
            this.spT1 = new System.Windows.Forms.Panel();
            this.cardMembresias = new System.Windows.Forms.Panel();
            this.lblCantMembresias = new System.Windows.Forms.Label();
            this.lblCardMembresias = new System.Windows.Forms.Label();
            this.spT2 = new System.Windows.Forms.Panel();
            this.cardClases = new System.Windows.Forms.Panel();
            this.lblCantClases = new System.Windows.Forms.Label();
            this.lblCardClases = new System.Windows.Forms.Label();
            this.spT3 = new System.Windows.Forms.Panel();
            this.cardProductos = new System.Windows.Forms.Panel();
            this.lblCantProductos = new System.Windows.Forms.Label();
            this.lblCardProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelTarjetas.SuspendLayout();
            this.cardClientes.SuspendLayout();
            this.cardMembresias.SuspendLayout();
            this.cardClases.SuspendLayout();
            this.cardProductos.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvDatos
            //
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDatos_DataBindingComplete);
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(988, 420);
            this.dgvDatos.TabIndex = 0;
            //
            // spFiltros
            //
            this.spFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.spFiltros.Name = "spFiltros";
            this.spFiltros.Size = new System.Drawing.Size(988, 18);
            this.spFiltros.TabIndex = 0;
            //
            // panelFiltros
            //
            this.panelFiltros.Controls.Add(this.cboVer);
            this.panelFiltros.Controls.Add(this.cboEstado);
            this.panelFiltros.Controls.Add(this.panelBusqueda);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(988, 44);
            this.panelFiltros.TabIndex = 1;
            //
            // cboVer
            //
            this.cboVer.BackColor = System.Drawing.Color.White;
            this.cboVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.cboVer.Items.AddRange(new object[] {
            "Clientes",
            "Productos",
            "Entrenadores",
            "Clases"});
            this.cboVer.Location = new System.Drawing.Point(0, 8);
            this.cboVer.Name = "cboVer";
            this.cboVer.Size = new System.Drawing.Size(190, 27);
            this.cboVer.TabIndex = 1;
            //
            // cboEstado
            //
            this.cboEstado.BackColor = System.Drawing.Color.White;
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.cboEstado.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Inactivos"});
            this.cboEstado.Location = new System.Drawing.Point(206, 8);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(150, 27);
            this.cboEstado.TabIndex = 2;
            //
            // panelBusqueda
            //
            this.panelBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBusqueda.BackColor = System.Drawing.Color.White;
            this.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Controls.Add(this.lblLupa);
            this.panelBusqueda.Location = new System.Drawing.Point(372, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.panelBusqueda.Size = new System.Drawing.Size(616, 44);
            this.panelBusqueda.TabIndex = 0;
            //
            // txtBuscar
            //
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(558, 20);
            this.txtBuscar.TabIndex = 3;
            //
            // lblLupa
            //
            this.lblLupa.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLupa.Image = global::ProyectoFinal_Programacion3.Properties.Resources.icono_buscar;
            this.lblLupa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(30, 20);
            this.lblLupa.TabIndex = 0;
            //
            // spTarjetas
            //
            this.spTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.spTarjetas.Name = "spTarjetas";
            this.spTarjetas.Size = new System.Drawing.Size(988, 18);
            this.spTarjetas.TabIndex = 0;
            //
            // panelTarjetas
            //
            this.panelTarjetas.Controls.Add(this.cardProductos);
            this.panelTarjetas.Controls.Add(this.spT3);
            this.panelTarjetas.Controls.Add(this.cardClases);
            this.panelTarjetas.Controls.Add(this.spT2);
            this.panelTarjetas.Controls.Add(this.cardMembresias);
            this.panelTarjetas.Controls.Add(this.spT1);
            this.panelTarjetas.Controls.Add(this.cardClientes);
            this.panelTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTarjetas.Name = "panelTarjetas";
            this.panelTarjetas.Size = new System.Drawing.Size(988, 104);
            this.panelTarjetas.TabIndex = 2;
            //
            // cardClientes
            //
            this.cardClientes.BackColor = System.Drawing.Color.White;
            this.cardClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardClientes.Controls.Add(this.lblCantClientes);
            this.cardClientes.Controls.Add(this.lblCardClientes);
            this.cardClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardClientes.Name = "cardClientes";
            this.cardClientes.Padding = new System.Windows.Forms.Padding(20, 18, 16, 16);
            this.cardClientes.Size = new System.Drawing.Size(235, 104);
            this.cardClientes.TabIndex = 0;
            //
            // lblCantClientes
            //
            this.lblCantClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCantClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(199, 40);
            this.lblCantClientes.TabIndex = 1;
            this.lblCantClientes.Text = "0";
            //
            // lblCardClientes
            //
            this.lblCardClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardClientes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblCardClientes.Name = "lblCardClientes";
            this.lblCardClientes.Size = new System.Drawing.Size(199, 22);
            this.lblCardClientes.TabIndex = 0;
            this.lblCardClientes.Text = "Clientes activos";
            //
            // spT1
            //
            this.spT1.Dock = System.Windows.Forms.DockStyle.Left;
            this.spT1.Name = "spT1";
            this.spT1.Size = new System.Drawing.Size(16, 104);
            this.spT1.TabIndex = 0;
            //
            // cardMembresias
            //
            this.cardMembresias.BackColor = System.Drawing.Color.White;
            this.cardMembresias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMembresias.Controls.Add(this.lblCantMembresias);
            this.cardMembresias.Controls.Add(this.lblCardMembresias);
            this.cardMembresias.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardMembresias.Name = "cardMembresias";
            this.cardMembresias.Padding = new System.Windows.Forms.Padding(20, 18, 16, 16);
            this.cardMembresias.Size = new System.Drawing.Size(235, 104);
            this.cardMembresias.TabIndex = 0;
            //
            // lblCantMembresias
            //
            this.lblCantMembresias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCantMembresias.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantMembresias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblCantMembresias.Name = "lblCantMembresias";
            this.lblCantMembresias.Size = new System.Drawing.Size(199, 40);
            this.lblCantMembresias.TabIndex = 1;
            this.lblCantMembresias.Text = "0";
            //
            // lblCardMembresias
            //
            this.lblCardMembresias.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardMembresias.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardMembresias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblCardMembresias.Name = "lblCardMembresias";
            this.lblCardMembresias.Size = new System.Drawing.Size(199, 22);
            this.lblCardMembresias.TabIndex = 0;
            this.lblCardMembresias.Text = "Membresías activas";
            //
            // spT2
            //
            this.spT2.Dock = System.Windows.Forms.DockStyle.Left;
            this.spT2.Name = "spT2";
            this.spT2.Size = new System.Drawing.Size(16, 104);
            this.spT2.TabIndex = 0;
            //
            // cardClases
            //
            this.cardClases.BackColor = System.Drawing.Color.White;
            this.cardClases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardClases.Controls.Add(this.lblCantClases);
            this.cardClases.Controls.Add(this.lblCardClases);
            this.cardClases.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardClases.Name = "cardClases";
            this.cardClases.Padding = new System.Windows.Forms.Padding(20, 18, 16, 16);
            this.cardClases.Size = new System.Drawing.Size(235, 104);
            this.cardClases.TabIndex = 0;
            //
            // lblCantClases
            //
            this.lblCantClases.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCantClases.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantClases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblCantClases.Name = "lblCantClases";
            this.lblCantClases.Size = new System.Drawing.Size(199, 40);
            this.lblCantClases.TabIndex = 1;
            this.lblCantClases.Text = "0";
            //
            // lblCardClases
            //
            this.lblCardClases.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardClases.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardClases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblCardClases.Name = "lblCardClases";
            this.lblCardClases.Size = new System.Drawing.Size(199, 22);
            this.lblCardClases.TabIndex = 0;
            this.lblCardClases.Text = "Clases registradas";
            //
            // spT3
            //
            this.spT3.Dock = System.Windows.Forms.DockStyle.Left;
            this.spT3.Name = "spT3";
            this.spT3.Size = new System.Drawing.Size(16, 104);
            this.spT3.TabIndex = 0;
            //
            // cardProductos
            //
            this.cardProductos.BackColor = System.Drawing.Color.White;
            this.cardProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardProductos.Controls.Add(this.lblCantProductos);
            this.cardProductos.Controls.Add(this.lblCardProductos);
            this.cardProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.cardProductos.Name = "cardProductos";
            this.cardProductos.Padding = new System.Windows.Forms.Padding(20, 18, 16, 16);
            this.cardProductos.Size = new System.Drawing.Size(235, 104);
            this.cardProductos.TabIndex = 0;
            //
            // lblCantProductos
            //
            this.lblCantProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCantProductos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCantProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblCantProductos.Name = "lblCantProductos";
            this.lblCantProductos.Size = new System.Drawing.Size(199, 40);
            this.lblCantProductos.TabIndex = 1;
            this.lblCantProductos.Text = "0";
            //
            // lblCardProductos
            //
            this.lblCardProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardProductos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCardProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblCardProductos.Name = "lblCardProductos";
            this.lblCardProductos.Size = new System.Drawing.Size(199, 22);
            this.lblCardProductos.TabIndex = 0;
            this.lblCardProductos.Text = "Productos en stock";
            //
            // FrmInicio
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1040, 656);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.spFiltros);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.spTarjetas);
            this.Controls.Add(this.panelTarjetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Padding = new System.Windows.Forms.Padding(28, 24, 24, 28);
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panelTarjetas.ResumeLayout(false);
            this.cardClientes.ResumeLayout(false);
            this.cardMembresias.ResumeLayout(false);
            this.cardClases.ResumeLayout(false);
            this.cardProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel spFiltros;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.ComboBox cboVer;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.Panel spTarjetas;
        private System.Windows.Forms.Panel panelTarjetas;
        private System.Windows.Forms.Panel cardClientes;
        private System.Windows.Forms.Label lblCantClientes;
        private System.Windows.Forms.Label lblCardClientes;
        private System.Windows.Forms.Panel spT1;
        private System.Windows.Forms.Panel cardMembresias;
        private System.Windows.Forms.Label lblCantMembresias;
        private System.Windows.Forms.Label lblCardMembresias;
        private System.Windows.Forms.Panel spT2;
        private System.Windows.Forms.Panel cardClases;
        private System.Windows.Forms.Label lblCantClases;
        private System.Windows.Forms.Label lblCardClases;
        private System.Windows.Forms.Panel spT3;
        private System.Windows.Forms.Panel cardProductos;
        private System.Windows.Forms.Label lblCantProductos;
        private System.Windows.Forms.Label lblCardProductos;
    }
}