using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Venta
    {

        public int Id_Venta { get; set; }

        public int Id_Empleado { get; set; }

        public int Id_Lista_Productos { get; set; }

        public int Id_Medio_Pago { get; set; }

        public int Id_Cliente { get; set; }

        public int Id_Condicion_Venta { get; set; }

        public int Id_Datos_Factura_Electronica { get; set; }

        public int Id_Caja { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Subtotal { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Monto_IVA { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Monto_Descuento { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Total { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public DateTime Fecha_Hora_Compra { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Monto_Merc_Grav_DE { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Monto_Merc_ExeDE { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Monto_Serv_GravDE { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Monto_ServExeDE { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Sub_TotalDE { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public int Clave { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public int Consecutivo { get; set; }










    }
}
