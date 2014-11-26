using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Model
{
    public class Client : User
    {
        private String nationality = "";
                    

        public Client(Dictionary<String, Object> values) {
            this.mail = (string)values["mail"];
            this.name = (string)values["nombre"];
            this.lastName = (string)values["apellido"];
            this.document = (int)values["nro_doc"];
            if (!values["telefono"].Equals(DBNull.Value))
                this.telephone = (int)values["telefono"];
            this.date = (DateTime)values["fecha_nacimiento"];
            this.address = new address(values);
            this.nationality = (string)values["nacionalidad"];
        } 
    }
}
