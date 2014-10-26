using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Model
{
    public class User
    {
        private String password="";
        private List<Object> rol = new List<Object>();
        private String mail = "";
        private String name = "";
        private String lastName = "";
        private String document = "";
        private DateTime date = new DateTime();
        private String hotel = "";
        private String telephone = "";
        private String nickname = "";
        private String address = "";

        public User() { }

        public User(Dictionary<String,Object> values) {
            this.password = (string)values["password"];
            this.rol.Add((string)values["rol"]);
            this.mail = (string)values["mail"];
            this.name = (string)values["name"];
            this.lastName = (string)values["lastName"];
            this.document = (string)values["document"];
            this.hotel = (string)values["hotel"];
            this.date = (DateTime)values["date"];
            this.nickname = (string)values["nickname"];
            this.telephone = (string)values["telephone"];
            this.address = (string)values["address"];
        }


        /* GETTERS && SETTERS */
        public String getName() { return this.name; }
        public String getPassword() { return this.password; }
        public String getLastName() { return this.lastName; }
        public String getMail() { return this.mail; }
        public String getDocument() { return this.document; }
        public String getHotel() { return this.hotel; }
        public DateTime getDate() { return this.date; }
        public List<Object> getRol() { return this.rol; }
        public String getNickname() { return this.nickname; }
        public String getTelephone() { return this.telephone; }
        public String getAddress() { return this.address; }

    }
}
