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

        //select * from QWERTY.Habitaciones h where h.Hotel_ID='1' and h.Numero='22'
         public bool existe_Habitacion(int id, int nro)
         {
             bool existe = false;
             DataBase db = new DataBase();
             String query = "select * from QWERTY.Habitaciones h where h.Hotel_ID='"+id+"' and h.Numero='"+nro+"'";
             DataTable dt = new DataTable();
             dt = db.select_query(query);
             if (dt.Rows.Count > 0) { existe = true; }
             return existe;
         }

         public DataTable dameTodosLasHabitaciones(String nro,String piso,String ubic,String descripcion, String nombre, String hab)
         {
             String query = "select ha.Habitacion_ID,th.Tipo_Habitacion_ID,ha.Numero,ha.Piso,ha.Ubicacion,ha.Descripcion,ho.Nombre,th.Descripcion from QWERTY.Habitaciones ha, QWERTY.Hotel ho, QWERTY.Tipo_Habitacion th where ha.Hotel_ID=ho.Hotel_ID and ha.Tipo_ID=th.Tipo_Habitacion_ID and ha.Numero like '%"+nro+"%' and ha.Piso like '%"+piso+"%'and ha.Ubicacion like '%"+ubic+"%' and ha.Descripcion like '%"+descripcion+"%' and ho.Nombre like '%"+nombre+"%' and th.Descripcion like '%"+hab+"%'";
             DataBase db = new DataBase();
             DataTable dt = db.select_query(query);
             return dt;
         }

        
    }
}
