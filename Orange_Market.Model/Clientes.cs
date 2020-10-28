using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Clientes
    {


        [Required(ErrorMessage = "Este Valor es requerido")]
        public int Id_Clientes { get ; set ; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public string Correo_Electronico { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public int Id_Telefono { get; set; }

      

        [Required(ErrorMessage = "Este Valor es requerido")]
        public double Monto_Total { get; set; }

        [Required(ErrorMessage = "Este Valor es requerido")]
        public int Porcentaje_Descuento { get; set; }
    }
}
