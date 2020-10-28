using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
   public class Categoria
    {

      public int Id_Categoria { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Nombre_Categoria { get; set; }




    }
}
