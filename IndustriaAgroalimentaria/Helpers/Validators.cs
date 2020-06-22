using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Helpers
{
    public static class Validators
    {
        public static int isIntValidoConWriteLine(string mensaje)
        {
            int result = 0;
            do
            {
                Console.Write(mensaje);
                string dato = Console.ReadLine();
                try
                {
                    result = Int32.Parse(dato);
                }
                catch (FormatException)
                {
                    Console.Write("Por favor, ingrese un dato correcto \n");
                    result = 0;
                }
            } while (result == 0);
            return result;
        }

        public static double isDoubleValidoConWriteLine(string mensaje)
        {
            double result = 0;
            do
            {
                Console.Write(mensaje);
                string dato = Console.ReadLine();
                try
                {
                    result = Double.Parse(dato);
                }
                catch (FormatException)
                {
                    Console.Write("Por favor, ingrese un dato correcto \n");
                    result = 0;
                }
            } while (result == 0);
            return result;
        }

        public static string isStringValidoConWriteLine(string mensaje)
        {
            string result = "";
            do
            {
                Console.Write(mensaje);
                string dato = Console.ReadLine();
                if (String.IsNullOrEmpty(result))
                {
                    Console.Write("Por favor, ingrese un dato correcto \n");
                }
                else
                {
                    result = dato;
                }
            } while (result == "");
            return result;
        }

        public static bool isOpcionValida(string opcion, int maxOpc)
        {
            string errormsg = $"La opción '{opcion}' es invalida";
            try
            {
                int result = Int32.Parse(opcion);
                if (result >= 0 && result <= maxOpc)
                {
                    //Console.WriteLine("La opción es correcta");
                    return true;
                }
                else
                {
                    Console.WriteLine(errormsg);
                    return false;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(errormsg);
                return false;
            }
        }
    }
}
