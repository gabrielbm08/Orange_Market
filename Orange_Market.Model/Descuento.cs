using System;
using System.Collections.Generic;
using System.Text;

namespace Orange_Market.Model
{
    public class Descuento
    {
        public int Id_Descuento { get; set; }
        public int Id_Cliente { get; set; }
        public float Cantidad_Descuento { get; set; }

    }
}
