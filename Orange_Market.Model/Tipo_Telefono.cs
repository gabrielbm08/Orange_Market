using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Tipo_Telefono
    {
       
        public int Id_Telefono { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Descripcion { get; set; }


    }
}
