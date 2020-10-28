using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Impuesto_FE
    {

        public int Id_Impuesto_FE {get;set;}

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public double Porcentaje { get; set; }






    }
}
