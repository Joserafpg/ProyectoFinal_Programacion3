using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmMembresia : Form
    {
        public FrmMembresia()
        {
            InitializeComponent();
            txtDuracionDias.KeyPress += Validaciones.SoloNumeros;
            txtPrecio.KeyPress += Validaciones.SoloDecimales;
        }



    }
}
