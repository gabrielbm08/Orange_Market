using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Codigo_Comercial_FE
    {

        public int Id_Codigo_Comercial { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Id_Descripcion {get; set;}


    }
}
