using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos
{
    public class Producto
    {
        public DateTime FechaCaducidad { get; set; }
        public int NumeroLote { get; set; }
        public DateTime FechaEnvasado { get; set; }
        public string PaisOrigen { get; set; }

        public Producto()
        {

        }
        public Producto(DateTime fechaCaducidad, int numeroLote)
        {
            FechaCaducidad = fechaCaducidad;
            NumeroLote = numeroLote;
        }
    }
}
