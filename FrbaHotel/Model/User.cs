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
        public int document = 0;
        public DateTime date = new DateTime();
        public List<Object> hotel = new List<Object>();
        public int telephone = 0;
        public String username = "";
        public address address = new address();
        public Hotel logged_hotel = new Hotel();

        public User() { }

        public User(String name, String pass) 
        {
            this.username = name;
            this.password = pass;
        }

        public User(Dictionary<String,Object> values) {
            this.fillProperties(values);
        }


        private bool EqualsTo(String username)
        {
            bool result = false;
            if (this.username.Equals(username))
                result = true;
            return result;
        }



        public void fillProperties(Dictionary<String,Object> values) {
            Boolean exists_rol = true;
            int i = 0;
            address new_address = new address(values);
            this.address = new_address;
            this.password = (string)values["password"];
            while(exists_rol){
                String hotel = "" ;
                String rol = "";
                if (values.ContainsKey("rol")) { 
                    this.rol = (string)values["rol"];
                    this.roles.Add(values["rol"]);
                }
                if (values.ContainsKey("hotel")) {
                    String new_hotel = (string)values["hotel"];
                    Hotel hot = new Hotel(new_hotel);
                    this.logged_hotel.setName(hot.getName());
                    this.hotel.Add(hot);
                }
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
            this.document = (int)values["dni"];
            this.telephone= (int)values["telefono"];
            this.date = (DateTime)values["fecha_nacimiento"];
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
        public int getDocument() { return this.document; }
        public List<Object> getHotel() { return this.hotel; }
        public DateTime getDate() { return this.date; }
        public List<Object> getRoles() { return this.roles; }
        public String getRol() { return this.rol; }
        public String getUserName() { return this.username; }
        public int getTelephone() { return this.telephone; }
        public address getAddress() { return this.address; }
        public Hotel getLoggedHotel() { return this.logged_hotel; }

        public void setUsername(String username) { this.username = username;}
        public void setPassword(String password) { this.password = password; }
        public void setLoggedHotel(Hotel hotel) { this.logged_hotel = hotel;}
        public void setRol(String rol) { this.rol = rol; }
        public void setName(String name){this.name = name;}
        public void setAddress(address address) { this.address = address; }
        public void setDate(DateTime date) { this.date = date; }
        public void setLastName(String lastname) { this.lastName = lastname; }
        public void setDocument(int doc) { this.document = doc; }
        public void setMail(String mail) { this.mail = mail; }
        public void setTelephone(int tel) { this.telephone = tel; }
    }
}
