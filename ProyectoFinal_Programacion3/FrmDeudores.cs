using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmDeudores : Form
    {
        PagoNegocio pagoNegocio = new PagoNegocio();
        ClienteNegocio clienteNegocio = new ClienteNegocio();

        List<Deudor> deudores = new List<Deudor>();
        ComboBox cboTipo;
        TextBox txtBuscar;

        // si el usuario da doble click a un deudor, aqui queda el cliente para cobrarle
        public Cliente ClienteSeleccionado = null;

        public FrmDeudores()
        {
            InitializeComponent();
            Icon = Properties.Resources.icono_app;

            Panel barra = new Panel { Dock = DockStyle.Top, Height = 54 };
            Controls.Add(barra);
            cboTipo = Filtros.AgregarCombo(barra, "Deuda:", 210, "Todas", "Con crédito", "Con visitas sin pagar", "Membresía vencida");
            txtBuscar = Filtros.AgregarTexto(barra, "Buscar:", 240);

            Load += FrmDeudores_Load;
            dgvDeudores.DataBindingComplete += dgvDeudores_DataBindingComplete;
            dgvDeudores.CellDoubleClick += dgvDeudores_CellDoubleClick;
            btnRecordatorio.Click += btnRecordatorio_Click;
            btnCerrar.Click += btnCerrar_Click;
        }

        private void FrmDeudores_Load(object sender, EventArgs e)
        {
            deudores = pagoNegocio.ListarDeudores();
            Filtrar();

            cboTipo.SelectedIndexChanged += (s, a) => Filtrar();
            txtBuscar.TextChanged += (s, a) => Filtrar();
        }

        private void Filtrar()
        {
            IEnumerable<Deudor> lista = deudores;

            switch (cboTipo.SelectedIndex)
            {
                case 1: lista = lista.Where(d => d.Credito > 0); break;
                case 2: lista = lista.Where(d => d.VisitasPendientes > 0); break;
                case 3: lista = lista.Where(d => d.UltimoVencimiento != null && d.UltimoVencimiento.Value < DateTime.Today); break;
            }

            string texto = txtBuscar.Text.Trim().ToLower();

            if (texto.Length > 0)
            {
                lista = lista.Where(d => d.Cliente.ToLower().Contains(texto) || d.Cedula.Contains(texto));
            }

            var filtrados = lista.ToList();
            dgvDeudores.DataSource = filtrados;

            decimal total = filtrados.Sum(d => d.Total);
            int conDinero = filtrados.Count(d => d.Total > 0);
            int soloVencidos = filtrados.Count - conDinero;

            lblTotal.Text = filtrados.Count == 0
                ? "Nadie debe nada."
                : conDinero + " cliente(s) deben RD$" + total.ToString("N2")
                  + (soloVencidos > 0 ? "   ·   " + soloVencidos + " más solo tienen la membresía vencida" : "");
        }

        private void dgvDeudores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Columnas.Mostrar(dgvDeudores, "Cliente", "Cedula=Cédula", "Credito=Crédito", "VisitasPendientes=Visitas", "MontoVisitas=Monto visitas", "Membresia=Membresía", "Total");

            if (dgvDeudores.Columns.Contains("Total"))
            {
                dgvDeudores.Columns["Cliente"].FillWeight = 140;
                dgvDeudores.Columns["Cedula"].FillWeight = 90;
                dgvDeudores.Columns["Credito"].FillWeight = 70;
                dgvDeudores.Columns["Credito"].DefaultCellStyle.Format = "N2";
                dgvDeudores.Columns["VisitasPendientes"].FillWeight = 50;
                dgvDeudores.Columns["MontoVisitas"].FillWeight = 80;
                dgvDeudores.Columns["MontoVisitas"].DefaultCellStyle.Format = "N2";
                dgvDeudores.Columns["Membresia"].FillWeight = 200;
                dgvDeudores.Columns["Total"].FillWeight = 70;
                dgvDeudores.Columns["Total"].DefaultCellStyle.Format = "N2";
                dgvDeudores.Columns["Total"].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            }

            dgvDeudores.ClearSelection();
            dgvDeudores.CurrentCell = null;
        }

        private void dgvDeudores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Deudor deudor = (Deudor)dgvDeudores.Rows[e.RowIndex].DataBoundItem;
            Cliente encontrado = clienteNegocio.ObtenerPorCedula(deudor.Cedula);
            if (encontrado == null) return;

            ClienteSeleccionado = encontrado;
            DialogResult = DialogResult.OK;
            Close();
        }

        private async void btnRecordatorio_Click(object sender, EventArgs e)
        {
            Deudor deudor = dgvDeudores.CurrentRow == null
                ? null
                : dgvDeudores.CurrentRow.DataBoundItem as Deudor;

            if (deudor == null)
            {
                MessageBox.Show("Seleccione un cliente para enviarle el recordatorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cliente = clienteNegocio.ObtenerPorCedula(deudor.Cedula);
            if (cliente == null || string.IsNullOrWhiteSpace(cliente.Correo))
            {
                MessageBox.Show("Este cliente no tiene un correo electrónico registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resumen = deudor.Total > 0 ? "RD$" + deudor.Total.ToString("N2") : "su membresía vencida";
            if (MessageBox.Show("¿Enviar a " + cliente.Correo + " un recordatorio por " + resumen + "?", "Confirmar envío", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            btnRecordatorio.Enabled = false;
            btnRecordatorio.Text = "Enviando...";
            string error = await new CorreoBienvenidaNegocio().EnviarRecordatorioAsync(cliente, deudor);
            btnRecordatorio.Enabled = true;
            btnRecordatorio.Text = "Enviar recordatorio";

            if (error.Length > 0)
                MessageBox.Show(error, "No se pudo enviar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Recordatorio enviado a " + cliente.Correo + ".", "Correo enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
