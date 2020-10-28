using System;
using System.Collections.Generic;
using System.Text;

namespace Orange_Market.Model
{
    public class Lista_Productos
    {
        public int Id_Lista_Productos { get; set; }
        public int Id_Productos { get; set; }
        public int Id_Descuento { get; set; }
        public string Nombre_Producto { get; set; }
        public string Costo_Producto { get; set; }
    }
}
