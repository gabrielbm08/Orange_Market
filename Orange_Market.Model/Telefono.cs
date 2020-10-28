using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Telefono
    {
        
        public int Id_Telefono { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public int Id_Tipo_Telefono {get; set;}


        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public int Id_Cliente { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public int Numero_Telefono { get; set; }


    }
}
