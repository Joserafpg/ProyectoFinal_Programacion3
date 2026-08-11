using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmClase : Form
    {
        ClaseNegocio claseNegocio = new ClaseNegocio();
        Clase claseEditar = null;

        public FrmClase()
        {
            InitializeComponent();
            txtCupoMaximo.KeyPress += Validaciones.SoloNumeros;

            cboEntrenador.DataSource = new EntrenadorNegocio().Listar();
            cboEntrenador.DisplayMember = "NombreCompleto";
            cboEntrenador.ValueMember = "IdEntrenador";

            btnDesactivar.Visible = false;
        }

        public FrmClase(Clase clase) : this()
        {
            claseEditar = clase;

            Text = "Editar Clase";
            btnGuardar.Text = "Actualizar";

            txtNombre.Text = clase.Nombre;
            txtDescripcion.Text = clase.Descripcion;
            cboDiaSemana.Text = clase.DiaSemana;
            dtpHoraInicio.Value = DateTime.Today.Add(clase.HoraInicio);
            dtpHoraFin.Value = DateTime.Today.Add(clase.HoraFin);
            txtCupoMaximo.Text = clase.CupoMaximo.ToString();
            cboEntrenador.SelectedValue = clase.IdEntrenador;

            btnDesactivar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboDiaSemana.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el día de la semana.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboEntrenador.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un entrenador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCupoMaximo.Text, out int cupo))
            {
                MessageBox.Show("El cupo debe ser un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje;

            if (claseEditar == null)
            {
                Clase clase = new Clase();
                clase.Nombre = txtNombre.Text;
                clase.Descripcion = txtDescripcion.Text;
                clase.DiaSemana = cboDiaSemana.Text;
                clase.HoraInicio = dtpHoraInicio.Value.TimeOfDay;
                clase.HoraFin = dtpHoraFin.Value.TimeOfDay;
                clase.CupoMaximo = cupo;
                clase.IdEntrenador = (int)cboEntrenador.SelectedValue;
                clase.Estado = true;

                mensaje = claseNegocio.Insertar(clase);
            }
            else
            {
                claseEditar.Nombre = txtNombre.Text;
                claseEditar.Descripcion = txtDescripcion.Text;
                claseEditar.DiaSemana = cboDiaSemana.Text;
                claseEditar.HoraInicio = dtpHoraInicio.Value.TimeOfDay;
                claseEditar.HoraFin = dtpHoraFin.Value.TimeOfDay;
                claseEditar.CupoMaximo = cupo;
                claseEditar.IdEntrenador = (int)cboEntrenador.SelectedValue;

                mensaje = claseNegocio.Actualizar(claseEditar);
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
            if (MessageBox.Show("¿Está seguro de desactivar esta clase?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = claseNegocio.CambiarEstado(claseEditar.IdClase, false);

                if (mensaje.Length > 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Clase desactivada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
