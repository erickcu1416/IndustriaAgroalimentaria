using IndustriaAgroalimentaria.Helpers;
using IndustriaAgroalimentaria.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Application
{
    public static class Application
    {
        public static void App()
        {
            UsuarioService.InitUsers();
            bool existUser = false;
            while (!existUser)
            {
                existUser = UsuarioService.Login();
            }

            Menu();
        }

        public static void Menu()
        {
            string opcion = "";
            while (opcion.Equals("")) { opcion = MostrarOpcionesDeMenu(); }

            switch (opcion)
            {
                case "1":
                    MenuProducto();
                    break;
                case "2":
                    //CrearProducto();
                    break;
                case "0": return;
            }

            Menu();
        }

        public static void MenuProducto()
        {
            string opcion = "";
            while (opcion.Equals("")) { opcion = MostrarOpcionesDeProducto(); }

            switch (opcion)
            {
                case "1":
                    //MenuProducto();
                    break;
                case "2":
                    ProductoService.CrearProductoFresco();
                    break;
                case "3":
                    ProductoService.CrearProductoRefrigerado();
                    break;
                case "4":
                    ProductoService.CrearProductoCongeladoAgua();
                    break;
                case "5":
                    ProductoService.CrearProductoCongeladoAire();
                    break;
                case "6":
                    ProductoService.CrearProductoCongeladoNitrogeno();
                    break;
                case "7":
                    ProductoService.CrearProductoCongeladoAgua();
                    break;
                case "0": return;
            }

            MenuProducto();
        }


        public static string MostrarOpcionesDeMenu()
        {
            string opcion = "";
            bool validOption = false;
            while (!validOption)
            {
                Console.WriteLine("\n---Menu Principal---");
                Console.WriteLine("1) Productos");
                Console.WriteLine("2) Ventas");
                Console.WriteLine("0) Salir");
                opcion = Console.ReadLine();
                validOption = Validators.isOpcionValida(opcion, 2);
            }
            return opcion;
        }

        public static string MostrarOpcionesDeProducto()
        {
            string opcion = "";
            bool validOption = false;
            while (!validOption)
            {
                Console.WriteLine("\n---Producto---");
                Console.WriteLine("1) Buscar producto");
                Console.WriteLine("2) Crear producto Fresco");
                Console.WriteLine("3) Crear producto Refrigerado");
                Console.WriteLine("4) Crear producto Congelado por Agua");
                Console.WriteLine("5) Crear producto Congelado por Aire");
                Console.WriteLine("6) Crear producto Congelado por Nitrogeno");
                Console.WriteLine("7) Actualizar producto");
                Console.WriteLine("8) Eliminar producto");
                Console.WriteLine("0) Regresar");
                opcion = Console.ReadLine();
                validOption = Validators.isOpcionValida(opcion, 8);
            }
            return opcion;
        }


    }
}
