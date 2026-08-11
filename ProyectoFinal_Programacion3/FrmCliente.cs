using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            txtNombre.KeyPress += Validaciones.SoloLetras;
            txtApellido.KeyPress += Validaciones.SoloLetras;
            txtCedula.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtTelefono.KeyPress += Validaciones.SoloNumerosYGuiones;
        }



    }
}
