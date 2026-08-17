namespace ProyectoFinal_Programacion3
{
    partial class FrmCheckIn
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
            this.dgvMorosos = new System.Windows.Forms.DataGridView();
            this.spG = new System.Windows.Forms.Panel();
            this.panelVisita = new System.Windows.Forms.Panel();
            this.lblVisita = new System.Windows.Forms.Label();
            this.spM1 = new System.Windows.Forms.Panel();
            this.cboMetodoVisita = new System.Windows.Forms.ComboBox();
            this.spM2 = new System.Windows.Forms.Panel();
            this.btnCobrarVisita = new System.Windows.Forms.Button();
            this.spV = new System.Windows.Forms.Panel();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.lblMorosos = new System.Windows.Forms.Label();
            this.spB1 = new System.Windows.Forms.Panel();
            this.btnExplorar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorosos)).BeginInit();
            this.panelVisita.SuspendLayout();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvMorosos.Location = new System.Drawing.Point(32, 200);
            this.dgvMorosos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMorosos.MultiSelect = false;
            this.dgvMorosos.Name = "dgvMorosos";
            this.dgvMorosos.ReadOnly = true;
            this.dgvMorosos.RowHeadersVisible = false;
            this.dgvMorosos.RowHeadersWidth = 51;
            this.dgvMorosos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMorosos.Size = new System.Drawing.Size(1323, 577);
            this.dgvMorosos.TabIndex = 6;
            // 
            // spG
            // 
            this.spG.Dock = System.Windows.Forms.DockStyle.Top;
            this.spG.Location = new System.Drawing.Point(32, 185);
            this.spG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spG.Name = "spG";
            this.spG.Size = new System.Drawing.Size(1323, 15);
            this.spG.TabIndex = 0;
            // 
            // panelVisita
            // 
            this.panelVisita.BackColor = System.Drawing.Color.White;
            this.panelVisita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVisita.Controls.Add(this.lblVisita);
            this.panelVisita.Controls.Add(this.spM1);
            this.panelVisita.Controls.Add(this.cboMetodoVisita);
            this.panelVisita.Controls.Add(this.spM2);
            this.panelVisita.Controls.Add(this.btnCobrarVisita);
            this.panelVisita.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVisita.Location = new System.Drawing.Point(32, 94);
            this.panelVisita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelVisita.Name = "panelVisita";
            this.panelVisita.Padding = new System.Windows.Forms.Padding(27, 20, 27, 20);
            this.panelVisita.Size = new System.Drawing.Size(1323, 91);
            this.panelVisita.TabIndex = 3;
            // 
            // lblVisita
            // 
            this.lblVisita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVisita.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblVisita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblVisita.Location = new System.Drawing.Point(27, 20);
            this.lblVisita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisita.Name = "lblVisita";
            this.lblVisita.Size = new System.Drawing.Size(803, 49);
            this.lblVisita.TabIndex = 0;
            this.lblVisita.Text = "Dar acceso sin membresía · Visita del día: RD$0.00";
            this.lblVisita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spM1
            // 
            this.spM1.Dock = System.Windows.Forms.DockStyle.Right;
            this.spM1.Location = new System.Drawing.Point(830, 20);
            this.spM1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spM1.Name = "spM1";
            this.spM1.Size = new System.Drawing.Size(13, 49);
            this.spM1.TabIndex = 0;
            // 
            // cboMetodoVisita
            // 
            this.cboMetodoVisita.Dock = System.Windows.Forms.DockStyle.Right;
            this.cboMetodoVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodoVisita.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMetodoVisita.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia"});
            this.cboMetodoVisita.Location = new System.Drawing.Point(843, 20);
            this.cboMetodoVisita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMetodoVisita.Name = "cboMetodoVisita";
            this.cboMetodoVisita.Size = new System.Drawing.Size(185, 31);
            this.cboMetodoVisita.TabIndex = 3;
            // 
            // spM2
            // 
            this.spM2.Dock = System.Windows.Forms.DockStyle.Right;
            this.spM2.Location = new System.Drawing.Point(1028, 20);
            this.spM2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spM2.Name = "spM2";
            this.spM2.Size = new System.Drawing.Size(13, 49);
            this.spM2.TabIndex = 0;
            // 
            // btnCobrarVisita
            // 
            this.btnCobrarVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnCobrarVisita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrarVisita.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCobrarVisita.FlatAppearance.BorderSize = 0;
            this.btnCobrarVisita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnCobrarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrarVisita.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCobrarVisita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnCobrarVisita.Location = new System.Drawing.Point(1041, 20);
            this.btnCobrarVisita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCobrarVisita.Name = "btnCobrarVisita";
            this.btnCobrarVisita.Size = new System.Drawing.Size(253, 49);
            this.btnCobrarVisita.TabIndex = 4;
            this.btnCobrarVisita.Text = "Cobrar y dejar pasar";
            this.btnCobrarVisita.UseVisualStyleBackColor = false;
            // 
            // spV
            // 
            this.spV.Dock = System.Windows.Forms.DockStyle.Top;
            this.spV.Location = new System.Drawing.Point(32, 79);
            this.spV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spV.Name = "spV";
            this.spV.Size = new System.Drawing.Size(1323, 15);
            this.spV.TabIndex = 0;
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.lblMorosos);
            this.panelBarra.Controls.Add(this.spB1);
            this.panelBarra.Controls.Add(this.btnExplorar);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(32, 25);
            this.panelBarra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1323, 54);
            this.panelBarra.TabIndex = 1;
            // 
            // lblMorosos
            // 
            this.lblMorosos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMorosos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMorosos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblMorosos.Location = new System.Drawing.Point(0, 0);
            this.lblMorosos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMorosos.Name = "lblMorosos";
            this.lblMorosos.Size = new System.Drawing.Size(1048, 54);
            this.lblMorosos.TabIndex = 0;
            this.lblMorosos.Text = "Deben renovar (doble click para cobrar)";
            this.lblMorosos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spB1
            // 
            this.spB1.Dock = System.Windows.Forms.DockStyle.Right;
            this.spB1.Location = new System.Drawing.Point(1048, 0);
            this.spB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spB1.Name = "spB1";
            this.spB1.Size = new System.Drawing.Size(16, 54);
            this.spB1.TabIndex = 0;
            // 
            // btnExplorar
            // 
            this.btnExplorar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnExplorar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExplorar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExplorar.FlatAppearance.BorderSize = 0;
            this.btnExplorar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnExplorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExplorar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExplorar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnExplorar.Location = new System.Drawing.Point(1064, 0);
            this.btnExplorar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(259, 54);
            this.btnExplorar.TabIndex = 1;
            this.btnExplorar.Text = "Explorar clientes";
            this.btnExplorar.UseVisualStyleBackColor = false;
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1387, 807);
            this.Controls.Add(this.dgvMorosos);
            this.Controls.Add(this.spG);
            this.Controls.Add(this.panelVisita);
            this.Controls.Add(this.spV);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCheckIn";
            this.Padding = new System.Windows.Forms.Padding(32, 25, 32, 30);
            this.Text = "Check-in";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorosos)).EndInit();
            this.panelVisita.ResumeLayout(false);
            this.panelBarra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMorosos;
        private System.Windows.Forms.Panel spG;
        private System.Windows.Forms.Panel panelVisita;
        private System.Windows.Forms.Label lblVisita;
        private System.Windows.Forms.Panel spM1;
        private System.Windows.Forms.ComboBox cboMetodoVisita;
        private System.Windows.Forms.Panel spM2;
        private System.Windows.Forms.Button btnCobrarVisita;
        private System.Windows.Forms.Panel spV;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Label lblMorosos;
        private System.Windows.Forms.Panel spB1;
        private System.Windows.Forms.Button btnExplorar;
    }
}
