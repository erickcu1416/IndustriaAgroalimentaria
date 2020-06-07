using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos
{
    public class ProductoCongelado : Producto
    {
        public string TemperaturaRecomendada { get; set; }

        public ProductoCongelado(DateTime fechaCaducidad, int numeroLote, DateTime fechaEnvasado, string paisOrigen, string temperturaRecomendada)
        {
            FechaCaducidad = fechaCaducidad;
            NumeroLote = numeroLote;
            FechaEnvasado = fechaEnvasado;
            PaisOrigen = paisOrigen;
            TemperaturaRecomendada = temperturaRecomendada;
        }
    }
}
