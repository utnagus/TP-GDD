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
        private Dictionary<String, Object> hotels = new Dictionary<String, Object>();

        public homeDB() { }

        public Dictionary<String,Object> getUserData(String user, String pass){
            Dictionary<String, Object> values =  new Dictionary<String, Object>(); 
            this.verifyUser(user, pass);
            values = this.getUserConfig(user,pass);
            
            return values;
        }


        //Verifico que el usuario que se loguea sea Adminn o Receps
        //Verifico que su password sea correcta
        //Verifico que no este inhabilitado
        //public void verifyUser(User logginUser) {
          private void verifyUser(String user, String password){
            /*String user = logginUser.getUserName();
            String password = logginUser.getPassword(); */

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

        public void upUser(User user) {
            DataBase db = new DataBase();
            String user_query = "insert into qwerty.usuarios values('" + user.getUserName() + "','" + user.getPassword() + "','" + user.getName() + "','" + user.getLastName() + "','" + user.getMail() + "','" + user.getAddress() + "','" + user.getDate() + "','" + user.getDocument() + "','" + user.getTelephone() + "');";
            String select_user_hotel = "select hotel_id from qwerty.hotel where nombre ='"+user.getLoggedHotel().getName()+"';";
            DataTable dt = db.select_query(select_user_hotel);
            int id = (int)dt.Rows[0]["hotel_id"]; //obtengo el ID del hotel
             String personal_hotel_query = "insert into qwerty.personal_hoteles values('" + user.getUserName() +"','"+ id +"')";           
            db.insert_query(user_query);
            db.insert_query(personal_hotel_query);
        }

        public void downUser(String username) {
            DataBase db = new DataBase();
            String query =  "insert into qwerty.baja_usuarios values ('"+username+"','Eliminado por el administrador');";
            String update = "update qwerty.usuarios set status= 'B' where username ='" + username +"';";
            db.insert_query(query);
            db.update_query(update);
        }

        //Obtengo una lista de todos los usuarios donde esta logueado el admin
        public DataTable getUsersList(UserAdmin admin) {
            String query = "select u.username from qwerty.usuarios u,qwerty.hotel h,qwerty.personal_hoteles ph where u.username = ph.username and ph.hotel_id = h.hotel_id and status ='A' and h.nombre='" + admin.getLoggedHotel().getName() + "';";
            DataTable dt = db.select_query(query);
            return dt;
        }
        
        //Traigo datos del usuario y los paso de un dataTable a un diccionario
        public Dictionary<String, Object> getUserConfig(String username,String password)
        {
            /*String username = user.getUserName();
            String password = user.getPassword();*/
            //String query = "select * from qwerty.usuarios where username ='"+username+"' and password = '"+password+"';";
            String query = "select * from qwerty.usuarios where username ='" + username + "';";
            String query_rol = "select r.rol as rol from qwerty.usuarios_roles ur,qwerty.roles r where ur.rol_id = r.rol_id and ur.username = '"+username+"';";
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

                int rows = dt_rol.Rows.Count;
                for (int i = 0; i < rows; i++)
                    dic_rol[dc.ToString().ToLower() + "_" + i.ToString()] = dt_rol.Rows[i][dc];
            }

            /*cargo dic hotel*/
            foreach (DataColumn dc in dt_hotel.Columns)
            {

                int rows = dt_hotel.Rows.Count;
                for (int i = 0; i < rows; i++)
                    dic_hotel[dc.ToString().ToLower()+"_"+i.ToString()] = dt_hotel.Rows[i][dc];
            }
            Dictionary<String, Object> dic_final = dic.Union(dic_rol).Union(dic_hotel).ToDictionary(key =>key.Key,value=>value.Value);

            return dic_final;
        }

        //Setea a un usuario como inhabilitado
        public void setUnavaibleUser(String user) {
            DataBase db = new DataBase();
            String query = "insert into qwerty.usuarios_inhabilitados values('"+user.ToString()+"',Intento loguearse 3 veces sin exito);";
            db.insert_query(query);
        }

        public void update_user(User user) {
            DataBase db = new DataBase();
            String query_user = "update qwerty.usuarios set username ='"+user.getUserName()+"',password='"+user.getPassword()+"',nombre='"+user.getName()+"',apellido='"+user.getPassword()+"',mail='"+user.getMail()+"',direccion='"+user.getAddress()+"',dni="+user.getDocument()+",telefono="+user.getTelephone()+" where username = '"+user.getUserName()+"';";
            String query_hotel = "update qwerty.hotel set nombre = '" + user.getLoggedHotel().getName() + "' where nombre=" + user.getLoggedHotel().getName() + ";";
            String query_employees_hotel = "update qwerty.personal_hoteles set username = '"+user.getUserName()+"' where username='"+user.getUserName()+"';";
            db.update_query(query_user);
            db.update_query(query_hotel);
            db.update_query(query_employees_hotel);
    
        }

        
    }



}
