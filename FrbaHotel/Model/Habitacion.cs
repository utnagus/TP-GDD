using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Model
{
    class Habitacion
    {
        /*atributos*/
        private int nro;
        private int id;
        private char ubicacion;
        private int tipo;
        private string descripcion;

        /*setters*/
        public void setNro(int nro) { this.nro = nro; }
        public void setId(int id) { this.id = id; }
        public void setChar(char ubicacion) { this.ubicacion = ubicacion; }
        public void setTipo(int tipo) { this.tipo = tipo; }
        public void setDescripcion(string desc) { this.descripcion = desc; }

         public Habitacion() { }

         public void inserta_Habitacion()
        {
            DataBase db = new DataBase();
            String query = "insert into QWERTY.Habitaciones (Numero,Piso,Ubicacion,Tipo_ID,Descripcion,Hotel_ID) values (1,1,'S',2,'asdasda',1)";
            db.insert_query(query);

            
        }

    }
}
