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

        public Producto(DateTime fechaCaducidad, int numeroLote, DateTime fechaEnvasado, string paisOrigen)
        {
            FechaCaducidad = fechaCaducidad;
            NumeroLote = numeroLote;
            FechaEnvasado = fechaEnvasado;
            PaisOrigen = paisOrigen;
        }
    }
}
