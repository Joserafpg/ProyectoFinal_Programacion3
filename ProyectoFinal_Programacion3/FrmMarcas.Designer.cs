namespace ProyectoFinal_Programacion3
{
    partial class FrmMarcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.spGrid = new System.Windows.Forms.Panel();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblLupa = new System.Windows.Forms.Label();
            this.spNuevo = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panelBarra.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(163)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(163)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeight = 42;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowTemplate.Height = 38;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(988, 542);
            this.dgvDatos.TabIndex = 0;
            // 
            // spGrid
            // 
            this.spGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.spGrid.Name = "spGrid";
            this.spGrid.Size = new System.Drawing.Size(988, 18);
            this.spGrid.TabIndex = 0;
            // 
            // panelBarra
            // 
            this.panelBarra.Controls.Add(this.panelBusqueda);
            this.panelBarra.Controls.Add(this.spNuevo);
            this.panelBarra.Controls.Add(this.btnNuevo);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(988, 44);
            this.panelBarra.TabIndex = 1;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.White;
            this.panelBusqueda.Controls.Add(this.txtBuscar);
            this.panelBusqueda.Controls.Add(this.lblLupa);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.panelBusqueda.Size = new System.Drawing.Size(842, 44);
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
            this.txtBuscar.Size = new System.Drawing.Size(784, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblLupa
            // 
            this.lblLupa.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLupa.Image = global::ProyectoFinal_Programacion3.Properties.Resources.icono_buscar;
            this.lblLupa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLupa.Name = "lblLupa";
            this.lblLupa.Size = new System.Drawing.Size(30, 20);
            this.lblLupa.TabIndex = 0;
            this.lblLupa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spNuevo
            // 
            this.spNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.spNuevo.Name = "spNuevo";
            this.spNuevo.Size = new System.Drawing.Size(16, 44);
            this.spNuevo.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 44);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "+  Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // FrmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1040, 656);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.spGrid);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMarcas";
            this.Padding = new System.Windows.Forms.Padding(28, 24, 24, 28);
            this.Text = "Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panelBarra.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel spGrid;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblLupa;
        private System.Windows.Forms.Panel spNuevo;
        private System.Windows.Forms.Button btnNuevo;
    }
}

