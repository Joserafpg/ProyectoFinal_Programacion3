using System;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            txtNombreCompleto.KeyPress += Validaciones.SoloLetras;
        }


    }
}
