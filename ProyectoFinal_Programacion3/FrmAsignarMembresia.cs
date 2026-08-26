using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmAsignarMembresia : Form
    {
        ClienteMembresiaNegocio clienteMembresiaNegocio = new ClienteMembresiaNegocio();
        Cliente cliente;
        List<Membresia> planes = new List<Membresia>();

        public FrmAsignarMembresia()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            Load += FrmAsignarMembresia_Load;
            cboPlan.SelectedIndexChanged += cboPlan_SelectedIndexChanged;
            btnCobrar.Click += btnCobrar_Click;
        }

        public FrmAsignarMembresia(Cliente clienteSeleccionado) : this()
        {
            cliente = clienteSeleccionado;
        }

        private void FrmAsignarMembresia_Load(object sender, EventArgs e)
        {
            if (cliente == null) return;

            lblClienteNombre.Text = cliente.NombreCompleto;

            var activa = clienteMembresiaNegocio.ObtenerActiva(cliente.IdCliente);

            if (activa != null)
            {
                lblMembresiaActual.Text = "Membresía actual: " + activa.Membresia + " (vence el " + activa.FechaFin.ToString("dd/MM/yyyy") + "). El plan que elija empieza al vencer esta.";
            }
            else
            {
                var ultima = clienteMembresiaNegocio.ObtenerUltima(cliente.IdCliente);
                lblMembresiaActual.Text = ultima == null
                    ? "Sin membresía"
                    : "Membresía vencida el " + ultima.FechaFin.ToString("dd/MM/yyyy");
            }

            planes = new MembresiaNegocio().Listar().Where(m => m.Estado).ToList();
            cboPlan.DataSource = planes;
            cboPlan.DisplayMember = "Nombre";
            cboPlan.ValueMember = "IdMembresia";

            cboMetodoPago.SelectedIndex = 0;
            ActualizarResumen();
        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarResumen();
        }

        private void ActualizarResumen()
        {
            Membresia plan = cboPlan.SelectedItem as Membresia;
            if (plan == null) return;

            DateTime inicio = DateTime.Today;

            var activa = clienteMembresiaNegocio.ObtenerActiva(cliente.IdCliente);
            if (activa != null)
            {
                inicio = activa.FechaFin.AddDays(1);
            }

            DateTime fin = inicio.AddDays(plan.DuracionDias - 1);

            lblPrecio.Text = "Precio: RD$" + plan.Precio.ToString("N2");
            lblVigencia.Text = "Vigencia: " + inicio.ToString("dd/MM/yyyy") + " al " + fin.ToString("dd/MM/yyyy");
            btnCobrar.Text = "Cobrar RD$" + plan.Precio.ToString("N2");
        }

        private async void btnCobrar_Click(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("Debe iniciar sesión para cobrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Membresia plan = cboPlan.SelectedItem as Membresia;

            string mensaje = clienteMembresiaNegocio.Asignar(cliente, plan, cboMetodoPago.Text, Sesion.UsuarioActual.IdUsuario);

            if (mensaje.Length > 0)
            {
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var items = new List<PagoPendiente>
                {
                    new PagoPendiente
                    {
                        Tipo = "Membresía",
                        Concepto = "Membresía " + plan.Nombre + " (" + plan.DuracionDias + " días)",
                        Monto = plan.Precio,
                        Membresia = plan
                    }
                };
                string errorCorreo = await new CorreoBienvenidaNegocio().EnviarReciboPagoAsync(cliente, items, cboMetodoPago.Text);
                if (CorreoBienvenidaNegocio.FueOmitido(errorCorreo))
                    MessageBox.Show("Pago registrado. Membresía asignada correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (errorCorreo.Length > 0)
                    MessageBox.Show("Pago registrado y membresía asignada, pero no se pudo enviar el recibo: " + errorCorreo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Pago registrado, membresía asignada y recibo enviado a " + cliente.Correo + ".", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
