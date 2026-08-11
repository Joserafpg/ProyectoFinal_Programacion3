using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmEntrenador : Form
    {
        public FrmEntrenador()
        {
            InitializeComponent();
            txtNombre.KeyPress += Validaciones.SoloLetras;
            txtApellido.KeyPress += Validaciones.SoloLetras;
            txtCedula.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtTelefono.KeyPress += Validaciones.SoloNumerosYGuiones;
            txtEspecialidad.KeyPress += Validaciones.SoloLetras;
        }



    }
}
