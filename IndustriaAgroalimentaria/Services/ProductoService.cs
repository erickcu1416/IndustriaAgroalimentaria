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
        public static void ActualizarProducto()
        {
            Console.WriteLine("Actualizar producto");
            Producto producto = SelecionarProducto();
            if (producto != null)
            {
                var a = producto.GetType();
                Console.WriteLine(a.Name);
                switch (a.Name)
                {
                    case "ProductoCongeladoAire":
                        ProductoCongeladoAire productoCongeladoAire = new ProductoCongeladoAire();
                        productoCongeladoAire.Id = producto.Id; ;
                        productoCongeladoAire = LlenarProductoCongeladoAire(productoCongeladoAire);
                        using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
                        {
                            context.Update(productoCongeladoAire);
                            context.SaveChanges();
                            Console.WriteLine("Producto actualizado");
                        }
                        break;
                    case "ProductoCongeladoAgua":
                        ProductoCongeladoAgua productoCongeladoAgua = new ProductoCongeladoAgua();
                        productoCongeladoAgua.Id = producto.Id; ;
                        LlenarProductoCongeladoAgua(productoCongeladoAgua);
                        using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
                        {
                            context.Update(productoCongeladoAgua);
                            context.SaveChanges();
                            Console.WriteLine("Producto actualizado");
                        }
                        break;
                    case "ProductoCongeladoNitrogeno":
                        ProductoCongeladoNitrogeno productoCongeladoNitrogeno = new ProductoCongeladoNitrogeno();
                        productoCongeladoNitrogeno.Id = producto.Id; ;
                        LlenarProductoCongeladoNitrogeno(productoCongeladoNitrogeno);
                        using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
                        {
                            context.Update(productoCongeladoNitrogeno);
                            context.SaveChanges();
                            Console.WriteLine("Producto actualizado");
                        }
                        break;
                    case "ProductoFresco":
                        ProductoFresco productoFresco = new ProductoFresco();
                        productoFresco.Id = producto.Id; ;
                        LlenarProductoFresco(productoFresco);
                        using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
                        {
                            context.Update(productoFresco);
                            context.SaveChanges();
                            Console.WriteLine("Producto actualizado");
                        }
                        break;
                    case "ProductoRefrigerado":
                        ProductoRefrigerado productoRefrigerado = new ProductoRefrigerado();
                        productoRefrigerado.Id = producto.Id; ;
                        LlenarProductoRefrigerado(productoRefrigerado);
                        using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
                        {
                            context.Update(productoRefrigerado);
                            context.SaveChanges();
                            Console.WriteLine("Producto actualizado");
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public static void EliminarProducto()
        {
            Console.WriteLine("Eliminar producto");
            Producto producto = SelecionarProducto();
            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                context.Remove(producto);
                context.SaveChanges();
                Console.WriteLine("Producto eliminado");
            }
        }

        public static Producto SelecionarProducto()
        {
            BuscarProductos();
            uint id = Validators.isUnIntValidoConWriteLine("Seleciona el código de producto: "); 
            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                Producto producto = context.Productos.Find(id);
                if (producto == null)
                {
                    Console.WriteLine("El producto es incorrecto, por favor selecciona otro");
                    SelecionarProducto();
                }
                return producto;
            }
        }

        public static void BuscarProductos()
        {
            Console.WriteLine("\nBuscar prodcutos por numero de lote");
            string buscar = Validators.isStringValidoConWriteLine("Buscar: ");

            using (IndustriaAgroalimentariaContext context = new IndustriaAgroalimentariaContext())
            {
                IQueryable<Producto> productos = context.Productos.Where(p => p.NumeroLote.ToString().Contains(buscar));
                foreach (Producto producto in productos)
                {
                    Console.WriteLine(producto);
                }
            }
        }


        #region Productos
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
            productoRefrigerado.COSA = Validators.isStringValidoConWriteLine("Código del organismo de supervisión alimentaria:");
            productoRefrigerado.TemperaturaRecomendada = Validators.isStringValidoConWriteLine("Temperatura Recomendada:");
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

            productoCongeladoAgua.GSPLA = Validators.isDoubleValidoConWriteLine("Gramos de sal por litro de agua: ");

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

            productoCongeladoNitrogeno.PaisOrigen = Validators.isStringValidoConWriteLine("Pais Origen:");

            productoCongeladoNitrogeno.MetodoCongelacion = Validators.isStringValidoConWriteLine("Metodo de congelación: ");

            productoCongeladoNitrogeno.ENPS = Validators.isStringValidoConWriteLine("Exposición al nitrógeno expresada en segundos: ");
            return productoCongeladoNitrogeno;
        }

        #endregion
    }
}
