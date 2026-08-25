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
            Icon = Properties.Resources.icono_app;
            txtNombre.KeyPress += Validaciones.SoloLetras;
            btnDesactivar.Visible = false;
        }

        public FrmCategoria(Categoria categoria) : this()
        {
            categoriaEditar = categoria;

            Text = "Editar Categoria";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = categoriaEditar.Nombre;
            txtDescripcion.Text = categoriaEditar.Descripcion;

            btnDesactivar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (categoriaEditar == null)
            {
                Categoria categoria = new Categoria();
                categoria.Nombre = txtNombre.Text;
                categoria.Descripcion = txtDescripcion.Text;
                categoria.Estado = true;

                mensaje = categoriaNegocio.Insertar(categoria);
            }
            else {
                categoriaEditar.Nombre = txtNombre.Text;
                categoriaEditar.Descripcion = txtDescripcion.Text;

                mensaje = categoriaNegocio.Actualizar(categoriaEditar);
            }

            if (mensaje.Length > 0) 
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operacion realizada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (MessageBox.Show("¿Está seguro de desactivar esta categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mensaje = categoriaNegocio.CambiarEstado(categoriaEditar.IdCategoria, false);
                if(mensaje.Length > 0 )
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Operacion realizada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
