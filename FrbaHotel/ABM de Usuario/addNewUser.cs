using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Model;
namespace FrbaHotel.ABM_de_Usuario
{
    public partial class addNewUser : Form
    {
        private userABM parent = null;

        public addNewUser()
        {
            InitializeComponent();
            this.fillComboBoxes();
        }

        public void setParent(userABM parent) {
            this.Parent = parent;
        }

        private void fillComboBoxes() {
            
            /*AGREGO ROLES*/
            cb_rol.Items.Add("Administrador");
            cb_rol.Items.Add("Recepcionista");
            cb_rol.SelectedIndex = 0;
            
            /*AGREGO TIPOS DE DOCUMENTOS*/
            cb_docs.Items.Add("DNI");
            cb_docs.Items.Add("Libreta Civica");
            cb_docs.Items.Add("Libreta de Enrolamiento");
            cb_docs.Items.Add("CUIT");
            cb_docs.Items.Add("DNI Extranjero");
            cb_docs.SelectedIndex = 0; 
       
            /*AGREGO HOTELES*/
            cb_hotel.Items.Add("Hilton");
            cb_hotel.Items.Add("FrbaHotel");
            cb_hotel.Items.Add("Canton");
            cb_hotel.SelectedIndex = 0;
        }

        private void addNewUser_Load(object sender, EventArgs e)
        {

        }

        //Creo un nuevo usuario si todo esta Ok
        private void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<String, Object> values = new Dictionary<String, Object>();
                values = this.getAllTextBoxsValues();
                //CREO NUEVO USUARIO
                User user = new User(values);

                //LE DIGO A LA AMB USER QUE LO AGREGUE
                
                //PASSWORD ENCRIPTADA
                Console.WriteLine("Falta encriptar password");
                //GRABO EN TABLA
                user.setYouUP();

                //AGREGAR A LA LISTA DE USUARIOS
                parent.addUsersToGrid(user);
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Campo incompleto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Dictionary<String,Object> getAllTextBoxsValues() {

            Dictionary<String, Object> values = new Dictionary<String, Object>();
            values["nickname"] = txt_nickname.Text;
            values["telephone"] = txt_telephone.Text;
            values["name"] = txt_name.Text;
            values["lastname"] = txt_lastname.Text;
            values["address"] = txt_dir.Text;
            values["rol"] = cb_rol.SelectedItem.ToString();
            values["password"] = txt_pass.Text;
            values["hotel"] = cb_hotel.SelectedItem.ToString();
            //values["date"] = (DateTime)txt_date.Text.;
            values["document"] = txt_doc.Text;
            values["mail"] = txt_mail.Text;
            
            foreach (var key in values.Keys) {
                var value = values[key];
                if (value.Equals("") || value == null) {
                    throw new Exception("El campo " + "'" + key +"'"+ " no puede estar vacio");
                }
            } 
           
            return new Dictionary<String, Object>();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
