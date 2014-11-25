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
    public partial class edition_window : Form
    {
        private userABM parent = new userABM();

        public edition_window()
        {
            InitializeComponent();
            this.fillComboBoxes();
        }

        public void setParent(userABM parent) {
            this.parent = parent;
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
                User user = new UserAdmin(values);

                
                //PASSWORD ENCRIPTADA
                Console.WriteLine("Falta encriptar password");
                
                //LE DIGO A LA AMB USER QUE LO AGREGUE        
                //AGREGAR A LA LISTA DE USUARIOS
                //GRABO EN TABLA
                parent.addUser_to_listBox(user);

                this.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Campo incompleto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Dictionary<String,Object> getAllTextBoxsValues() {

            Dictionary<String, Object> values = new Dictionary<String, Object>();
            values["username"] = txt_nickname.Text;
            values["telefono"] = int.Parse(txt_telephone.Text);
            values["nombre"] = txt_name.Text;
            values["apellido"] = txt_lastname.Text;
            values["direccion"] = txt_dir.Text;
            values["altura"] = txt_direction.Text;
            values["piso"] = txt_floor.Text;
            values["departamento"] = txt_department.Text;
            values["rol"] = cb_rol.SelectedItem.ToString();
            values["password"] = txt_pass.Text;
            values["hotel"] = cb_hotel.SelectedItem.ToString();
            values["fecha_nacimiento"] = DateTime.Parse(txt_date.Text);
            values["dni"] = int.Parse(txt_doc.Text);
            values["mail"] = txt_mail.Text;
            
            foreach (var key in values.Keys) {
                if (key != "piso" & key != "departamento")
                {
                    var value = values[key];
                    if (value.Equals("") || value == null)
                    {
                        throw new Exception("El campo " + "'" + key + "'" + " no puede estar vacio");
                    }
                }
            } 
           
            return values;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
