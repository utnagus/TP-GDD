using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace FrbaHotel.Model
{
    public class Client : User
    {
        private String nationality = "";
        private bool _isDirty = false;

        public Client() { }
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

        //validar que query funcione
        public void setYouDOWN() {
            String query = "insert into qwerty.clientes_inhabilitados (cliente_id,nombre,apellido,mail,telefono,id_domicilio,nacionalidad,fecha_nacimiento,Tipo_Doc,Nro_Doc ) select top 1 cliente_id,nombre,apellido,mail,telefono,id_domicilio,nacionalidad,fecha_nacimiento,Tipo_Doc,Nro_Doc from qwerty.clientes where nombre='" + this.name + "' and mail='" + this.mail + "';";
            String delete_query = "delete from qwerty.clientes where nombre='" + this.name + "' and mail='" + this.mail + "';";
            DataBase db = new DataBase();
            db.insert_query(query);
            db.delete_query(delete_query);
        }

        /*tomo un cliente inhabilitado y lo habilito */
        public void setYouUP() {
            String query_validate = "select count(*) as qty from qwerty.clientes where nombre='"+this.name+"' and mail='    "+this.mail+"'; ";
            String delete_query = "delete from qwerty.clientes_inhabilitados where nombre='" + this.name + "' and mail='" + this.mail + "';";
                
            DataBase db = new DataBase();
            DataTable dt = db.select_query(query_validate);
            db.delete_query(delete_query);
            
            if (int.Parse(dt.Rows[0]["qty"].ToString()) != 0)
                _isDirty = true;

            if (!_isDirty)
            {
                String query = "insert into qwerty.clientes select * from qwerty.clientes_inhabilitados where nombre='" + this.name + "'";
                
                db.insert_query(query);
                
            }
        }

        public String getNationality() { return this.nationality; }
    }
}
