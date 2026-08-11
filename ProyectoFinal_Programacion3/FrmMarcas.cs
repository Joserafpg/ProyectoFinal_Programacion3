using System;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmMarcas : Form
    {
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = marcaNegocio.Listar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }
    }
}
