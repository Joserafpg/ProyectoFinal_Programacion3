using System;
using CapaEntidades;
using CapaNegocio;

namespace Pruebas
{
    public class PruebaCategorias
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE CATEGORIAS...");
            var negocio = new CategoriaNegocio();

            var error = negocio.Insertar(new Categoria { Nombre = "Suplementos", Descripcion = "Proteinas, creatina y vitaminas" });
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Categoria insertada." : "Aviso: " + error));

            foreach (var c in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + c.IdCategoria + " | " + c.Nombre + " | " + (c.Estado ? "Activa" : "Inactiva"));
            }
        }
    }
}
