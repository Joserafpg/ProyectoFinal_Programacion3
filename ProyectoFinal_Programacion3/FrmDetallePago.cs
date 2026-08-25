using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmDetallePago : Form
    {
        Pago pago;

        public FrmDetallePago()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;
            Load += FrmDetallePago_Load;
            dgvDetalle.DataBindingComplete += dgvDetalle_DataBindingComplete;
        }

        public FrmDetallePago(Pago pagoSeleccionado) : this()
        {
            pago = pagoSeleccionado;
        }

        private void FrmDetallePago_Load(object sender, EventArgs e)
        {
            if (pago == null) return;

            Text = "Pago #" + pago.IdPago;
            lblResumen.Text = pago.Cliente + " · " + pago.Fecha.ToString("dd/MM/yyyy hh:mm tt") + " · " + pago.MetodoPago
                + " · Total: RD$" + pago.MontoTotal.ToString("N2") + " · Cobrado por " + pago.Usuario;

            dgvDetalle.DataSource = new PagoNegocio().ListarDetalle(pago.IdPago);
        }

        private void dgvDetalle_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDetalle, "Concepto", "Monto");

            if (dgvDetalle.Columns.Contains("Monto"))
            {
                dgvDetalle.Columns["Concepto"].FillWeight = 250;
                dgvDetalle.Columns["Monto"].FillWeight = 80;
                dgvDetalle.Columns["Monto"].DefaultCellStyle.Format = "N2";
            }

            dgvDetalle.ClearSelection();
        }
    }
}
