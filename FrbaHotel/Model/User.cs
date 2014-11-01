using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using FrbaHotel.Home;
using FrbaHotel.Model;

namespace FrbaHotel.Model
{
    public abstract class User
    {
        public String password="";
        public List<Object> roles = new List<Object>();
        public String rol = "";
        public String mail = "";
        public String name = "";
        public String lastName = "";
        public Int64 document = 0;
        public DateTime date = new DateTime();
        public List<Object> hotel = new List<Object>();
        public Int64 telephone = 0;
        public String username = "";
        public String address = "";
        public String logged_hotel = "";

        public User() { }

        public User(String name, String pass) {
            this.username = name;
            this.password = pass;
        }

        public User(Dictionary<String,Object> values) {
            this.fillProperties(values);
        }

        public void fillProperties(Dictionary<String,Object> values) {
            Boolean exists_rol = true;
            int i = 0;
            this.address = (string)values["direccion"];
            this.password = (string)values["password"];
            while(exists_rol){
                String hotel = "" ;
                String rol = "";
                if (values.ContainsKey("rol" + "_" + i.ToString())) {
                    rol = (string)values["rol" + "_" + i.ToString()];
                    this.roles.Add(rol);
                }

                if (values.ContainsKey("hotel" + "_" + i.ToString())) {
                    hotel = (string)values["hotel" + "_" + i.ToString()];
                    Hotel hot = new Hotel(hotel);
                    this.hotel.Add(hot);
                }
                
                if (hotel == "" && rol == "")
                    exists_rol = false;

                i++;
                
            }
            this.mail = (string)values["mail"];
            this.name = (string)values["nombre"];
            this.lastName = (string)values["apellido"];
            this.username = (string)values["username"];
            this.telephone= (Int64)values["telefono"];
            this.document = (Int64)values["dni"];
            this.date = (DateTime)values["fecha_nacimiento"];
        }

        /*public void getYouProperties() {
            homeDB home = new homeDB();
            Dictionary<String, Object> values = home.getUserConfig(this);
            this.fillProperties(values);
        }*/

        public void setYouDown() {
            homeDB home = new homeDB();
            home.downUser(this.username);
        }

        public void setYouUP() {
            homeDB home = new homeDB();
            home.upUser(this);
        }

        /* GETTERS && SETTERS */
        public String getName() { return this.name; }
        public String getPassword() { return this.password; }
        public String getLastName() { return this.lastName; }
        public String getMail() { return this.mail; }
        public Int64 getDocument() { return this.document; }
        public List<Object> getHotel() { return this.hotel; }
        public DateTime getDate() { return this.date; }
        public List<Object> getRoles() { return this.roles; }
        public String getRol() { return this.rol; }
        public String getUserName() { return this.username; }
        public Int64 getTelephone() { return this.telephone; }
        public String getAddress() { return this.address; }
        public String getLoggedHotel() { return this.logged_hotel; }

        public void setUsername(String username) { this.username = username;}
        public void setPassword(String password) { this.password = password; }
        public void setLoggedHotel(String hotel) { this.logged_hotel = hotel;}
        public void setRol(String rol) { this.rol = rol; }
    }
}
