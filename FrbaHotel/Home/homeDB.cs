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
            String query = "select rol,password from gd_esquema.usuarios where usuario='"+user.ToString()+"';";
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
        private void isUserAvaible(String user){
            String query = "select usuario from gd_esquema.usuarios_inhabilitados where usuario ='"+user.ToString()+"';";
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

        //Setea a un usuario como inhabilitado
        //FALTA HACER FUNCIONAR EL INSERT
        public void setUnavaibleUser(String user) {
            DataBase db = new DataBase();
            String query = "insert into gd_esquema.usuarios_inhabilitados values(2,'"+user.ToString()+"');";
            db.insert_query(query);
        }

        
    }



}
