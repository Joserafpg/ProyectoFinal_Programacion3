using System;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCheckIn : Form
    {
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        ClienteMembresiaNegocio clienteMembresiaNegocio = new ClienteMembresiaNegocio();
        PagoNegocio pagoNegocio = new PagoNegocio();

        public FrmCheckIn()
        {
            InitializeComponent();
            Load += FrmCheckIn_Load;
            btnCobrarVisita.Click += btnCobrarVisita_Click;
            btnExplorar.Click += btnExplorar_Click;
            dgvMorosos.CellDoubleClick += dgvMorosos_CellDoubleClick;
        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            lblVisita.Text = "Dar acceso sin membresía · Visita del día: RD$" + pagoNegocio.ObtenerMontoVisita().ToString("N2");
            cboMetodoVisita.SelectedIndex = 0;
            CargarMorosos();
        }

        private void CargarMorosos()
        {
            dgvMorosos.DataSource = clienteMembresiaNegocio.ListarVencidas();

            string[] visibles = { "Cliente", "Cedula", "Membresia", "FechaFin" };
            foreach (DataGridViewColumn columna in dgvMorosos.Columns)
            {
                columna.Visible = visibles.Contains(columna.Name);
            }

            if (dgvMorosos.Columns.Contains("Cedula"))
            {
                dgvMorosos.Columns["Cedula"].HeaderText = "Cédula";
            }

            if (dgvMorosos.Columns.Contains("Membresia"))
            {
                dgvMorosos.Columns["Membresia"].HeaderText = "Último plan";
            }

            if (dgvMorosos.Columns.Contains("FechaFin"))
            {
                dgvMorosos.Columns["FechaFin"].HeaderText = "Venció el";
                dgvMorosos.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            dgvMorosos.ClearSelection();
        }

        private void dgvMorosos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            ClienteMembresia vencida = (ClienteMembresia)dgvMorosos.Rows[e.RowIndex].DataBoundItem;
            Cliente cliente = clienteNegocio.ObtenerPorCedula(vencida.Cedula);

            if (cliente == null) return;

            FrmClienteDetalle detalle = new FrmClienteDetalle(cliente);
            detalle.ShowDialog(this);
            CargarMorosos();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente buscador = new FrmBuscarCliente();
            buscador.ModoExplorar = true;
            buscador.ShowDialog(this);
            CargarMorosos();
        }

        private void btnCobrarVisita_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("Debe iniciar sesión para cobrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = pagoNegocio.CobrarVisita(cboMetodoVisita.Text, Sesion.UsuarioActual.IdUsuario);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Visita cobrada. Puede pasar.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
