using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Model
{
    class UserRecepsionist : User
    {
        public UserRecepsionist(Dictionary<String,Object> values) {
            this.fillProperties(values);
            this.rol = "Recepsionista";
        }
    }
}
