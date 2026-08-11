using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCliente : Form
    {
        ClienteNegocio clienteNegocio = new ClienteNegocio();
        Cliente clienteEditar = null;
        byte[] foto = null;

        public FrmCliente()
        {
            InitializeComponent();
            txtNombre.KeyPress += Validaciones.SoloLetras;
            txtApellido.KeyPress += Validaciones.SoloLetras;
            txtCedula.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtTelefono.KeyPress += Validaciones.SoloNumerosYGuiones;
            btnDesactivar.Visible = false;
        }

        public FrmCliente(Cliente cliente) : this()
        {
            clienteEditar = cliente;

            Text = "Editar Cliente";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCedula.Text = cliente.Cedula;
            txtTelefono.Text = cliente.Telefono;
            txtCorreo.Text = cliente.Correo;
            txtDireccion.Text = cliente.Direccion;
            cboSexo.Text = cliente.Sexo;

            if (cliente.FechaNacimiento != null)
            {
                dtpFechaNacimiento.Checked = true;
                dtpFechaNacimiento.Value = cliente.FechaNacimiento.Value;
            }
            else
            {
                dtpFechaNacimiento.Checked = false;
            }

            if (cliente.Foto != null)
            {
                foto = cliente.Foto;
                picFoto.Image = Image.FromStream(new MemoryStream(foto));
            }

            btnDesactivar.Visible = true;
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Imagenes|*.jpg;*.jpeg;*.png";

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                foto = File.ReadAllBytes(buscador.FileName);
                picFoto.Image = Image.FromStream(new MemoryStream(foto));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (clienteEditar == null)
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Cedula = txtCedula.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Sexo = cboSexo.Text;
                cliente.FechaNacimiento = dtpFechaNacimiento.Checked ? dtpFechaNacimiento.Value : (DateTime?)null;
                cliente.Foto = foto;
                cliente.Estado = true;

                mensaje = clienteNegocio.Insertar(cliente);
            }
            else
            {
                clienteEditar.Nombre = txtNombre.Text;
                clienteEditar.Apellido = txtApellido.Text;
                clienteEditar.Cedula = txtCedula.Text;
                clienteEditar.Telefono = txtTelefono.Text;
                clienteEditar.Correo = txtCorreo.Text;
                clienteEditar.Direccion = txtDireccion.Text;
                clienteEditar.Sexo = cboSexo.Text;
                clienteEditar.FechaNacimiento = dtpFechaNacimiento.Checked ? dtpFechaNacimiento.Value : (DateTime?)null;
                clienteEditar.Foto = foto;

                mensaje = clienteNegocio.Actualizar(clienteEditar);
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
            if (MessageBox.Show("¿Está seguro de desactivar este cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = clienteNegocio.CambiarEstado(clienteEditar.IdCliente, false);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cliente desactivado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
