using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmProveedores : Form
    {
        ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
        ComboBox cboEstado;

        public FrmProveedores()
        {
            InitializeComponent();
            cboEstado = Filtros.AgregarEstado(panelBarra);
            cboEstado.SelectedIndexChanged += (s, e) => Cargar();
        }

        private void Cargar()
        {
            dgvDatos.DataSource = proveedorNegocio.Listar(txtBuscar.Text, Filtros.Estado(cboEstado));
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDatos, "Nombre", "Rnc=RNC", "Telefono=Teléfono", "Correo", "Direccion=Dirección", "Estado");
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProveedor dialogo = new FrmProveedor();
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

            Proveedor seleccionado = (Proveedor)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmProveedor dialogo = new FrmProveedor(seleccionado);
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
