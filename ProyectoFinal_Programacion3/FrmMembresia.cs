using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmMembresia : Form
    {
        MembresiaNegocio membresiaNegocio = new MembresiaNegocio();
        Membresia membresiaEditar = null;

        public FrmMembresia()
        {
            InitializeComponent();
            txtDuracionDias.KeyPress += Validaciones.SoloNumeros;
            txtPrecio.KeyPress += Validaciones.SoloDecimales;
            btnDesactivar.Visible = false;
        }

        public FrmMembresia(Membresia membresia) : this()
        {
            membresiaEditar = membresia;

            Text = "Editar Membresía";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = membresia.Nombre;
            txtDescripcion.Text = membresia.Descripcion;
            txtDuracionDias.Text = membresia.DuracionDias.ToString();
            txtPrecio.Text = membresia.Precio.ToString();

            btnDesactivar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDuracionDias.Text, out int duracion))
            {
                MessageBox.Show("La duración debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje;

            if (membresiaEditar == null)
            {
                Membresia membresia = new Membresia();
                membresia.Nombre = txtNombre.Text;
                membresia.Descripcion = txtDescripcion.Text;
                membresia.DuracionDias = duracion;
                membresia.Precio = precio;
                membresia.Estado = true;

                mensaje = membresiaNegocio.Insertar(membresia);
            }
            else
            {
                membresiaEditar.Nombre = txtNombre.Text;
                membresiaEditar.Descripcion = txtDescripcion.Text;
                membresiaEditar.DuracionDias = duracion;
                membresiaEditar.Precio = precio;

                mensaje = membresiaNegocio.Actualizar(membresiaEditar);
            }

            if (mensaje.Length > 0)
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

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de desactivar esta membresía?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = membresiaNegocio.CambiarEstado(membresiaEditar.IdMembresia, false);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Membresía desactivada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
