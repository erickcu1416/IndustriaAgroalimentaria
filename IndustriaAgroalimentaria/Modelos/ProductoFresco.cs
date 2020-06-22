using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos
{
    public class ProductoFresco : Producto
    {
        //public ProductoFresco(DateTime fechaCaducidad, int numeroLote, DateTime fechaEnvasado, string paisOrigen) : base(fechaCaducidad, numeroLote, fechaEnvasado, paisOrigen)
        //{
        //}
        public override string ToString()
        {
            return $"{Id}) El producto con el numero de lote {NumeroLote}, es un producto FRESCO";
        }
    }
}
