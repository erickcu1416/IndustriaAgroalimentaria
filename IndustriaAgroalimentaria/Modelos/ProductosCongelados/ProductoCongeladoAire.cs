using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos.ProductosCongelados
{
    public class ProductoCongeladoAire : ProductoCongelado
    {
        public double PorcentajeNitrogeno { get; set; }
        public double PorcentajeOxigeno { get; set; }
        public double PorcentajeDioxidoCarbono { get; set; }
        public double PorcentajeVaporAgua { get; set; }

        public override string ToString()
        {
            return $"{Id}) Es un producto congelado con {PorcentajeNitrogeno.ToString()}";
        }


        //public ProductoCongeladoAire(DateTime fechaCaducidad, int numeroLote, DateTime fechaEnvasado, string paisOrigen, string temperturaRecomendada,
        //    double porcentajeNitrogeno, double porcentajeOxigeno, double porcentajeDioxidoCarbono, double porcentajeVaporAgua) : base(fechaCaducidad, numeroLote, fechaEnvasado, paisOrigen, temperturaRecomendada)
        //{
        //    PorcentajeNitrogeno = porcentajeNitrogeno;
        //    PorcentajeOxigeno = porcentajeOxigeno;
        //    PorcentajeDioxidoCarbono = porcentajeDioxidoCarbono;
        //    PorcentajeVaporAgua = porcentajeVaporAgua;
        //}
    }
}
