using IndustriaAgroalimentaria.DAO;
using IndustriaAgroalimentaria.Helpers;
using IndustriaAgroalimentaria.Modelos;
using IndustriaAgroalimentaria.Modelos.ProductosCongelados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndustriaAgroalimentaria.Services
{
    public static class ProductoService
    {
        public static void CrearProductoFresco()
        {
            Console.WriteLine("Crear producto");
            ProductoFresco productoFresco = new ProductoFresco();
            productoFresco = LlenarProductoFresco(productoFresco);

            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                context.Add(productoFresco);
                context.SaveChanges();
                Console.WriteLine("Producto creado");
            }
        }

        public static ProductoFresco LlenarProductoFresco(ProductoFresco productoFresco)
        {
            productoFresco.FechaCaducidad = DateTime.Now;
            productoFresco.FechaEnvasado = DateTime.Now;
            productoFresco.NumeroLote = Validators.isIntValidoConWriteLine("Numero de Lote: ");
            productoFresco.PaisOrigen = Validators.isStringValidoConWriteLine("Pais Origen:");
            return productoFresco;
        }

        public static void CrearProductoRefrigerado()
        {
            Console.WriteLine("Crear producto");
            ProductoRefrigerado productoRefrigerado = new ProductoRefrigerado();
            productoRefrigerado = LlenarProductoRefrigerado(productoRefrigerado);

            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                context.Add(productoRefrigerado);
                context.SaveChanges();
                Console.WriteLine("Producto creado\n");
            }
        }

        public static ProductoRefrigerado LlenarProductoRefrigerado(ProductoRefrigerado productoRefrigerado)
        {
            productoRefrigerado.FechaCaducidad = DateTime.Now;
            productoRefrigerado.FechaEnvasado = DateTime.Now;
            productoRefrigerado.NumeroLote = Validators.isIntValidoConWriteLine("Numero de Lote: ");
            productoRefrigerado.PaisOrigen = Validators.isStringValidoConWriteLine("Pais Origen:");
            Console.Write("Código del organismo de supervisión alimentaria: ");
            productoRefrigerado.COSA = Console.ReadLine();
            Console.Write("Temperatura Recomendada: ");
            productoRefrigerado.TemperaturaRecomendada = Console.ReadLine();
            return productoRefrigerado;
        }

        public static void ListarProductos()
        {
            Console.WriteLine("Listar productos");

            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                List<Producto> productos = context.Productos.ToList();
                foreach (Producto producto in productos)
                {
                    Console.WriteLine(producto);
                }
            }
        }
        public static void CrearProductoCongeladoAire()
        {
            Console.WriteLine("Crear producto");
            ProductoCongeladoAire productoCongeladoAire = new ProductoCongeladoAire();
            productoCongeladoAire = LlenarProductoCongeladoAire(productoCongeladoAire);

            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                context.Add(productoCongeladoAire);
                context.SaveChanges();
                Console.WriteLine("Producto creado");
            }
        }

        public static ProductoCongeladoAire LlenarProductoCongeladoAire(ProductoCongeladoAire productoCongeladoAire)
        {
            productoCongeladoAire.FechaCaducidad = DateTime.Now;
            productoCongeladoAire.FechaEnvasado = DateTime.Now;
            productoCongeladoAire.NumeroLote = Validators.isIntValidoConWriteLine("Numero de Lote: ");

            productoCongeladoAire.PaisOrigen = Validators.isStringValidoConWriteLine("Pais Origen:");

            productoCongeladoAire.PorcentajeNitrogeno = Validators.isDoubleValidoConWriteLine("Porcentaje Nitrogeno: ");

            productoCongeladoAire.PorcentajeDioxidoCarbono = Validators.isDoubleValidoConWriteLine("Porcentaje Dioxido de Carbono: ");

            productoCongeladoAire.PorcentajeVaporAgua = Validators.isDoubleValidoConWriteLine("Porcentaje Vapor Agua:  ");

            productoCongeladoAire.PorcentajeOxigeno = Validators.isDoubleValidoConWriteLine("Porcentaje Oxigeno: ");

            return productoCongeladoAire;
        }

        public static void CrearProductoCongeladoAgua()
        {
            Console.WriteLine("Crear producto");
            ProductoCongeladoAgua productoCongeladoAgua= new ProductoCongeladoAgua();
            productoCongeladoAgua = LlenarProductoCongeladoAgua(productoCongeladoAgua);

            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                context.Add(productoCongeladoAgua);
                context.SaveChanges();
                Console.WriteLine("Producto creado");
            }
        }

        public static ProductoCongeladoAgua LlenarProductoCongeladoAgua(ProductoCongeladoAgua productoCongeladoAgua)
        {
            productoCongeladoAgua.FechaCaducidad = DateTime.Now;
            productoCongeladoAgua.FechaEnvasado = DateTime.Now;
            productoCongeladoAgua.NumeroLote = Validators.isIntValidoConWriteLine("Numero de Lote: ");

            productoCongeladoAgua.PaisOrigen = Validators.isStringValidoConWriteLine("Pais Origen:");

            Console.Write("Gramos de sal por litro de agua: ");
            productoCongeladoAgua.GSPLA = double.Parse(Console.ReadLine());

            return productoCongeladoAgua;
        }

        public static void CrearProductoCongeladoNitrogeno()
        {
            Console.WriteLine("Crear producto");
            ProductoCongeladoNitrogeno productoCongeladoNitrogeno = new ProductoCongeladoNitrogeno();
            productoCongeladoNitrogeno = LlenarProductoCongeladoNitrogeno(productoCongeladoNitrogeno);

            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                context.Add(productoCongeladoNitrogeno);
                context.SaveChanges();
                Console.WriteLine("Producto creado");
            }
        }

        private static ProductoCongeladoNitrogeno LlenarProductoCongeladoNitrogeno(ProductoCongeladoNitrogeno productoCongeladoNitrogeno)
        {
            productoCongeladoNitrogeno.FechaCaducidad = DateTime.Now;
            productoCongeladoNitrogeno.FechaEnvasado = DateTime.Now;
            productoCongeladoNitrogeno.NumeroLote = Validators.isIntValidoConWriteLine("Numero de Lote: ");

            Console.Write("Pais Origen: ");
            productoCongeladoNitrogeno.PaisOrigen = Console.ReadLine();

            Console.Write("Metodo de congelación: ");
            productoCongeladoNitrogeno.MetodoCongelacion = Console.ReadLine();

            Console.Write("Exposición al nitrógeno expresada en segundos: ");
            productoCongeladoNitrogeno.ENPS = Console.ReadLine();
            return productoCongeladoNitrogeno;
        }
    }
}
