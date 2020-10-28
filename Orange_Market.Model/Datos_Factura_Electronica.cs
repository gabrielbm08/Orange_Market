using System;
using System.Collections.Generic;
using System.Text;

namespace Orange_Market.Model
{
    public class Datos_Factura_Electronica
    {
        public int Id_Datos_Factura_Electronica { get; set; }

        public int Id_Numero_Identificacion_Compañia { get; set; }

        public int Id_Tributacion { get; set; }

        public string Descripcion { get; set; }

        public string Correo { get; set; }

        public int Id_provincia { get; set; }

        public int Id_Distrito { get; set; }

        public int Id_Canton { get; set; }

        public int Id_Barrio { get; set; }

        public string Usuario_Hacienda { get; set; }

        public string Clave_Hacienda { get; set; }

        public string Pin_Certifica_Hacienda { get; set; }

        public string Llaver_Criptografica { get; set; }


        public string Codigo_actividad { get; set; }





    }
}
