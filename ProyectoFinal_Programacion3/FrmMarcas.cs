using CapaEntidades;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmMarcas : Form
    {
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        ComboBox cboEstado;

        public FrmMarcas()
        {
            InitializeComponent();
            cboEstado = Filtros.AgregarEstado(panelBarra);
            cboEstado.SelectedIndexChanged += (s, e) => Cargar();
        }

        private void Cargar()
        {
            dgvDatos.DataSource = marcaNegocio.Listar(txtBuscar.Text, Filtros.Estado(cboEstado));
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDatos, "Nombre", "Estado");
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmMarca dialogo = new FrmMarca();
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

            Marca seleccionada = (Marca)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmMarca dialogo = new FrmMarca(seleccionada);
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
