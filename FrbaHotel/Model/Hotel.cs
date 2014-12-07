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
        private Int32 id;
        private Int32 estado;
        private String email;
        Int64 tel;
        Int32 stars;
        private String city;
        private String country;
        private String direccion;

        private DateTime creation_date;
        private List<int> regimenes = new List<int>();



        /*setters*/
        public Hotel() { }
        public Hotel(String name) { this.name = name; }

        public void setEmail(String email) { this.email = email; }
        public void setStars(Int32 stars) { this.stars = stars; }
        public void setCity(String city) { this.city = city; }
        public void setCountry(String country) { this.country = country; }
        public void setTel(Int64 tel) { this.tel = tel; }
        public void setDireccion(String direccion) { this.direccion = direccion; }
        public void setRegimenes(int reg) { this.regimenes.Add(reg); }
        public void setFecha(DateTime fecha) { this.creation_date = fecha; }
        public void setId(Int32 id) { this.id = id; }
        public void setEstado(Int32 estado) { this.estado = estado; }


        public String getName() { return this.name; }
        public void setName(String name) { this.name = name; }

        private DataBase db = new DataBase();

        public void inserta_Hotel()
        {
            String query = "insert into QWERTY.Hotel (Nombre,Mail,Telefono,Direccion,Estrellas,Ciudad,Pais,Fecha_creacion) values ('" + this.name + "','" + this.email + "'," + this.tel + ",'" + this.direccion + "'," + this.stars + ",'" + this.city + "','" + this.country + "','" + this.creation_date + "')";
            db.insert_query(query);

            foreach (var reg in regimenes)
            {
                int i = reg;
                i++;
                String query2 = "declare @id int select @id=h.Hotel_ID from QWERTY.Hotel h where h.Nombre='" + this.name + "' insert into QWERTY.Hotel_Regimenes (Hotel_ID,Regimen_ID) values (@id," + i + ")";
                db.insert_query(query2);
            }
        }

        public void update_Hotel()
        {
            String query = "update QWERTY.Hotel set Nombre='" + this.name + "',Mail='" + this.email + "',Telefono='" + this.tel + "',Direccion='" + this.direccion + "',Estrellas='" + this.stars + "',Ciudad='" + this.city + "',Pais='" + this.country + "',Fecha_creacion='" + this.creation_date + "',Estado='" + this.estado + "' where Hotel_ID='" + this.id  + "';delete from QWERTY.Hotel_Regimenes where Hotel_ID='" + this.id + "'";
            db.update_query(query);

            foreach (var reg in regimenes)
            {
                int i = reg;
                i++;
                String query2 = "insert into QWERTY.Hotel_Regimenes (Hotel_ID,Regimen_ID) values (" + this.id + "," + i + ")";
                db.update_query(query2);
            }
        }
        public void delete_Hotel()
        {
            String query = "update QWERTY.Hotel set Estado='0' where Hotel_ID='" + this.id + "'";
            db.delete_query(query);

        }


        public DataTable buscameRegimenes(Int32 id)
        {
            String query = "select * from QWERTY.Hotel_Regimenes h where h.Hotel_ID =" + id;
            DataTable dt = db.select_query(query);
            return dt;
        }


        public DataTable dameListadoHotelesEstado01(String name, String star, String city, String pais, Int32 estado)
        {
            String query = "select * from QWERTY.Hotel h where h.Nombre like '%" + name + "%' and h.Estrellas like '%" + star + "%' and h.Ciudad like '%" + city + "%' and h.Pais like '%" + pais + "%' and h.Estado='" + estado + "'";
            DataTable dt = db.select_query(query);
            return dt;
        }
        public DataTable dameTodosLosHoteles(String name, String star, String city, String pais)
        {
            String query = "select * from QWERTY.Hotel h where h.Nombre like '%" + name + "%' and h.Estrellas like '%" + star + "%' and h.Ciudad like '%" + city + "%' and h.Pais like '%" + pais + "%'";
            DataTable dt = db.select_query(query);
            return dt;
        }

    }
}