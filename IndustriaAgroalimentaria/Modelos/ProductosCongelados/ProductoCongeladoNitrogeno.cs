﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos.ProductosCongelados
{
    class ProductoCongeladoNitrogeno : ProductoCongelado
    {
        public string MetodoCongelacion { get; set; }
        public string ENPS { get; set; } //exposición al nitrógeno expresada en segundos.

        //public ProductoCongeladoNitrogeno(DateTime fechaCaducidad, int numeroLote, DateTime fechaEnvasado, string paisOrigen, string temperturaRecomendada,
        //    string metodoCongelacion, string enps) : base(fechaCaducidad, numeroLote, fechaEnvasado, paisOrigen, temperturaRecomendada)
        //{
        //    MetodoCongelacion = metodoCongelacion;
        //    ENPS = enps;
        //}

        public override string ToString()
        {
            return $"{Id}) El producto con el numero de lote {NumeroLote}, es un producto congelado con nitrogeno y ENPS de {ENPS}";
        }
    }
}
