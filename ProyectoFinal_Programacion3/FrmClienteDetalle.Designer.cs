namespace ProyectoFinal_Programacion3
{
    partial class FrmClienteDetalle
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblMembresiaDet = new System.Windows.Forms.Label();
            this.lblCedulaDet = new System.Windows.Forms.Label();
            this.lblNombreDet = new System.Windows.Forms.Label();
            this.spFoto = new System.Windows.Forms.Panel();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblDatos1 = new System.Windows.Forms.Label();
            this.lblDatos2 = new System.Windows.Forms.Label();
            this.lblDatos3 = new System.Windows.Forms.Label();
            this.spP = new System.Windows.Forms.Panel();
            this.lblPagosT = new System.Windows.Forms.Label();
            this.dgvPagosCliente = new System.Windows.Forms.DataGridView();
            this.spC = new System.Windows.Forms.Panel();
            this.lblComprasT = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnCobrarMem = new System.Windows.Forms.Button();
            this.spBB = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCerrarDet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            //
            // panelHeader
            //
            this.panelHeader.Controls.Add(this.panelInfo);
            this.panelHeader.Controls.Add(this.spFoto);
            this.panelHeader.Controls.Add(this.picFoto);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(840, 96);
            this.panelHeader.TabIndex = 0;
            //
            // picFoto
            //
            this.picFoto.BackColor = System.Drawing.Color.White;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(96, 96);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            //
            // spFoto
            //
            this.spFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.spFoto.Name = "spFoto";
            this.spFoto.Size = new System.Drawing.Size(16, 96);
            this.spFoto.TabIndex = 0;
            //
            // panelInfo
            //
            this.panelInfo.Controls.Add(this.lblMembresiaDet);
            this.panelInfo.Controls.Add(this.lblCedulaDet);
            this.panelInfo.Controls.Add(this.lblNombreDet);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panelInfo.Size = new System.Drawing.Size(728, 96);
            this.panelInfo.TabIndex = 0;
            //
            // lblNombreDet
            //
            this.lblNombreDet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreDet.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombreDet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblNombreDet.Name = "lblNombreDet";
            this.lblNombreDet.Size = new System.Drawing.Size(728, 34);
            this.lblNombreDet.TabIndex = 0;
            this.lblNombreDet.Text = "Nombre del cliente";
            //
            // lblCedulaDet
            //
            this.lblCedulaDet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCedulaDet.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblCedulaDet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblCedulaDet.Name = "lblCedulaDet";
            this.lblCedulaDet.Size = new System.Drawing.Size(728, 24);
            this.lblCedulaDet.TabIndex = 0;
            this.lblCedulaDet.Text = "Cédula";
            //
            // lblMembresiaDet
            //
            this.lblMembresiaDet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMembresiaDet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblMembresiaDet.Name = "lblMembresiaDet";
            this.lblMembresiaDet.Size = new System.Drawing.Size(728, 26);
            this.lblMembresiaDet.TabIndex = 0;
            this.lblMembresiaDet.Text = "Membresía";
            //
            // lblDatos1
            //
            this.lblDatos1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDatos1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDatos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblDatos1.Name = "lblDatos1";
            this.lblDatos1.Size = new System.Drawing.Size(840, 22);
            this.lblDatos1.TabIndex = 0;
            //
            // lblDatos2
            //
            this.lblDatos2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDatos2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDatos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblDatos2.Name = "lblDatos2";
            this.lblDatos2.Size = new System.Drawing.Size(840, 22);
            this.lblDatos2.TabIndex = 0;
            //
            // lblDatos3
            //
            this.lblDatos3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDatos3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDatos3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblDatos3.Name = "lblDatos3";
            this.lblDatos3.Size = new System.Drawing.Size(840, 22);
            this.lblDatos3.TabIndex = 0;
            //
            // spP
            //
            this.spP.Dock = System.Windows.Forms.DockStyle.Top;
            this.spP.Name = "spP";
            this.spP.Size = new System.Drawing.Size(840, 12);
            this.spP.TabIndex = 0;
            //
            // lblPagosT
            //
            this.lblPagosT.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPagosT.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblPagosT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblPagosT.Name = "lblPagosT";
            this.lblPagosT.Size = new System.Drawing.Size(840, 24);
            this.lblPagosT.TabIndex = 0;
            this.lblPagosT.Text = "Pagos";
            //
            // dgvPagosCliente
            //
            this.dgvPagosCliente.AllowUserToAddRows = false;
            this.dgvPagosCliente.AllowUserToDeleteRows = false;
            this.dgvPagosCliente.AllowUserToResizeRows = false;
            this.dgvPagosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagosCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvPagosCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPagosCliente.MultiSelect = false;
            this.dgvPagosCliente.Name = "dgvPagosCliente";
            this.dgvPagosCliente.ReadOnly = true;
            this.dgvPagosCliente.RowHeadersVisible = false;
            this.dgvPagosCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagosCliente.Size = new System.Drawing.Size(840, 150);
            this.dgvPagosCliente.TabIndex = 1;
            //
            // spC
            //
            this.spC.Dock = System.Windows.Forms.DockStyle.Top;
            this.spC.Name = "spC";
            this.spC.Size = new System.Drawing.Size(840, 10);
            this.spC.TabIndex = 0;
            //
            // lblComprasT
            //
            this.lblComprasT.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblComprasT.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblComprasT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblComprasT.Name = "lblComprasT";
            this.lblComprasT.Size = new System.Drawing.Size(840, 24);
            this.lblComprasT.TabIndex = 0;
            this.lblComprasT.Text = "Compras";
            //
            // dgvCompras
            //
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompras.MultiSelect = false;
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(840, 140);
            this.dgvCompras.TabIndex = 2;
            //
            // panelBotones
            //
            this.panelBotones.Controls.Add(this.btnCobrarMem);
            this.panelBotones.Controls.Add(this.spBB);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Controls.Add(this.btnCerrarDet);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelBotones.Size = new System.Drawing.Size(840, 48);
            this.panelBotones.TabIndex = 3;
            //
            // btnCobrarMem
            //
            this.btnCobrarMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnCobrarMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrarMem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCobrarMem.FlatAppearance.BorderSize = 0;
            this.btnCobrarMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnCobrarMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrarMem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCobrarMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnCobrarMem.Name = "btnCobrarMem";
            this.btnCobrarMem.Size = new System.Drawing.Size(170, 38);
            this.btnCobrarMem.TabIndex = 3;
            this.btnCobrarMem.Text = "Cobrar membresía";
            this.btnCobrarMem.UseVisualStyleBackColor = false;
            //
            // spBB
            //
            this.spBB.Dock = System.Windows.Forms.DockStyle.Left;
            this.spBB.Name = "spBB";
            this.spBB.Size = new System.Drawing.Size(10, 38);
            this.spBB.TabIndex = 0;
            //
            // btnEditar
            //
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 38);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar cliente";
            this.btnEditar.UseVisualStyleBackColor = true;
            //
            // btnCerrarDet
            //
            this.btnCerrarDet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarDet.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCerrarDet.Name = "btnCerrarDet";
            this.btnCerrarDet.Size = new System.Drawing.Size(150, 38);
            this.btnCerrarDet.TabIndex = 5;
            this.btnCerrarDet.Text = "Cerrar";
            this.btnCerrarDet.UseVisualStyleBackColor = true;
            //
            // FrmClienteDetalle
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrarDet;
            this.ClientSize = new System.Drawing.Size(880, 640);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.lblComprasT);
            this.Controls.Add(this.spC);
            this.Controls.Add(this.dgvPagosCliente);
            this.Controls.Add(this.lblPagosT);
            this.Controls.Add(this.spP);
            this.Controls.Add(this.lblDatos3);
            this.Controls.Add(this.lblDatos2);
            this.Controls.Add(this.lblDatos1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteDetalle";
            this.Padding = new System.Windows.Forms.Padding(20, 16, 20, 14);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del cliente";
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblMembresiaDet;
        private System.Windows.Forms.Label lblCedulaDet;
        private System.Windows.Forms.Label lblNombreDet;
        private System.Windows.Forms.Panel spFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblDatos1;
        private System.Windows.Forms.Label lblDatos2;
        private System.Windows.Forms.Label lblDatos3;
        private System.Windows.Forms.Panel spP;
        private System.Windows.Forms.Label lblPagosT;
        private System.Windows.Forms.DataGridView dgvPagosCliente;
        private System.Windows.Forms.Panel spC;
        private System.Windows.Forms.Label lblComprasT;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnCobrarMem;
        private System.Windows.Forms.Panel spBB;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCerrarDet;
    }
}
