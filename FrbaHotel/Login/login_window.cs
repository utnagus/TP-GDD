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
                home_db.verifyUser(user,pass);
                verify = true;
            }
            catch (Exception ex) {
             
                MessageBox.Show(ex.Message);
            }

            //SI NO EXISTE EL USUARIO TENGO QUE CONTAR LOS INTENTOS
            if (!verify)
            {
                fails++;
                if (fails == 3)
                {
                    //INHABILITAR USUARIO, GUARDO UNA TABLA CON LOS USUARIOS INHABILITADOS
                    home_db.setUnavaibleUser(user);
                    MessageBox.Show("Usuario inhabilitado por hacer mas de 3 intentos","Bloqueo de usuario",
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);       
                       
                }
            }
            else {
                fails = 0;
                MessageBox.Show("Logueo con exito!!","Login",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                //CREAR EL OBJETO SEGUN QUIEN SE LOGUEO
                //ME TENGO QUE TRAER LOS VALORES DEL USUARI

                User logged_user = new User(); // DEBERIA SER O ADMIN O RECEPCIONISTA
                
                //REDIRECT A PAGINA PRINCIPAL
                index_window index = (index_window)sender;
                index.setUserLogged(logged_user);
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
