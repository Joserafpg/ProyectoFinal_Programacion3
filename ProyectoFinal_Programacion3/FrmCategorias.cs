using System;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCategorias : Form
    {
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = categoriaNegocio.Listar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }
    }
}
