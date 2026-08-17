namespace ProyectoFinal_Programacion3
{
    partial class FrmBuscarCliente
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.spBusqueda = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.spBD = new System.Windows.Forms.Panel();
            this.btnConsumidor = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            //
            // txtBuscar
            //
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(608, 25);
            this.txtBuscar.TabIndex = 1;
            //
            // spBusqueda
            //
            this.spBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBusqueda.Name = "spBusqueda";
            this.spBusqueda.Size = new System.Drawing.Size(608, 10);
            this.spBusqueda.TabIndex = 0;
            //
            // dgvClientes
            //
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(608, 337);
            this.dgvClientes.TabIndex = 2;
            //
            // panelBotones
            //
            this.panelBotones.Controls.Add(this.btnDetalles);
            this.panelBotones.Controls.Add(this.spBD);
            this.panelBotones.Controls.Add(this.btnConsumidor);
            this.panelBotones.Controls.Add(this.btnSeleccionar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelBotones.Size = new System.Drawing.Size(608, 48);
            this.panelBotones.TabIndex = 3;
            //
            // btnDetalles
            //
            this.btnDetalles.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDetalles.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(140, 38);
            this.btnDetalles.TabIndex = 5;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            //
            // spBD
            //
            this.spBD.Dock = System.Windows.Forms.DockStyle.Left;
            this.spBD.Name = "spBD";
            this.spBD.Size = new System.Drawing.Size(10, 38);
            this.spBD.TabIndex = 0;
            //
            // btnConsumidor
            //
            this.btnConsumidor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsumidor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnConsumidor.Name = "btnConsumidor";
            this.btnConsumidor.Size = new System.Drawing.Size(160, 38);
            this.btnConsumidor.TabIndex = 4;
            this.btnConsumidor.Text = "Consumidor final";
            this.btnConsumidor.UseVisualStyleBackColor = true;
            //
            // btnSeleccionar
            //
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(160, 38);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            //
            // FrmBuscarCliente
            //
            this.AcceptButton = this.btnSeleccionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 452);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.spBusqueda);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarCliente";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel spBusqueda;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Panel spBD;
        private System.Windows.Forms.Button btnConsumidor;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}
