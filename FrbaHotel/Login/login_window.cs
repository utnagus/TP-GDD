using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class login_window : Form
    {
        public login_window()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            String a = txt_user.Text;
            String b = txt_pass.Text;
            int fails = 0;
            // CONECTAR A DB Y VERIFICAR QUE SEA ADMIN O RECEPCIONISTA
            //VERIFICAR QUE NO SEA UN USUARIO INHABILITADO
            System.Windows.Forms.MessageBox.Show("Usuario"+ a);
            System.Windows.Forms.MessageBox.Show("Pass" + b);

            //SI NO EXISTE TENGO QUE CONTAR LOS INTENTOS
            Boolean loging_success = false;
            if (!loging_success)
            {
                fails++;
                if (fails == 3)
                {
                    //INHABILITAR USUARIO, GUARDO UNA TABLA CON LOS USUARIOS INHABILITADOS
                }
            }
            else {
                fails = 0;
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
