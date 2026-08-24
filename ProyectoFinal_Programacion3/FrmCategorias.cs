using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCategorias : Form
    {
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        ComboBox cboEstado;

        public FrmCategorias()
        {
            InitializeComponent();
            cboEstado = Filtros.AgregarEstado(panelBarra);
            cboEstado.SelectedIndexChanged += (s, e) => Cargar();
        }

        private void Cargar()
        {
            dgvDatos.DataSource = categoriaNegocio.Listar(txtBuscar.Text, Filtros.Estado(cboEstado));
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDatos, "Nombre", "Descripcion=Descripción", "Estado");
            dgvDatos.ClearSelection();
            dgvDatos.CurrentCell = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCategoria dialogo = new FrmCategoria();
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

            Categoria seleccionada = (Categoria)dgvDatos.Rows[e.RowIndex].DataBoundItem;
            FrmCategoria dialogo = new FrmCategoria(seleccionada);
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
