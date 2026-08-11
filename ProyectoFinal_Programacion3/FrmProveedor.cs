using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
            txtRnc.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtTelefono.KeyPress += Validaciones.SoloNumerosYGuiones;
        }


    }
}
