﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IndustriaAgroalimentaria.Modelos.ProductosCongelados
{
    public class ProductoCongeladoAgua : ProductoCongelado
    {
        public double GSPLA { get; set; } // gramos de sal por litro de agua.

        public ProductoCongeladoAgua(DateTime fechaCaducidad, int numeroLote, DateTime fechaEnvasado, string paisOrigen, string temperturaRecomendada, 
            double gspla) : base(fechaCaducidad, numeroLote, fechaEnvasado, paisOrigen, temperturaRecomendada)
        {
            GSPLA = gspla;
        }
    }
}
