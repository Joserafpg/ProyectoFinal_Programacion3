using System;
using CapaEntidades;
using CapaNegocio;

namespace Pruebas
{
    public class PruebaProductos
    {
        public static void Ejecutar()
        {
            Console.WriteLine();
            Console.WriteLine("[" + DateTime.Now + "] INICIANDO PRUEBAS DE PRODUCTOS...");
            var negocio = new ProductoNegocio();

            var categorias = new CategoriaNegocio().Listar();
            var marcas = new MarcaNegocio().Listar();
            if (categorias.Count == 0 || marcas.Count == 0)
            {
                Console.WriteLine("[" + DateTime.Now + "] Faltan categorias o marcas, no se puede probar.");
                return;
            }

            var error = negocio.Insertar(new Producto
            {
                Codigo = "P001",
                CodigoBarras = "7501234567890",
                Nombre = "Proteina Whey 5lb",
                Descripcion = "Proteina de suero sabor chocolate",
                IdCategoria = categorias[0].IdCategoria,
                IdMarca = marcas[0].IdMarca,
                PrecioCompra = 2500,
                PrecioVenta = 3500,
                Stock = 10,
                StockMinimo = 2
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (error == "" ? "Producto insertado." : "Aviso: " + error));

            var invalido = negocio.Insertar(new Producto
            {
                Codigo = "P002",
                Nombre = "Producto perdida",
                IdCategoria = categorias[0].IdCategoria,
                IdMarca = marcas[0].IdMarca,
                PrecioCompra = 1000,
                PrecioVenta = 500
            });
            Console.WriteLine("[" + DateTime.Now + "] " + (invalido != "" ? "Producto invalido rechazado: " + invalido : "ERROR: acepto vender por debajo del costo!"));

            foreach (var p in negocio.Listar())
            {
                Console.WriteLine("[" + DateTime.Now + "] " + p.Codigo + " | " + p.Nombre + " | " + p.NombreCategoria + " | " + p.NombreMarca + " | RD$" + p.PrecioVenta + " | Stock: " + p.Stock);
            }
        }
    }
}
