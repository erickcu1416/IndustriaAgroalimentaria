using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos
{
    public class ProductoRefrigerado : Producto
    {
        public string COSA { get; set; } //código del organismo de supervisión alimentaria
        public string TemperaturaRecomendada { get; set; }

        public ProductoRefrigerado(DateTime fechaCaducidad, int numeroLote, string cosa, DateTime fechaEnvasado, string paisOrigen, string temperturaRecomendada)
        {
            FechaCaducidad = fechaCaducidad;
            NumeroLote = numeroLote;
            COSA = cosa;
            FechaEnvasado = fechaEnvasado;
            PaisOrigen = paisOrigen;
            TemperaturaRecomendada = temperturaRecomendada;
        }

    }
}
