using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Clinica_Frba.Properties;
using System.IO;

namespace Clinica_Frba.Dominio
{
    class Dia
    {
        // Aca se puede poner la fecha que quieras que sea hoy, teoricamente desde el archivo de configuracion. Hasta que este eso hecho
        // toma la fecha del dia.

        public DateTime FechaDeHoy = DateTime.Today;

        

        public DateTime Hoy()
        {
            
            var value = ConfigurationSettings.AppSettings["DateKey"];
            var appDate = DateTime.Parse(value);

            return appDate;
            /*return FechaDeHoy;*/

        }
        


    }
}
