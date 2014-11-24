using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrbaHotel.ABM_de_Usuario;
using FrbaHotel.Login;
using FrbaHotel.Model;
using FrbaHotel.ABM_de_Cliente;
using FrbaHotel.ABM_de_Hotel;
namespace FrbaHotel
{
    public partial class index_window : Form
    {
        public static index_window Instance;
        public User logged_user = null;
       
        public index_window()
        {
            Instance = this;
            InitializeComponent();
        }

        public static index_window sharedInstance() {
            return Instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new Login.login_window();
            login.Show();
        }

        private void btn_user_abm_Click(object sender, EventArgs e)
        {
            try
            {
                userABM abm = new userABM(this.logged_user as UserAdmin);
               //abm.setLoggedAdmin(this.logged_user as UserAdmin);
                abm.Show();
              
               
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void setUserLogged(User user) {
            this.label_logged.Text = user.getUserName();
            this.logged_user = user;
        }

       

        private void index_window_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Object> list = new List<Object>() ;
            list.Add("Administrador");
            list.Add("Recepcionista");
            RolSelector rs = new RolSelector(list);
            rs.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           guestABM abm = new guestABM(this.logged_user as UserRecepsionist);
           abm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMHotel_Menu abm = new ABMHotel_Menu();
            abm.Show();
        }

       
        
    }
}
