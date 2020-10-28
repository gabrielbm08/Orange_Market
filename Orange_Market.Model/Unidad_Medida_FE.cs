using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orange_Market.Model
{
    public class Unidad_Medida_FE
    {

        public int Id_Unidad { get; set; }
        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Siglas_Unidad { get; set; }

        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Descripcion { get; set; }




    }
}
