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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPagos = new System.Windows.Forms.TabPage();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.tabMorosos = new System.Windows.Forms.TabPage();
            this.dgvMorosos = new System.Windows.Forms.DataGridView();
            this.tabCreditos = new System.Windows.Forms.TabPage();
            this.dgvCreditos = new System.Windows.Forms.DataGridView();
            this.spG = new System.Windows.Forms.Panel();
            this.panelPago = new System.Windows.Forms.Panel();
            this.panelInfoPago = new System.Windows.Forms.Panel();
            this.lblInfoPago = new System.Windows.Forms.Label();
            this.spI = new System.Windows.Forms.Panel();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.spT2 = new System.Windows.Forms.Panel();
            this.panelFilaPago = new System.Windows.Forms.Panel();
            this.cboMetodo = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.spM = new System.Windows.Forms.Panel();
            this.panelMet = new System.Windows.Forms.Panel();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.sp2 = new System.Windows.Forms.Panel();
            this.cboDetalle = new System.Windows.Forms.ComboBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.sp1 = new System.Windows.Forms.Panel();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.spT = new System.Windows.Forms.Panel();
            this.lblTituloPago = new System.Windows.Forms.Label();
            this.spP = new System.Windows.Forms.Panel();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEstadoCli = new System.Windows.Forms.Label();
            this.spC = new System.Windows.Forms.Panel();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.tabMorosos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorosos)).BeginInit();
            this.tabCreditos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).BeginInit();
            this.panelPago.SuspendLayout();
            this.panelInfoPago.SuspendLayout();
            this.panelMet.SuspendLayout();
            this.panelFilaPago.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            //
            // tabs
            //
            this.tabs.Controls.Add(this.tabPagos);
            this.tabs.Controls.Add(this.tabMorosos);
            this.tabs.Controls.Add(this.tabCreditos);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabs.Location = new System.Drawing.Point(32, 295);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1323, 482);
            this.tabs.TabIndex = 4;
            //
            // tabPagos
            //
            this.tabPagos.Controls.Add(this.dgvPagos);
            this.tabPagos.Location = new System.Drawing.Point(4, 32);
            this.tabPagos.Name = "tabPagos";
            this.tabPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagos.Size = new System.Drawing.Size(1315, 446);
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
            this.dgvPagos.Size = new System.Drawing.Size(1309, 440);
            this.dgvPagos.TabIndex = 0;
            //
            // tabMorosos
            //
            this.tabMorosos.Controls.Add(this.dgvMorosos);
            this.tabMorosos.Location = new System.Drawing.Point(4, 32);
            this.tabMorosos.Name = "tabMorosos";
            this.tabMorosos.Padding = new System.Windows.Forms.Padding(3);
            this.tabMorosos.Size = new System.Drawing.Size(1315, 446);
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
            this.dgvMorosos.Size = new System.Drawing.Size(1309, 440);
            this.dgvMorosos.TabIndex = 0;
            //
            // tabCreditos
            //
            this.tabCreditos.Controls.Add(this.dgvCreditos);
            this.tabCreditos.Location = new System.Drawing.Point(4, 32);
            this.tabCreditos.Name = "tabCreditos";
            this.tabCreditos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreditos.Size = new System.Drawing.Size(1315, 446);
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
            this.dgvCreditos.Size = new System.Drawing.Size(1309, 440);
            this.dgvCreditos.TabIndex = 0;
            //
            // spG
            //
            this.spG.Dock = System.Windows.Forms.DockStyle.Top;
            this.spG.Location = new System.Drawing.Point(32, 280);
            this.spG.Name = "spG";
            this.spG.Size = new System.Drawing.Size(1323, 15);
            this.spG.TabIndex = 0;
            //
            // panelPago
            //
            this.panelPago.BackColor = System.Drawing.Color.White;
            this.panelPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPago.Controls.Add(this.panelInfoPago);
            this.panelPago.Controls.Add(this.spT2);
            this.panelPago.Controls.Add(this.panelFilaPago);
            this.panelPago.Controls.Add(this.spT);
            this.panelPago.Controls.Add(this.lblTituloPago);
            this.panelPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPago.Location = new System.Drawing.Point(32, 130);
            this.panelPago.Name = "panelPago";
            this.panelPago.Padding = new System.Windows.Forms.Padding(27, 16, 27, 16);
            this.panelPago.Size = new System.Drawing.Size(1323, 150);
            this.panelPago.TabIndex = 2;
            //
            // panelInfoPago
            //
            this.panelInfoPago.Controls.Add(this.lblInfoPago);
            this.panelInfoPago.Controls.Add(this.spI);
            this.panelInfoPago.Controls.Add(this.btnRegistrarPago);
            this.panelInfoPago.Controls.Add(this.spM);
            this.panelInfoPago.Controls.Add(this.panelMet);
            this.panelInfoPago.Controls.Add(this.lblMetodo);
            this.panelInfoPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoPago.Location = new System.Drawing.Point(27, 90);
            this.panelInfoPago.Name = "panelInfoPago";
            this.panelInfoPago.Size = new System.Drawing.Size(1267, 42);
            this.panelInfoPago.TabIndex = 4;
            //
            // lblInfoPago
            //
            this.lblInfoPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblInfoPago.Location = new System.Drawing.Point(0, 0);
            this.lblInfoPago.Name = "lblInfoPago";
            this.lblInfoPago.Size = new System.Drawing.Size(1034, 42);
            this.lblInfoPago.TabIndex = 0;
            this.lblInfoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spI
            //
            this.spI.Dock = System.Windows.Forms.DockStyle.Right;
            this.spI.Location = new System.Drawing.Point(1034, 0);
            this.spI.Name = "spI";
            this.spI.Size = new System.Drawing.Size(13, 42);
            this.spI.TabIndex = 0;
            //
            // btnRegistrarPago
            //
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPago.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnRegistrarPago.Location = new System.Drawing.Point(1047, 0);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(220, 42);
            this.btnRegistrarPago.TabIndex = 1;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            //
            // spT2
            //
            this.spT2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spT2.Location = new System.Drawing.Point(27, 82);
            this.spT2.Name = "spT2";
            this.spT2.Size = new System.Drawing.Size(1267, 8);
            this.spT2.TabIndex = 0;
            //
            // panelFilaPago
            //
            this.panelFilaPago.Controls.Add(this.txtMonto);
            this.panelFilaPago.Controls.Add(this.lblMonto);
            this.panelFilaPago.Controls.Add(this.sp2);
            this.panelFilaPago.Controls.Add(this.cboDetalle);
            this.panelFilaPago.Controls.Add(this.lblDetalle);
            this.panelFilaPago.Controls.Add(this.sp1);
            this.panelFilaPago.Controls.Add(this.cboTipo);
            this.panelFilaPago.Controls.Add(this.lblTipo);
            this.panelFilaPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilaPago.Location = new System.Drawing.Point(27, 52);
            this.panelFilaPago.Name = "panelFilaPago";
            this.panelFilaPago.Size = new System.Drawing.Size(1267, 30);
            this.panelFilaPago.TabIndex = 1;
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
            this.cboMetodo.Location = new System.Drawing.Point(868, 0);
            this.cboMetodo.Name = "cboMetodo";
            this.cboMetodo.Size = new System.Drawing.Size(160, 28);
            this.cboMetodo.TabIndex = 3;
            //
            // lblMetodo
            //
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMetodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMetodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblMetodo.Location = new System.Drawing.Point(798, 0);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblMetodo.Size = new System.Drawing.Size(70, 30);
            this.lblMetodo.TabIndex = 0;
            this.lblMetodo.Text = "Método:";
            this.lblMetodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spM
            //
            this.spM.Dock = System.Windows.Forms.DockStyle.Left;
            this.spM.Location = new System.Drawing.Point(230, 0);
            this.spM.Name = "spM";
            this.spM.Size = new System.Drawing.Size(16, 42);
            this.spM.TabIndex = 0;
            //
            // panelMet
            //
            this.panelMet.Controls.Add(this.cboMetodo);
            this.panelMet.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMet.Location = new System.Drawing.Point(70, 0);
            this.panelMet.Name = "panelMet";
            this.panelMet.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.panelMet.Size = new System.Drawing.Size(160, 42);
            this.panelMet.TabIndex = 1;
            //
            // txtMonto
            //
            this.txtMonto.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMonto.Location = new System.Drawing.Point(662, 0);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(130, 27);
            this.txtMonto.TabIndex = 2;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblMonto
            //
            this.lblMonto.AutoSize = true;
            this.lblMonto.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblMonto.Location = new System.Drawing.Point(602, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblMonto.Size = new System.Drawing.Size(60, 30);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto:";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // sp2
            //
            this.sp2.Dock = System.Windows.Forms.DockStyle.Left;
            this.sp2.Location = new System.Drawing.Point(586, 0);
            this.sp2.Name = "sp2";
            this.sp2.Size = new System.Drawing.Size(16, 30);
            this.sp2.TabIndex = 0;
            //
            // cboDetalle
            //
            this.cboDetalle.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDetalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDetalle.Location = new System.Drawing.Point(286, 0);
            this.cboDetalle.Name = "cboDetalle";
            this.cboDetalle.Size = new System.Drawing.Size(400, 28);
            this.cboDetalle.TabIndex = 1;
            //
            // lblDetalle
            //
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblDetalle.Location = new System.Drawing.Point(226, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblDetalle.Size = new System.Drawing.Size(60, 30);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Text = "Plan:";
            this.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // sp1
            //
            this.sp1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sp1.Location = new System.Drawing.Point(210, 0);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(16, 30);
            this.sp1.TabIndex = 0;
            //
            // cboTipo
            //
            this.cboTipo.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTipo.Items.AddRange(new object[] {
            "Membresía",
            "Abono a crédito",
            "Visita del día"});
            this.cboTipo.Location = new System.Drawing.Point(50, 0);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(190, 28);
            this.cboTipo.TabIndex = 0;
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTipo.Location = new System.Drawing.Point(0, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblTipo.Size = new System.Drawing.Size(50, 30);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spT
            //
            this.spT.Dock = System.Windows.Forms.DockStyle.Top;
            this.spT.Location = new System.Drawing.Point(27, 44);
            this.spT.Name = "spT";
            this.spT.Size = new System.Drawing.Size(1267, 8);
            this.spT.TabIndex = 0;
            //
            // lblTituloPago
            //
            this.lblTituloPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTituloPago.Location = new System.Drawing.Point(27, 16);
            this.lblTituloPago.Name = "lblTituloPago";
            this.lblTituloPago.Size = new System.Drawing.Size(1267, 28);
            this.lblTituloPago.TabIndex = 0;
            this.lblTituloPago.Text = "Registrar pago";
            this.lblTituloPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panelInfo.Size = new System.Drawing.Size(1051, 56);
            this.panelInfo.TabIndex = 2;
            //
            // lblCliente
            //
            this.lblCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblCliente.Location = new System.Drawing.Point(0, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(1051, 32);
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
            this.lblEstadoCli.Size = new System.Drawing.Size(1051, 24);
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
            // FrmPagos
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1387, 807);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.spG);
            this.Controls.Add(this.panelPago);
            this.Controls.Add(this.spP);
            this.Controls.Add(this.panelCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagos";
            this.Padding = new System.Windows.Forms.Padding(32, 25, 32, 30);
            this.Text = "Pagos";
            this.tabs.ResumeLayout(false);
            this.tabPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.tabMorosos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMorosos)).EndInit();
            this.tabCreditos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditos)).EndInit();
            this.panelPago.ResumeLayout(false);
            this.panelInfoPago.ResumeLayout(false);
            this.panelInfoPago.PerformLayout();
            this.panelMet.ResumeLayout(false);
            this.panelFilaPago.ResumeLayout(false);
            this.panelFilaPago.PerformLayout();
            this.panelCliente.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.Panel panelInfoPago;
        private System.Windows.Forms.Label lblInfoPago;
        private System.Windows.Forms.Panel spI;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Panel spT2;
        private System.Windows.Forms.Panel panelFilaPago;
        private System.Windows.Forms.ComboBox cboMetodo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Panel spM;
        private System.Windows.Forms.Panel panelMet;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Panel sp2;
        private System.Windows.Forms.ComboBox cboDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Panel sp1;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Panel spT;
        private System.Windows.Forms.Label lblTituloPago;
        private System.Windows.Forms.Panel spP;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEstadoCli;
        private System.Windows.Forms.Panel spC;
        private System.Windows.Forms.Button btnBuscarCli;
    }
}
