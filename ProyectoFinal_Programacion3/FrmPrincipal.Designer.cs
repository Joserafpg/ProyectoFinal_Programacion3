namespace ProyectoFinal_Programacion3
{
    partial class FrmPrincipal
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelMenuScroll = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnSubConfiguracion = new System.Windows.Forms.Button();
            this.btnSubUsuarios = new System.Windows.Forms.Button();
            this.btnSubClases = new System.Windows.Forms.Button();
            this.btnSubHorarios = new System.Windows.Forms.Button();
            this.btnSubEntrenadores = new System.Windows.Forms.Button();
            this.btnSubProveedores = new System.Windows.Forms.Button();
            this.btnSubMarcas = new System.Windows.Forms.Button();
            this.btnSubCategorias = new System.Windows.Forms.Button();
            this.btnMantenimientos = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnMembresias = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblSeccionMenu = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogoMenu = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lineaSidebar = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.btnCerrarApp = new System.Windows.Forms.Label();
            this.btnMinimizarApp = new System.Windows.Forms.Label();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            this.lblTituloPagina = new System.Windows.Forms.Label();
            this.lineaSuperior = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelMenuScroll.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            //
            // panelSidebar
            //
            this.panelSidebar.BackColor = System.Drawing.Color.White;
            this.panelSidebar.Controls.Add(this.panelMenuScroll);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Controls.Add(this.btnCerrarSesion);
            this.panelSidebar.Controls.Add(this.lineaSidebar);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 720);
            this.panelSidebar.TabIndex = 0;
            //
            // panelMenuScroll
            //
            this.panelMenuScroll.AutoScroll = true;
            this.panelMenuScroll.BackColor = System.Drawing.Color.White;
            this.panelMenuScroll.Controls.Add(this.panelSubMenu);
            this.panelMenuScroll.Controls.Add(this.btnMantenimientos);
            this.panelMenuScroll.Controls.Add(this.btnProductos);
            this.panelMenuScroll.Controls.Add(this.btnMembresias);
            this.panelMenuScroll.Controls.Add(this.btnClientes);
            this.panelMenuScroll.Controls.Add(this.btnPos);
            this.panelMenuScroll.Controls.Add(this.btnInicio);
            this.panelMenuScroll.Controls.Add(this.lblSeccionMenu);
            this.panelMenuScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuScroll.Location = new System.Drawing.Point(0, 96);
            this.panelMenuScroll.Name = "panelMenuScroll";
            this.panelMenuScroll.Size = new System.Drawing.Size(239, 574);
            this.panelMenuScroll.TabIndex = 11;
            //
            // lineaSidebar
            //
            this.lineaSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.lineaSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lineaSidebar.Location = new System.Drawing.Point(239, 0);
            this.lineaSidebar.Name = "lineaSidebar";
            this.lineaSidebar.Size = new System.Drawing.Size(1, 700);
            this.lineaSidebar.TabIndex = 0;
            //
            // panelLogo
            //
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.lblLogoMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(239, 96);
            this.panelLogo.TabIndex = 1;
            //
            // lblLogoMenu
            //
            this.lblLogoMenu.AutoSize = true;
            this.lblLogoMenu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblLogoMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblLogoMenu.Location = new System.Drawing.Point(24, 32);
            this.lblLogoMenu.Name = "lblLogoMenu";
            this.lblLogoMenu.Size = new System.Drawing.Size(157, 28);
            this.lblLogoMenu.TabIndex = 0;
            this.lblLogoMenu.Text = "🏋️ SmartFit";
            //
            // lblSeccionMenu
            //
            this.lblSeccionMenu.BackColor = System.Drawing.Color.White;
            this.lblSeccionMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSeccionMenu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSeccionMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(163)))), ((int)(((byte)(189)))));
            this.lblSeccionMenu.Location = new System.Drawing.Point(0, 96);
            this.lblSeccionMenu.Name = "lblSeccionMenu";
            this.lblSeccionMenu.Padding = new System.Windows.Forms.Padding(26, 8, 0, 0);
            this.lblSeccionMenu.Size = new System.Drawing.Size(239, 30);
            this.lblSeccionMenu.TabIndex = 2;
            this.lblSeccionMenu.Text = "M E N Ú";
            //
            // btnInicio
            //
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(138)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(230)))), ((int)(((byte)(138)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(63)))), ((int)(((byte)(22)))));
            this.btnInicio.Location = new System.Drawing.Point(0, 126);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(239, 44);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = false;
            //
            // btnPos
            //
            this.btnPos.BackColor = System.Drawing.Color.White;
            this.btnPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnPos.Location = new System.Drawing.Point(0, 170);
            this.btnPos.Name = "btnPos";
            this.btnPos.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnPos.Size = new System.Drawing.Size(239, 44);
            this.btnPos.TabIndex = 4;
            this.btnPos.Text = "Punto de venta";
            this.btnPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPos.UseVisualStyleBackColor = false;
            //
            // btnClientes
            //
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnClientes.Location = new System.Drawing.Point(0, 214);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(239, 44);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            //
            // btnMembresias
            //
            this.btnMembresias.BackColor = System.Drawing.Color.White;
            this.btnMembresias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembresias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembresias.FlatAppearance.BorderSize = 0;
            this.btnMembresias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnMembresias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembresias.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnMembresias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnMembresias.Location = new System.Drawing.Point(0, 258);
            this.btnMembresias.Name = "btnMembresias";
            this.btnMembresias.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnMembresias.Size = new System.Drawing.Size(239, 44);
            this.btnMembresias.TabIndex = 6;
            this.btnMembresias.Text = "Membresías";
            this.btnMembresias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembresias.UseVisualStyleBackColor = false;
            //
            // btnProductos
            //
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnProductos.Location = new System.Drawing.Point(0, 302);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(239, 44);
            this.btnProductos.TabIndex = 7;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            //
            // btnMantenimientos
            //
            this.btnMantenimientos.BackColor = System.Drawing.Color.White;
            this.btnMantenimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimientos.FlatAppearance.BorderSize = 0;
            this.btnMantenimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnMantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnMantenimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnMantenimientos.Location = new System.Drawing.Point(0, 346);
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnMantenimientos.Size = new System.Drawing.Size(239, 44);
            this.btnMantenimientos.TabIndex = 8;
            this.btnMantenimientos.Text = "Mantenimientos   ▾";
            this.btnMantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimientos.UseVisualStyleBackColor = false;
            //
            // panelSubMenu
            //
            this.panelSubMenu.BackColor = System.Drawing.Color.White;
            this.panelSubMenu.Controls.Add(this.btnSubConfiguracion);
            this.panelSubMenu.Controls.Add(this.btnSubUsuarios);
            this.panelSubMenu.Controls.Add(this.btnSubClases);
            this.panelSubMenu.Controls.Add(this.btnSubHorarios);
            this.panelSubMenu.Controls.Add(this.btnSubEntrenadores);
            this.panelSubMenu.Controls.Add(this.btnSubProveedores);
            this.panelSubMenu.Controls.Add(this.btnSubMarcas);
            this.panelSubMenu.Controls.Add(this.btnSubCategorias);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 390);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(239, 304);
            this.panelSubMenu.TabIndex = 9;
            //
            // btnSubCategorias
            //
            this.btnSubCategorias.BackColor = System.Drawing.Color.White;
            this.btnSubCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubCategorias.FlatAppearance.BorderSize = 0;
            this.btnSubCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSubCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCategorias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.btnSubCategorias.Location = new System.Drawing.Point(0, 0);
            this.btnSubCategorias.Name = "btnSubCategorias";
            this.btnSubCategorias.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnSubCategorias.Size = new System.Drawing.Size(239, 38);
            this.btnSubCategorias.TabIndex = 0;
            this.btnSubCategorias.Text = "Categorías";
            this.btnSubCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCategorias.UseVisualStyleBackColor = false;
            //
            // btnSubMarcas
            //
            this.btnSubMarcas.BackColor = System.Drawing.Color.White;
            this.btnSubMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMarcas.FlatAppearance.BorderSize = 0;
            this.btnSubMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSubMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMarcas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubMarcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.btnSubMarcas.Location = new System.Drawing.Point(0, 38);
            this.btnSubMarcas.Name = "btnSubMarcas";
            this.btnSubMarcas.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnSubMarcas.Size = new System.Drawing.Size(239, 38);
            this.btnSubMarcas.TabIndex = 1;
            this.btnSubMarcas.Text = "Marcas";
            this.btnSubMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMarcas.UseVisualStyleBackColor = false;
            //
            // btnSubProveedores
            //
            this.btnSubProveedores.BackColor = System.Drawing.Color.White;
            this.btnSubProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubProveedores.FlatAppearance.BorderSize = 0;
            this.btnSubProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSubProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProveedores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.btnSubProveedores.Location = new System.Drawing.Point(0, 76);
            this.btnSubProveedores.Name = "btnSubProveedores";
            this.btnSubProveedores.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnSubProveedores.Size = new System.Drawing.Size(239, 38);
            this.btnSubProveedores.TabIndex = 2;
            this.btnSubProveedores.Text = "Proveedores";
            this.btnSubProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProveedores.UseVisualStyleBackColor = false;
            //
            // btnSubEntrenadores
            //
            this.btnSubEntrenadores.BackColor = System.Drawing.Color.White;
            this.btnSubEntrenadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubEntrenadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEntrenadores.FlatAppearance.BorderSize = 0;
            this.btnSubEntrenadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSubEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEntrenadores.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubEntrenadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.btnSubEntrenadores.Location = new System.Drawing.Point(0, 114);
            this.btnSubEntrenadores.Name = "btnSubEntrenadores";
            this.btnSubEntrenadores.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnSubEntrenadores.Size = new System.Drawing.Size(239, 38);
            this.btnSubEntrenadores.TabIndex = 3;
            this.btnSubEntrenadores.Text = "Entrenadores";
            this.btnSubEntrenadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEntrenadores.UseVisualStyleBackColor = false;
            //
            // btnSubHorarios
            //
            this.btnSubHorarios.BackColor = System.Drawing.Color.White;
            this.btnSubHorarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubHorarios.FlatAppearance.BorderSize = 0;
            this.btnSubHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSubHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubHorarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubHorarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.btnSubHorarios.Location = new System.Drawing.Point(0, 152);
            this.btnSubHorarios.Name = "btnSubHorarios";
            this.btnSubHorarios.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnSubHorarios.Size = new System.Drawing.Size(239, 38);
            this.btnSubHorarios.TabIndex = 4;
            this.btnSubHorarios.Text = "Horarios";
            this.btnSubHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubHorarios.UseVisualStyleBackColor = false;
            //
            // btnSubClases
            //
            this.btnSubClases.BackColor = System.Drawing.Color.White;
            this.btnSubClases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubClases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubClases.FlatAppearance.BorderSize = 0;
            this.btnSubClases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSubClases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubClases.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubClases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.btnSubClases.Location = new System.Drawing.Point(0, 190);
            this.btnSubClases.Name = "btnSubClases";
            this.btnSubClases.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnSubClases.Size = new System.Drawing.Size(239, 38);
            this.btnSubClases.TabIndex = 5;
            this.btnSubClases.Text = "Clases y reservas";
            this.btnSubClases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubClases.UseVisualStyleBackColor = false;
            //
            // btnSubUsuarios
            //
            this.btnSubUsuarios.BackColor = System.Drawing.Color.White;
            this.btnSubUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubUsuarios.FlatAppearance.BorderSize = 0;
            this.btnSubUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSubUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.btnSubUsuarios.Location = new System.Drawing.Point(0, 228);
            this.btnSubUsuarios.Name = "btnSubUsuarios";
            this.btnSubUsuarios.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnSubUsuarios.Size = new System.Drawing.Size(239, 38);
            this.btnSubUsuarios.TabIndex = 6;
            this.btnSubUsuarios.Text = "Usuarios y roles";
            this.btnSubUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubUsuarios.UseVisualStyleBackColor = false;
            //
            // btnSubConfiguracion
            //
            this.btnSubConfiguracion.BackColor = System.Drawing.Color.White;
            this.btnSubConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnSubConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSubConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubConfiguracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.btnSubConfiguracion.Location = new System.Drawing.Point(0, 266);
            this.btnSubConfiguracion.Name = "btnSubConfiguracion";
            this.btnSubConfiguracion.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.btnSubConfiguracion.Size = new System.Drawing.Size(239, 38);
            this.btnSubConfiguracion.TabIndex = 7;
            this.btnSubConfiguracion.Text = "Configuración";
            this.btnSubConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubConfiguracion.UseVisualStyleBackColor = false;
            //
            // btnCerrarSesion
            //
            this.btnCerrarSesion.BackColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 650);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(239, 50);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            //
            // panelSuperior
            //
            this.panelSuperior.BackColor = System.Drawing.Color.White;
            this.panelSuperior.Controls.Add(this.lblUsuarioActual);
            this.panelSuperior.Controls.Add(this.lblTituloPagina);
            this.panelSuperior.Controls.Add(this.btnMinimizarApp);
            this.panelSuperior.Controls.Add(this.btnCerrarApp);
            this.panelSuperior.Controls.Add(this.lineaSuperior);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(240, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(960, 64);
            this.panelSuperior.TabIndex = 1;
            //
            // lineaSuperior
            //
            this.lineaSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.lineaSuperior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lineaSuperior.Location = new System.Drawing.Point(0, 63);
            this.lineaSuperior.Name = "lineaSuperior";
            this.lineaSuperior.Size = new System.Drawing.Size(960, 1);
            this.lineaSuperior.TabIndex = 2;
            //
            // btnCerrarApp
            //
            this.btnCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarApp.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCerrarApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(140)))));
            this.btnCerrarApp.Location = new System.Drawing.Point(992, 0);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(48, 63);
            this.btnCerrarApp.TabIndex = 3;
            this.btnCerrarApp.Text = "✕";
            this.btnCerrarApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnMinimizarApp
            //
            this.btnMinimizarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizarApp.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnMinimizarApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(124)))), ((int)(((byte)(140)))));
            this.btnMinimizarApp.Location = new System.Drawing.Point(948, 0);
            this.btnMinimizarApp.Name = "btnMinimizarApp";
            this.btnMinimizarApp.Size = new System.Drawing.Size(44, 63);
            this.btnMinimizarApp.TabIndex = 4;
            this.btnMinimizarApp.Text = "—";
            this.btnMinimizarApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblUsuarioActual
            //
            this.lblUsuarioActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioActual.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblUsuarioActual.Location = new System.Drawing.Point(500, 22);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(330, 20);
            this.lblUsuarioActual.TabIndex = 1;
            this.lblUsuarioActual.Text = "usuario · rol";
            this.lblUsuarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblTituloPagina
            //
            this.lblTituloPagina.AutoSize = true;
            this.lblTituloPagina.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblTituloPagina.Location = new System.Drawing.Point(28, 16);
            this.lblTituloPagina.Name = "lblTituloPagina";
            this.lblTituloPagina.Size = new System.Drawing.Size(60, 25);
            this.lblTituloPagina.TabIndex = 0;
            this.lblTituloPagina.Text = "Inicio";
            //
            // panelContenido
            //
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(253)))));
            this.panelContenido.Controls.Add(this.lblBienvenida);
            this.panelContenido.Controls.Add(this.lblRol);
            this.panelContenido.Controls.Add(this.lblNota);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(240, 64);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(960, 636);
            this.panelContenido.TabIndex = 2;
            //
            // lblBienvenida
            //
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.lblBienvenida.Location = new System.Drawing.Point(44, 48);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(166, 37);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido";
            //
            // lblRol
            //
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(158)))));
            this.lblRol.Location = new System.Drawing.Point(46, 96);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 20);
            this.lblRol.TabIndex = 1;
            this.lblRol.Text = "Rol:";
            //
            // lblNota
            //
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(163)))), ((int)(((byte)(189)))));
            this.lblNota.Location = new System.Drawing.Point(46, 140);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(380, 19);
            this.lblNota.TabIndex = 2;
            this.lblNota.Text = "Selecciona un módulo del menú para comenzar a trabajar";
            //
            // FrmPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartFit Software";
            this.panelSidebar.ResumeLayout(false);
            this.panelMenuScroll.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMenuScroll;
        private System.Windows.Forms.Panel lineaSidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogoMenu;
        private System.Windows.Forms.Label lblSeccionMenu;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMembresias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnMantenimientos;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnSubCategorias;
        private System.Windows.Forms.Button btnSubMarcas;
        private System.Windows.Forms.Button btnSubProveedores;
        private System.Windows.Forms.Button btnSubEntrenadores;
        private System.Windows.Forms.Button btnSubHorarios;
        private System.Windows.Forms.Button btnSubClases;
        private System.Windows.Forms.Button btnSubUsuarios;
        private System.Windows.Forms.Button btnSubConfiguracion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTituloPagina;
        private System.Windows.Forms.Label lblUsuarioActual;
        private System.Windows.Forms.Label btnCerrarApp;
        private System.Windows.Forms.Label btnMinimizarApp;
        private System.Windows.Forms.Panel lineaSuperior;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNota;
    }
}
