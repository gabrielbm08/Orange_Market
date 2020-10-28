using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Transacciones
    {

        public int Id_Transaccion { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public int Id_Cliente { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public int Id_Venta { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public DateTime Fecha_Compra { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Monto_Compra { get; set; }



    }
}
