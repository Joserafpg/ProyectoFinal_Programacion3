using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmMarca : Form
    {
        MarcaNegocio marcaNegocio = new MarcaNegocio();
        Marca marcaeditar = null;
        public FrmMarca()
        {
            InitializeComponent();
            btnDesactivar.Visible = false;
        }

        public FrmMarca(Marca marca): this()
        {
            marcaeditar = marca;

            Text = "Editar Marca";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = marca.Nombre;

            btnDesactivar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if(marcaeditar != null)
            {
                marcaeditar.Nombre = txtNombre.Text;
                mensaje = marcaNegocio.Actualizar(marcaeditar);
                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Marca actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                return;
            }
            else
            {
                Marca marca = new Marca();
                marca.Nombre = txtNombre.Text;
                marca.Estado = true;

                mensaje = marcaNegocio.Insertar(marca);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Marca guardada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de desactivar esta marca?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = marcaNegocio.CambiarEstado(marcaeditar.IdMarca, false);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Marca desactivada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
