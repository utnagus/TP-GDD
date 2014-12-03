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

        /*override public void  setYouUp(UserRecepsionist user){
            String query = "insert into qwerty.usuarios values'" + user.getName() + "','" + user.getLastName() + "','" + user.getMail() + "','"+user.getTelephone()+"','" + user.getAddress() + "','" + user.getDate() + "','" + user.getDocument() + "','" + user.getTelephone() + "');";
            db.insert_query(query);
            
        }*/
    }
}
