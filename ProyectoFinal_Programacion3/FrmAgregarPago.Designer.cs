namespace ProyectoFinal_Programacion3
{
    partial class FrmAgregarPago
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
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.spG = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.spB1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            //
            // dgvPendientes
            //
            this.dgvPendientes.AllowUserToAddRows = false;
            this.dgvPendientes.AllowUserToDeleteRows = false;
            this.dgvPendientes.AllowUserToResizeRows = false;
            this.dgvPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPendientes.ColumnHeadersHeight = 29;
            this.dgvPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendientes.Location = new System.Drawing.Point(20, 56);
            this.dgvPendientes.MultiSelect = false;
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.ReadOnly = true;
            this.dgvPendientes.RowHeadersVisible = false;
            this.dgvPendientes.RowHeadersWidth = 51;
            this.dgvPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendientes.Size = new System.Drawing.Size(844, 380);
            this.dgvPendientes.TabIndex = 0;
            //
            // spG
            //
            this.spG.Dock = System.Windows.Forms.DockStyle.Top;
            this.spG.Location = new System.Drawing.Point(20, 46);
            this.spG.Name = "spG";
            this.spG.Size = new System.Drawing.Size(844, 10);
            this.spG.TabIndex = 0;
            //
            // lblInfo
            //
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(844, 26);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Doble click sobre un pendiente (o el botón Agregar) para sumarlo al pago";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // panelBotones
            //
            this.panelBotones.Controls.Add(this.btnAgregar);
            this.panelBotones.Controls.Add(this.spB1);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(20, 436);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.panelBotones.Size = new System.Drawing.Size(844, 60);
            this.panelBotones.TabIndex = 1;
            //
            // btnAgregar
            //
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnAgregar.Location = new System.Drawing.Point(624, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(220, 46);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar al pago";
            this.btnAgregar.UseVisualStyleBackColor = false;
            //
            // spB1
            //
            this.spB1.Dock = System.Windows.Forms.DockStyle.Right;
            this.spB1.Location = new System.Drawing.Point(611, 14);
            this.spB1.Name = "spB1";
            this.spB1.Size = new System.Drawing.Size(13, 46);
            this.spB1.TabIndex = 0;
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
            this.btnCerrar.Location = new System.Drawing.Point(471, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 46);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Listo";
            this.btnCerrar.UseVisualStyleBackColor = false;
            //
            // FrmAgregarPago
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.dgvPendientes);
            this.Controls.Add(this.spG);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarPago";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar pago";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.Panel spG;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel spB1;
        private System.Windows.Forms.Button btnCerrar;
    }
}
