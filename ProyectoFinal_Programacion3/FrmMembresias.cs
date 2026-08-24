using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmMembresias : Form
    {
        MembresiaNegocio membresiaNegocio = new MembresiaNegocio();
        ComboBox cboEstado;

        public FrmMembresias()
        {
            InitializeComponent();
            cboEstado = Filtros.AgregarEstado(panelBarra);
            cboEstado.SelectedIndexChanged += (s, e) => Cargar();
        }

        private void Cargar()
        {
            dgvDatos.DataSource = membresiaNegocio.Listar(txtBuscar.Text, Filtros.Estado(cboEstado));
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDatos, "Nombre", "Descripcion=Descripción", "DuracionDias=Duración (días)", "Precio", "Estado");
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void FrmMembresias_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMembresia dialogo = new FrmMembresia();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                Cargar();
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Membresia seleccionado = (Membresia)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmMembresia dialogo = new FrmMembresia(seleccionado);
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                Cargar();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
