using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos
{
    public class ProductoRefrigerado : Producto
    {
        public string COSA { get; set; } //código del organismo de supervisión alimentaria
        public string TemperaturaRecomendada { get; set; }

        //public ProductoRefrigerado(DateTime fechaCaducidad, int numeroLote, DateTime fechaEnvasado, string paisOrigen, string cosa, string temperturaRecomendada): base(fechaCaducidad, numeroLote, fechaEnvasado, paisOrigen)
        //{
        //    COSA = cosa;
        //    TemperaturaRecomendada = temperturaRecomendada;
        //}

    }
}
