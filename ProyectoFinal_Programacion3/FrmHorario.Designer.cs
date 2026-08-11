namespace ProyectoFinal_Programacion3
{
    partial class FrmHorario
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
            this.panelCamposDialogo = new System.Windows.Forms.Panel();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.spBoton = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.spBoton2 = new System.Windows.Forms.Panel();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.spNombre = new System.Windows.Forms.Panel();
            this.lblDiaDesde = new System.Windows.Forms.Label();
            this.cboDiaDesde = new System.Windows.Forms.ComboBox();
            this.spDiaDesde = new System.Windows.Forms.Panel();
            this.lblDiaHasta = new System.Windows.Forms.Label();
            this.cboDiaHasta = new System.Windows.Forms.ComboBox();
            this.spDiaHasta = new System.Windows.Forms.Panel();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.spHoraInicio = new System.Windows.Forms.Panel();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.spHoraFin = new System.Windows.Forms.Panel();
            this.panelCamposDialogo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCamposDialogo
            // 
            this.panelCamposDialogo.AutoScroll = true;
            this.panelCamposDialogo.Controls.Add(this.spHoraFin);
            this.panelCamposDialogo.Controls.Add(this.dtpHoraFin);
            this.panelCamposDialogo.Controls.Add(this.lblHoraFin);
            this.panelCamposDialogo.Controls.Add(this.spHoraInicio);
            this.panelCamposDialogo.Controls.Add(this.dtpHoraInicio);
            this.panelCamposDialogo.Controls.Add(this.lblHoraInicio);
            this.panelCamposDialogo.Controls.Add(this.spDiaHasta);
            this.panelCamposDialogo.Controls.Add(this.cboDiaHasta);
            this.panelCamposDialogo.Controls.Add(this.lblDiaHasta);
            this.panelCamposDialogo.Controls.Add(this.spDiaDesde);
            this.panelCamposDialogo.Controls.Add(this.cboDiaDesde);
            this.panelCamposDialogo.Controls.Add(this.lblDiaDesde);
            this.panelCamposDialogo.Controls.Add(this.spNombre);
            this.panelCamposDialogo.Controls.Add(this.txtNombre);
            this.panelCamposDialogo.Controls.Add(this.lblNombre);
            this.panelCamposDialogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamposDialogo.Name = "panelCamposDialogo";
            this.panelCamposDialogo.Size = new System.Drawing.Size(372, 276);
            this.panelCamposDialogo.TabIndex = 0;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnDesactivar);
            this.panelBotones.Controls.Add(this.spBoton2);
            this.panelBotones.Controls.Add(this.btnCancelar);
            this.panelBotones.Controls.Add(this.spBoton);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panelBotones.Size = new System.Drawing.Size(372, 146);
            this.panelBotones.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(211)))), ((int)(((byte)(77)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(372, 42);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // spBoton
            // 
            this.spBoton.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton.Name = "spBoton";
            this.spBoton.Size = new System.Drawing.Size(372, 10);
            this.spBoton.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(372, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // spBoton2
            // 
            this.spBoton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spBoton2.Name = "spBoton2";
            this.spBoton2.Size = new System.Drawing.Size(372, 8);
            this.spBoton2.TabIndex = 0;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesactivar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnDesactivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(372, 38);
            this.btnDesactivar.TabIndex = 0;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblNombre.Size = new System.Drawing.Size(60, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Size = new System.Drawing.Size(372, 25);
            this.txtNombre.TabIndex = 1;
            // 
            // spNombre
            // 
            this.spNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.spNombre.Name = "spNombre";
            this.spNombre.Size = new System.Drawing.Size(372, 14);
            this.spNombre.TabIndex = 0;
            //
            // lblDiaDesde
            //
            this.lblDiaDesde.AutoSize = true;
            this.lblDiaDesde.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiaDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiaDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDiaDesde.Name = "lblDiaDesde";
            this.lblDiaDesde.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblDiaDesde.Size = new System.Drawing.Size(60, 20);
            this.lblDiaDesde.TabIndex = 0;
            this.lblDiaDesde.Text = "Desde el día";
            //
            // cboDiaDesde
            //
            this.cboDiaDesde.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboDiaDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiaDesde.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDiaDesde.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cboDiaDesde.Name = "cboDiaDesde";
            this.cboDiaDesde.Size = new System.Drawing.Size(372, 28);
            this.cboDiaDesde.TabIndex = 2;
            //
            // spDiaDesde
            //
            this.spDiaDesde.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDiaDesde.Name = "spDiaDesde";
            this.spDiaDesde.Size = new System.Drawing.Size(372, 14);
            this.spDiaDesde.TabIndex = 0;
            //
            // lblDiaHasta
            //
            this.lblDiaHasta.AutoSize = true;
            this.lblDiaHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiaHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiaHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblDiaHasta.Name = "lblDiaHasta";
            this.lblDiaHasta.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblDiaHasta.Size = new System.Drawing.Size(60, 20);
            this.lblDiaHasta.TabIndex = 0;
            this.lblDiaHasta.Text = "Hasta el día";
            //
            // cboDiaHasta
            //
            this.cboDiaHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboDiaHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiaHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDiaHasta.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cboDiaHasta.Name = "cboDiaHasta";
            this.cboDiaHasta.Size = new System.Drawing.Size(372, 28);
            this.cboDiaHasta.TabIndex = 3;
            //
            // spDiaHasta
            //
            this.spDiaHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.spDiaHasta.Name = "spDiaHasta";
            this.spDiaHasta.Size = new System.Drawing.Size(372, 14);
            this.spDiaHasta.TabIndex = 0;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoraInicio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHoraInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblHoraInicio.Size = new System.Drawing.Size(60, 20);
            this.lblHoraInicio.TabIndex = 0;
            this.lblHoraInicio.Text = "Hora de inicio";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpHoraInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.Size = new System.Drawing.Size(372, 25);
            this.dtpHoraInicio.TabIndex = 4;
            // 
            // spHoraInicio
            // 
            this.spHoraInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.spHoraInicio.Name = "spHoraInicio";
            this.spHoraInicio.Size = new System.Drawing.Size(372, 14);
            this.spHoraInicio.TabIndex = 0;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoraFin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHoraFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblHoraFin.Size = new System.Drawing.Size(60, 20);
            this.lblHoraFin.TabIndex = 0;
            this.lblHoraFin.Text = "Hora de fin";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpHoraFin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.Size = new System.Drawing.Size(372, 25);
            this.dtpHoraFin.TabIndex = 5;
            // 
            // spHoraFin
            // 
            this.spHoraFin.Dock = System.Windows.Forms.DockStyle.Top;
            this.spHoraFin.Name = "spHoraFin";
            this.spHoraFin.Size = new System.Drawing.Size(372, 14);
            this.spHoraFin.TabIndex = 0;
            // 
            // FrmHorario
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(420, 522);
            this.Controls.Add(this.panelCamposDialogo);
            this.Controls.Add(this.panelBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHorario";
            this.Padding = new System.Windows.Forms.Padding(24, 12, 24, 18);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Horario";
            this.panelCamposDialogo.ResumeLayout(false);
            this.panelCamposDialogo.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCamposDialogo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel spBoton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel spBoton2;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel spNombre;
        private System.Windows.Forms.Label lblDiaDesde;
        private System.Windows.Forms.ComboBox cboDiaDesde;
        private System.Windows.Forms.Panel spDiaDesde;
        private System.Windows.Forms.Label lblDiaHasta;
        private System.Windows.Forms.ComboBox cboDiaHasta;
        private System.Windows.Forms.Panel spDiaHasta;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Panel spHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Panel spHoraFin;
    }
}

