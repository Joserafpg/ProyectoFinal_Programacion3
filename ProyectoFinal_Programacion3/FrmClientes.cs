using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmClientes : Form
    {
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        ComboBox cboEstado;
        ComboBox cboMembresia;

        public FrmClientes()
        {
            InitializeComponent();
            cboEstado = Filtros.AgregarEstado(panelBarra);
            cboMembresia = Filtros.AgregarCombo(panelBarra, "Membresía:", 150, "Todas", "Al día", "Vencida", "Sin membresía");
            cboEstado.SelectedIndexChanged += (s, e) => Cargar();
            cboMembresia.SelectedIndexChanged += (s, e) => Cargar();
        }

        private void Cargar()
        {
            dgvDatos.DataSource = clienteNegocio.Listar(txtBuscar.Text, Filtros.Estado(cboEstado), cboMembresia.Text);
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDatos, "Nombre", "Apellido", "Cedula=Cédula", "Telefono=Teléfono", "Correo", "Sexo", "FechaNacimiento=Nacimiento", "EstadoMembresia=Membresía", "Estado");
            dgvDatos.Columns["FechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCliente dialogo = new FrmCliente();
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

            Cliente seleccionado = (Cliente)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmClienteDetalle detalle = new FrmClienteDetalle(seleccionado);
            if (detalle.ShowDialog(this) == DialogResult.OK)
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
