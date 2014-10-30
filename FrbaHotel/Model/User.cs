using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using FrbaHotel.Home;

namespace FrbaHotel.Model
{
    public class User
    {
        private String password="";
        private List<Object> rol = new List<Object>();
        private String mail = "";
        private String name = "";
        private String lastName = "";
        private Int64 document = 0;
        private DateTime date = new DateTime();
        private List<Object> hotel = new List<Object>();
        private Int64 telephone = 0;
        private String username = "";
        private String address = "";

        public User() { }

        public User(String name, String pass) {
            this.username = name;
            this.password = pass;
        }

        public User(Dictionary<String,Object> values) {
            this.fillProperties(values);
        }

        private void fillProperties(Dictionary<String,Object> values) {
            Boolean exists_rol = true;
            int i = 0;
            this.address = (string)values["direccion"];
            this.password = (string)values["password"];
            while(exists_rol){
                String hotel = "" ;
                String rol = "";
                if (values.ContainsKey("rol" + "_" + i.ToString())) {
                    rol = (string)values["rol" + "_" + i.ToString()];
                    this.rol.Add(rol);
                }

                if (values.ContainsKey("hotel" + "_" + i.ToString())) {
                    hotel = (string)values["hotel" + "_" + i.ToString()];
                    this.hotel.Add(hotel);
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

        public void getYouProperties() {
            homeDB home = new homeDB();
            Dictionary<String, Object> values = home.getUserConfig(this);
            this.fillProperties(values);
        }

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
        public List<Object> getRol() { return this.rol; }
        public String getUserName() { return this.username; }
        public Int64 getTelephone() { return this.telephone; }
        public String getAddress() { return this.address; }

        public void setUsername(String username) { this.username = username;}
        public void setPassword(String password) { this.password = password; }
       
    }
}
