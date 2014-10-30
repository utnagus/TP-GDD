using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Home;
using FrbaHotel.Model;

namespace FrbaHotel.Login
{
    public partial class login_window : Form
    {
        private homeDB home_db = new homeDB();
        private int fails = 0;

        public login_window()
        {
            InitializeComponent();
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean verify = false;
            String user = txt_user.Text;
            String pass = txt_pass.Text;
            User onLogginUser =  new User();
            onLogginUser.setUsername(user);
            onLogginUser.setPassword(pass);
            
            try
            {
                if (user == "")
                {
                    throw new Exception("El nombre de usuario no puede estar vacio");
                }
                if (pass == "")
                {
                    throw new Exception("La constrasenia no puede estar vacia");
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Campo incompleto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //VERIFICO QUE SEA ADMIN O RECEPCIONISTA
            //VERIFICO QUE NO SEA UN USUARIO INHABILITADO
            //VERIFICO CONSTRASENIA (FALTA VERIFICAR)
            try
            {
                home_db.verifyUser(onLogginUser);
                verify = true;
            }
            catch (Exception ex) {
             
                MessageBox.Show(ex.Message);
            }

            //SI NO EXISTE EL USUARIO TENGO QUE CONTAR LOS INTENTOS
            if (!verify){
                fails++;
                if (fails == 3)
                {
                    //INHABILITAR USUARIO, GUARDO UNA TABLA CON LOS USUARIOS INHABILITADOS
                    home_db.setUnavaibleUser(user);
                    MessageBox.Show("Usuario inhabilitado por hacer mas de 3 intentos","Bloqueo de usuario",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    fails = 0;   
                }
            }
            else {
                fails = 0;
            
                MessageBox.Show("Logueo con exito!!","Login",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);

                User logged_user = new User(user, pass);
                logged_user.getYouProperties();
                Console.WriteLine("Carge al objeto usuario con sus datos");

                //MOSTRAR CON QUE ROL QUIERE LOGUEARSE
                int rols = logged_user.getRol().Count();
                String rol = "";
                Console.WriteLine("Cantida de roles: "+rols);
                if (rols > 1)
                {
                    RolSelector rolWindows = new RolSelector(logged_user.getRol());
                    rolWindows.Show();
                    rol = rolWindows.getSelectedRol();
                }
                else {
                    rol = logged_user.getRol().IndexOf(0).ToString();
                }

                //CREAR EL OBJETO SEGUN QUIEN SE LOGUEO
                //ME TENGO QUE TRAER LOS VALORES DEL USUARIO
                // DEBERIA SER O ADMIN O RECEPCIONISTA
                if (rol == "Administrador") {
                    logged_user = new UserAdmin();
                }
                if (rol == "Recepcionista") {
                    logged_user = new UserRecepsionist();
                }
                
                //REDIRECT A PAGINA PRINCIPAL
                index_window.sharedInstance().setUserLogged(logged_user);
                this.Close();
            }
        }

        /*Constructor vacio*/
        private void login_window_Load(object sender, EventArgs e){}

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
    }
}
