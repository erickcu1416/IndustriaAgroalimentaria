using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos
{
    public abstract class ProductoCongelado : Producto
    {
        public string TemperaturaRecomendada { get; set; }

        //public ProductoCongelado(DateTime fechaCaducidad, int numeroLote, DateTime fechaEnvasado, string paisOrigen, string temperturaRecomendada): base(fechaCaducidad, numeroLote, fechaEnvasado, paisOrigen)
        //{
        //    TemperaturaRecomendada = temperturaRecomendada;
        //}
    }
}
