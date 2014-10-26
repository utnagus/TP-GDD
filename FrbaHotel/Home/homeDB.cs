using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Model;
using System.Data.SqlClient;
using System.Data;
namespace FrbaHotel.Home
{
    class homeDB
    {
        private DataBase db = new DataBase();

        public homeDB() { }

        //Verifico que el usuario que se loguea sea Adminn o Receps
        //Verifico que su password sea correcta
        //Verifico que no este inhabilitado
        public void verifyUser(String user,String password) {
            
            this.isUserAvaible(user);

            String rol ="";
            String db_password = "";
            String query = "select	r.rol, u.password from	qwerty.usuarios u, qwerty.usuarios_roles ur,qwerty.roles r	where ur.rol_id = r.rol_id and	ur.username = '"+user+"';";
            DataTable dt = db.select_query(query);
            
            if (dt.Rows.Count != 0){
                 rol = (string)dt.Rows[0]["rol"];
                 db_password = (string)dt.Rows[0]["password"];
            }
            
            if (rol != "Administrador" && rol != "Recepcionista")
                throw new Exception("No sos Administrador ni Recepcionista");

            if (db_password != password) {
                throw new Exception("Contrasenia incorrecta");
            }

        }

        //Verifico que no este en la tabla de usuarios inhabilitados
        private void isUserAvaible(String username){
            String query = "select username from qwerty.usuarios_inhabilitados where username = '"+ username +"';";
            DataTable dt = db.select_query(query);
            if (dt.Rows.Count != 0){
                throw new Exception("Usuario Inhabilitado");
            }

            
        }
        //Obtengo una lista de todos los usuarios
        public DataTable getUsersList() {
            String query = "select usuario from gd_esquema.usuarios_inhabilitados ;";
            DataTable dt = db.select_query(query);
            return dt;
        }
        
        //Traigo datos del usuario y los paso de un dataTable a un diccionario
        public Dictionary<String,Object> getUserConfig(String username, String password){
            String query = "select * from qwerty.usuarios where username ='"+username+"' and password = '"+password+"';";
            String query_rol = "select r.rol as rol from qwerty.usuarios_roles ur,qwerty.roles r where ur.rol_id = r.rol_id and ur.username = '"+username+"'";
            String query_hotel = "select h.nombre as hotel from qwerty.usuarios u, qwerty.personal_hoteles ph, qwerty.hotel h where u.username =ph.username and ph.hotel_id = h.hotel_id and u.username = '"+ username +"';";
            DataTable dt = db.select_query(query);
            DataTable dt_rol = db.select_query(query_rol);
            DataTable dt_hotel = db.select_query(query_hotel);
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            Dictionary<String, Object> dic_rol = new Dictionary<String, Object>();
            Dictionary<String, Object> dic_hotel = new Dictionary<String, Object>();
            
            /*CARGO DIC*/
            foreach (DataColumn dc in dt.Columns) {

                int rows = dt.Rows.Count;
                for(int i=0 ; i< rows; i++)
                    dic[dc.ToString().ToLower()] = dt.Rows[i][dc];
            }
            /*CARGO DIC ROL*/
            foreach (DataColumn dc in dt_rol.Columns)
            {

                int rows = dt.Rows.Count;
                for (int i = 0; i < rows; i++)
                    dic_rol[dc.ToString().ToLower()] = dt_rol.Rows[i][dc];
            }

            /*cargo dic hotel*/
            foreach (DataColumn dc in dt_hotel.Columns)
            {

                int rows = dt.Rows.Count;
                for (int i = 0; i < rows; i++)
                    dic_hotel[dc.ToString().ToLower()] = dt_hotel.Rows[i][dc];
            }
            Dictionary<String, Object> dic_final = dic.Union(dic_rol).Union(dic_hotel).ToDictionary(key =>key.Key,value=>value.Value);

            return dic_final;
        }

        //Setea a un usuario como inhabilitado
        //FALTA HACER FUNCIONAR EL INSERT
        public void setUnavaibleUser(String user) {
            DataBase db = new DataBase();
            String query = "insert into gd_esquema.usuarios_inhabilitados values(2,'"+user.ToString()+"');";
            db.insert_query(query);
        }

        
    }



}
