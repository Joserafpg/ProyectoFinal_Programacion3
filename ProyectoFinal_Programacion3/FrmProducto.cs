using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            txtCodigoBarras.KeyPress += Validaciones.SoloNumeros;
            txtPrecioCompra.KeyPress += Validaciones.SoloDecimales;
            txtPrecioVenta.KeyPress += Validaciones.SoloDecimales;
            txtStock.KeyPress += Validaciones.SoloNumeros;
            txtStockMinimo.KeyPress += Validaciones.SoloNumeros;
        }



    }
}
