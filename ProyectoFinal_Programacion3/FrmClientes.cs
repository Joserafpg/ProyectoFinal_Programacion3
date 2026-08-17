using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmClientes : Form
    {

        ClienteNegocio clienteNegocio = new ClienteNegocio();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = clienteNegocio.Listar(txtBuscar.Text);
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDatos, "Nombre", "Apellido", "Cedula=Cédula", "Telefono=Teléfono", "Correo", "Sexo", "FechaNacimiento=Nacimiento", "Estado");
            dgvDatos.Columns["FechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCliente dialogo = new FrmCliente();
            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = clienteNegocio.Listar(txtBuscar.Text);
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Cliente seleccionado = (Cliente)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmClienteDetalle detalle = new FrmClienteDetalle(seleccionado);
            if (detalle.ShowDialog(this) == DialogResult.OK)
            {
                dgvDatos.DataSource = clienteNegocio.Listar(txtBuscar.Text);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = clienteNegocio.Listar(txtBuscar.Text);
        }
    }
}
