using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // cualquier error que no se haya capturado en su lugar se muestra aqui y la aplicacion sigue viva
            Application.ThreadException += (sender, e) => MostrarError(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) => MostrarError(e.ExceptionObject as Exception);

            Application.Run(new FrmLogin());
        }

        static void MostrarError(Exception ex)
        {
            string mensaje = ex is System.Data.SqlClient.SqlException
                ? "No se pudo completar la operación en la base de datos.\n\nVerifique que SQL Server esté corriendo y vuelva a intentar.\n\nDetalle: " + ex.Message
                : "Ocurrió un error inesperado.\n\nDetalle: " + ex.Message;

            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
