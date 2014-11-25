using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Model;
using FrbaHotel.Home;
namespace FrbaHotel.ABM_de_Usuario
{
    public partial class edit_window : Form
    {
        private User _user = null;
        public edit_window()
        {
            InitializeComponent();
        }

        public edit_window(User user)
        {
            InitializeComponent();
            this._user = user;
            this.fillFildsOnCreate(user);
        }

        private void fillFildsOnCreate(User user) {
            
            txt_date.Text =user.getDate().ToString();
            txt_dir.Text = user.getAddress().ToString();
            txt_doc.Text = user.getDocument().ToString();
            txt_lastname.Text = user.getLastName().ToString();
            txt_name.Text = user.getName().ToString();
            txt_nickname.Text =user.getUserName().ToString();
            txt_pass.Text = user.getPassword().ToString();
            txt_telephone.Text = user.getTelephone().ToString();
            txt_mail.Text = user.getMail().ToString();
            txt_dir.Text = user.getAddress().getName().ToString();
            txt_direction.Text = user.getAddress().getDirection().ToString();
            txt_floor.Text = user.getAddress().getFloor().ToString();
            txt_department.Text = user.getAddress().getDepartment().ToString();
            cb_docs.Text = "DNI";
            cb_hotel.Text = user.getLoggedHotel().getName();
            cb_rol.Text = user.getRol().ToString();
            
        }
        private void fillUserWithFilds() {
            _user.getLoggedHotel().setName(cb_hotel.Text);
            _user.setRol(cb_rol.Text);
            _user.setUsername(txt_name.Text);
            _user.setPassword(txt_pass.Text);
            address user_address = new address();
            if(txt_department != null)
                user_address.setDepartment(txt_department.Text);
            user_address.setDirection(int.Parse(txt_direction.Text));
            user_address.setName(txt_dir.Text);
            if (txt_floor != null)
                user_address.setFloor(int.Parse(txt_floor.Text));
            _user.setAddress(user_address);
            _user.setDate(DateTime.Parse(txt_date.Text));
            _user.setDocument(int.Parse(txt_doc.Text));
            _user.setMail(txt_mail.Text);
            _user.setTelephone(int.Parse(txt_telephone.Text));
                        
        }
        private void edit_window_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            //HACER UPDATE SOBRE TALBA USUARIOS, HOTELES Y PERSONA HOTELES
            confirmUpdateWindow window = new confirmUpdateWindow(this);
            window.ShowDialog();

            this.Close();
        }

        public void update_user() {
            this.fillUserWithFilds();
            homeDB home = new homeDB();
            home.update_user(_user);
        }
    }
}
