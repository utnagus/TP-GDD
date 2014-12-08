using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.Model
{
    class Habitacion
    {
        /*atributos*/
        private string nro;
        private int id;
        private char ubicacion;
        private int tipo;
        private string piso;
        private string descripcion;

        /*setters*/
        public void setNro(string nro) { this.nro = nro; }
        public void setId(int id) { this.id = id; }
        public void setUbicacion(char ubicacion) { this.ubicacion = ubicacion; }
        public void setTipo(int tipo) { this.tipo = tipo; }
        public void setPiso(string piso) { this.piso = piso; }
        public void setDescripcion(string desc) { this.descripcion = desc; }

         public Habitacion() { }

         public void inserta_Habitacion()
        {
            DataBase db = new DataBase();
            String query = "insert into QWERTY.Habitaciones (Numero,Piso,Ubicacion,Tipo_ID,Descripcion,Hotel_ID) values ("+this.nro+","+this.piso+",'"+this.ubicacion+"',"+this.tipo+",'"+this.descripcion+"',"+this.id+")";
            db.insert_query(query);

            
        }
         public DataTable dameTiposHabitaciones()
         {
             DataBase db = new DataBase();
             DataTable dt = new DataTable();
             String query = "select * from QWERTY.Tipo_Habitacion";
             dt = db.select_query(query);
             return dt;             
         }

         

        
    }
}
