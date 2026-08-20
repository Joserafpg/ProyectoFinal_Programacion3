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
            this.components = new System.ComponentModel.Container();
            this.panelEntrada = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.spT2 = new System.Windows.Forms.Panel();
            this.panelFila = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.spE2 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.spE1 = new System.Windows.Forms.Panel();
            this.panelTxt = new System.Windows.Forms.Panel();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCed = new System.Windows.Forms.Label();
            this.spT = new System.Windows.Forms.Panel();
            this.lblTituloEntrada = new System.Windows.Forms.Label();
            this.timerLimpiar = new System.Windows.Forms.Timer(this.components);
            this.panelEntrada.SuspendLayout();
            this.panelFila.SuspendLayout();
            this.panelTxt.SuspendLayout();
            this.SuspendLayout();
            //
            // panelEntrada
            //
            this.panelEntrada.BackColor = System.Drawing.Color.White;
            this.panelEntrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEntrada.Controls.Add(this.lblResultado);
            this.panelEntrada.Controls.Add(this.spT2);
            this.panelEntrada.Controls.Add(this.panelFila);
            this.panelEntrada.Controls.Add(this.spT);
            this.panelEntrada.Controls.Add(this.lblTituloEntrada);
            this.panelEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntrada.Location = new System.Drawing.Point(32, 25);
            this.panelEntrada.Name = "panelEntrada";
            this.panelEntrada.Padding = new System.Windows.Forms.Padding(27, 16, 27, 16);
            this.panelEntrada.Size = new System.Drawing.Size(1323, 165);
            this.panelEntrada.TabIndex = 0;
            //
            // lblResultado
            //
            this.lblResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblResultado.Location = new System.Drawing.Point(27, 115);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(1267, 32);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spT2
            //
            this.spT2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spT2.Location = new System.Drawing.Point(27, 107);
            this.spT2.Name = "spT2";
            this.spT2.Size = new System.Drawing.Size(1267, 8);
            this.spT2.TabIndex = 0;
            //
            // panelFila
            //
            this.panelFila.Controls.Add(this.btnBuscarCliente);
            this.panelFila.Controls.Add(this.spE2);
            this.panelFila.Controls.Add(this.btnRegistrar);
            this.panelFila.Controls.Add(this.spE1);
            this.panelFila.Controls.Add(this.panelTxt);
            this.panelFila.Controls.Add(this.lblCed);
            this.panelFila.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFila.Location = new System.Drawing.Point(27, 52);
            this.panelFila.Name = "panelFila";
            this.panelFila.Size = new System.Drawing.Size(1267, 55);
            this.panelFila.TabIndex = 1;
            //
            // btnBuscarCliente
            //
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnBuscarCliente.Image = global::ProyectoFinal_Programacion3.Properties.Resources.icono_buscar;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(626, 0);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBuscarCliente.Size = new System.Drawing.Size(230, 55);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            //
            // spE2
            //
            this.spE2.Dock = System.Windows.Forms.DockStyle.Left;
            this.spE2.Location = new System.Drawing.Point(613, 0);
            this.spE2.Name = "spE2";
            this.spE2.Size = new System.Drawing.Size(13, 55);
            this.spE2.TabIndex = 0;
            //
            // btnRegistrar
            //
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnRegistrar.Location = new System.Drawing.Point(393, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(220, 55);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar entrada";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            //
            // spE1
            //
            this.spE1.Dock = System.Windows.Forms.DockStyle.Left;
            this.spE1.Location = new System.Drawing.Point(380, 0);
            this.spE1.Name = "spE1";
            this.spE1.Size = new System.Drawing.Size(13, 55);
            this.spE1.TabIndex = 0;
            //
            // panelTxt
            //
            this.panelTxt.Controls.Add(this.txtCedula);
            this.panelTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTxt.Location = new System.Drawing.Point(80, 0);
            this.panelTxt.Name = "panelTxt";
            this.panelTxt.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panelTxt.Size = new System.Drawing.Size(300, 55);
            this.panelTxt.TabIndex = 0;
            //
            // txtCedula
            //
            this.txtCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtCedula.Location = new System.Drawing.Point(0, 8);
            this.txtCedula.MaxLength = 13;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(300, 39);
            this.txtCedula.TabIndex = 0;
            //
            // lblCed
            //
            this.lblCed.AutoSize = true;
            this.lblCed.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblCed.Location = new System.Drawing.Point(0, 0);
            this.lblCed.Name = "lblCed";
            this.lblCed.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblCed.Size = new System.Drawing.Size(80, 55);
            this.lblCed.TabIndex = 0;
            this.lblCed.Text = "Cédula:";
            this.lblCed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // spT
            //
            this.spT.Dock = System.Windows.Forms.DockStyle.Top;
            this.spT.Location = new System.Drawing.Point(27, 44);
            this.spT.Name = "spT";
            this.spT.Size = new System.Drawing.Size(1267, 8);
            this.spT.TabIndex = 0;
            //
            // lblTituloEntrada
            //
            this.lblTituloEntrada.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTituloEntrada.Location = new System.Drawing.Point(27, 16);
            this.lblTituloEntrada.Name = "lblTituloEntrada";
            this.lblTituloEntrada.Size = new System.Drawing.Size(1267, 28);
            this.lblTituloEntrada.TabIndex = 0;
            this.lblTituloEntrada.Text = "Registrar entrada · escriba su cédula y presione Enter";
            this.lblTituloEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // timerLimpiar
            //
            this.timerLimpiar.Interval = 6000;
            //
            // FrmCheckIn
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1387, 807);
            this.Controls.Add(this.panelEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCheckIn";
            this.Padding = new System.Windows.Forms.Padding(32, 25, 32, 30);
            this.Text = "Check-in";
            this.panelEntrada.ResumeLayout(false);
            this.panelFila.ResumeLayout(false);
            this.panelFila.PerformLayout();
            this.panelTxt.ResumeLayout(false);
            this.panelTxt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEntrada;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel spT2;
        private System.Windows.Forms.Panel panelFila;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Panel spE2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel spE1;
        private System.Windows.Forms.Panel panelTxt;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCed;
        private System.Windows.Forms.Panel spT;
        private System.Windows.Forms.Label lblTituloEntrada;
        private System.Windows.Forms.Timer timerLimpiar;
    }
}
