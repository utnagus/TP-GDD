using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.Model
{
    public class Hotel
    {
        private String name;
        private String email;
        Int64 tel;
        Int32 stars;
        private String city;
        private String country;
        private String direccion;

        private DateTime creation_date = new DateTime();
        private List<String> regimenes = new List<String>();
 

        
        
        

        

        /*setters*/
        public Hotel() { }
        public Hotel(String name) { this.name = name; }

        public void setEmail(String email) { this.email = email; }
        public void setStars(Int32 stars) { this.stars = stars; }
        public void setCity(String city) { this.city = city; }
        public void setCountry(String country) { this.country = country; }
        public void setTel(Int64 tel) { this.tel = tel; }
        public void setDireccion(String direccion) { this.direccion = direccion; }


        public String getName() { return this.name; }
        public void setName(String name) { this.name = name; }

        private DataBase db = new DataBase();

        public void inserta_Hotel(String name, String mail, Int64 tel, String dir, Int32 star, String city, String pais, DateTime fecha)
        {
            String query = "insert into QWERTY.Hotel (Nombre,Mail,Telefono,Direccion,Estrellas,Ciudad,Pais,Fecha_creacion) values ('" + name + "','" + mail + "'," + tel + ",'" + dir + "'," + star + ",'" + city + "','" + pais + "','" + fecha + "')";
            db.insert_query(query);
        }


        public DataTable dameListadoHoteles2()
        {
            String query = "select * from QWERTY.Hotel";
            DataTable dt = db.select_query(query);
            return dt;
        }


        public DataTable dameListadoHoteles(String name, String star, String city, String pais)
        {
            String query = "select * from QWERTY.Hotel h where h.Nombre like '%" + name + "%' and h.Estrellas like '%" + star + "%' and h.Ciudad like '%" + city + "%' and h.Pais like '%" + pais + "%'";
            DataTable dt = db.select_query(query);
            return dt;
        }

    }
}
