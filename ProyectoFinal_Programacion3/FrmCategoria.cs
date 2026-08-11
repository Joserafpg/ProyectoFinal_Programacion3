using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCategoria : Form
    {
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        Categoria categoriaEditar = null;

        public FrmCategoria()
        {
            InitializeComponent();
            btnDesactivar.Visible = false;
        }

        public FrmCategoria(Categoria categoria) : this()
        {
            categoriaEditar = categoria;

            Text = "Editar Categoria";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = categoriaEditar.Nombre;
            txtDescripcion.Text = categoriaEditar.Descripcion;

            btnDesactivar.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
