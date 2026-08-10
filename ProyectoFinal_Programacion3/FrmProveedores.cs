using System;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmProveedores : Form
    {
        ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = proveedorNegocio.Listar();
        }
    }
}

