namespace ProyectoFinal_Programacion3
{
    partial class FrmHistorialPagos
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.tabMorosos = new System.Windows.Forms.TabPage();
            this.dgvMorosos = new System.Windows.Forms.DataGridView();
            this.tabCreditos = new System.Windows.Forms.TabPage();
            this.dgvCreditos = new System.Windows.Forms.DataGridView();
            this.spG = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tabPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.tabMorosos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorosos)).BeginInit();
            this.tabCreditos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).BeginInit();
            this.SuspendLayout();
            //
            // tabs
            //
            this.tabs.Controls.Add(this.tabPagos);
            this.tabs.Controls.Add(this.tabMorosos);
            this.tabs.Controls.Add(this.tabCreditos);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabs.Location = new System.Drawing.Point(20, 56);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1110, 544);
            this.tabs.TabIndex = 0;
            //
            // tabPagos
            //
            this.tabPagos.Controls.Add(this.dgvPagos);
            this.tabPagos.Location = new System.Drawing.Point(4, 32);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagos.Size = new System.Drawing.Size(1102, 508);
            this.tabPagos.TabIndex = 0;
            this.tabPagos.Text = "Pagos";
            this.tabPagos.UseVisualStyleBackColor = true;
            //
            // dgvPagos
            //
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToResizeRows = false;
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPagos.ColumnHeadersHeight = 29;
            this.dgvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagos.Location = new System.Drawing.Point(3, 3);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowHeadersWidth = 51;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(1096, 502);
            this.dgvPagos.TabIndex = 0;
            //
            // tabMorosos
            //
            this.tabMorosos.Controls.Add(this.dgvMorosos);
            this.tabMorosos.Location = new System.Drawing.Point(4, 32);
            this.tabMorosos.Name = "tabMorosos";
            this.tabMorosos.Padding = new System.Windows.Forms.Padding(3);
            this.tabMorosos.Size = new System.Drawing.Size(1102, 508);
            this.tabMorosos.TabIndex = 1;
            this.tabMorosos.Text = "Deben renovar";
            this.tabMorosos.UseVisualStyleBackColor = true;
            //
            // dgvMorosos
            //
            this.dgvMorosos.AllowUserToAddRows = false;
            this.dgvMorosos.AllowUserToDeleteRows = false;
            this.dgvMorosos.AllowUserToResizeRows = false;
            this.dgvMorosos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMorosos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMorosos.ColumnHeadersHeight = 29;
            this.dgvMorosos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMorosos.Location = new System.Drawing.Point(3, 3);
            this.dgvMorosos.MultiSelect = false;
            this.dgvMorosos.Name = "dgvMorosos";
            this.dgvMorosos.ReadOnly = true;
            this.dgvMorosos.RowHeadersVisible = false;
            this.dgvMorosos.RowHeadersWidth = 51;
            this.dgvMorosos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMorosos.Size = new System.Drawing.Size(1096, 502);
            this.dgvMorosos.TabIndex = 0;
            //
            // tabCreditos
            //
            this.tabCreditos.Controls.Add(this.dgvCreditos);
            this.tabCreditos.Location = new System.Drawing.Point(4, 32);
            this.tabCreditos.Name = "tabCreditos";
            this.tabCreditos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreditos.Size = new System.Drawing.Size(1102, 508);
            this.tabCreditos.TabIndex = 2;
            this.tabCreditos.Text = "Créditos pendientes";
            this.tabCreditos.UseVisualStyleBackColor = true;
            //
            // dgvCreditos
            //
            this.dgvCreditos.AllowUserToAddRows = false;
            this.dgvCreditos.AllowUserToDeleteRows = false;
            this.dgvCreditos.AllowUserToResizeRows = false;
            this.dgvCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCreditos.ColumnHeadersHeight = 29;
            this.dgvCreditos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCreditos.Location = new System.Drawing.Point(3, 3);
            this.dgvCreditos.MultiSelect = false;
            this.dgvCreditos.Name = "dgvCreditos";
            this.dgvCreditos.ReadOnly = true;
            this.dgvCreditos.RowHeadersVisible = false;
            this.dgvCreditos.RowHeadersWidth = 51;
            this.dgvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreditos.Size = new System.Drawing.Size(1096, 502);
            this.dgvCreditos.TabIndex = 0;
            //
            // spG
            //
            this.spG.Dock = System.Windows.Forms.DockStyle.Top;
            this.spG.Location = new System.Drawing.Point(20, 46);
            this.spG.Name = "spG";
            this.spG.Size = new System.Drawing.Size(1110, 10);
            this.spG.TabIndex = 0;
            //
            // lblInfo
            //
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1110, 26);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Doble click sobre alguien en \"Deben renovar\" o \"Créditos pendientes\" para seleccionarlo y cobrarle";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // FrmHistorialPagos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1150, 620);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.spG);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHistorialPagos";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial de pagos";
            this.tabs.ResumeLayout(false);
            this.tabPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.tabMorosos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorosos)).EndInit();
            this.tabCreditos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPagos;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.TabPage tabMorosos;
        private System.Windows.Forms.DataGridView dgvMorosos;
        private System.Windows.Forms.TabPage tabCreditos;
        private System.Windows.Forms.DataGridView dgvCreditos;
        private System.Windows.Forms.Panel spG;
        private System.Windows.Forms.Label lblInfo;
    }
}
