using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmProveedor : Form
    {
        ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
        Proveedor proveedorEditar = null;

        public FrmProveedor()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            txtRnc.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtTelefono.KeyPress += Validaciones.SoloNumerosYGuiones;
            btnDesactivar.Visible = false;
        }

        public FrmProveedor(Proveedor proveedor) : this()
        {
            proveedorEditar = proveedor;

            Text = "Editar Proveedor";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = proveedor.Nombre;
            txtRnc.Text = proveedor.Rnc;
            txtTelefono.Text = proveedor.Telefono;
            txtCorreo.Text = proveedor.Correo;
            txtDireccion.Text = proveedor.Direccion;

            btnDesactivar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (proveedorEditar == null)
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Nombre = txtNombre.Text;
                proveedor.Rnc = txtRnc.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Correo = txtCorreo.Text;
                proveedor.Direccion = txtDireccion.Text;
                proveedor.Estado = true;

                mensaje = proveedorNegocio.Insertar(proveedor);
            }
            else
            {
                proveedorEditar.Nombre = txtNombre.Text;
                proveedorEditar.Rnc = txtRnc.Text;
                proveedorEditar.Telefono = txtTelefono.Text;
                proveedorEditar.Correo = txtCorreo.Text;
                proveedorEditar.Direccion = txtDireccion.Text;

                mensaje = proveedorNegocio.Actualizar(proveedorEditar);
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
            if (MessageBox.Show("¿Está seguro de desactivar este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = proveedorNegocio.CambiarEstado(proveedorEditar.IdProveedor, false);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Proveedor desactivado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
