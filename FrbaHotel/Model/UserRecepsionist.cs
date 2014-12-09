using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Model
{
    class UserRecepsionist : User
    {
        DataBase db = new DataBase();
        public UserRecepsionist(Dictionary<String,Object> values) {
            this.fillProperties(values);
            this.rol = "Recepsionista";
        }

        public UserRecepsionist() { }

        public void setYouUP(UserRecepsionist user)
        {
            String query = "insert into qwerty.usuarios values'" + user.getName() + "','" + user.getLastName() + "','" + user.getMail() + "','"+user.getTelephone()+"','" + user.getAddress() + "','" + user.getDate() + "','" + user.getDocument() + "','" + user.getTelephone() + "');";
            //verificar que no exista el mail 
            db.insert_query(query);
            
        }
    }
}
