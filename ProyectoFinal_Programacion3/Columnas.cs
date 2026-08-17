using System.Windows.Forms;

namespace ProyectoFinal_Programacion3
{
    // helper para los datagridview: deja visibles solo las columnas indicadas, en ese orden.
    // cada entrada puede ser "Propiedad" o "Propiedad=Titulo" para cambiar el encabezado
    public static class Columnas
    {
        public static void Mostrar(DataGridView dgv, params string[] visibles)
        {
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                columna.Visible = false;
            }

            for (int i = 0; i < visibles.Length; i++)
            {
                string[] partes = visibles[i].Split('=');
                string nombre = partes[0];

                if (!dgv.Columns.Contains(nombre)) continue;

                dgv.Columns[nombre].Visible = true;
                dgv.Columns[nombre].DisplayIndex = i;

                if (partes.Length > 1)
                {
                    dgv.Columns[nombre].HeaderText = partes[1];
                }
            }
        }
    }
}
