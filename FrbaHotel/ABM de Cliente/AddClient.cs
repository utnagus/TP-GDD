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
namespace FrbaHotel.ABM_de_Cliente
{
    public partial class AddClient : Form
    {        
        public AddClient()
        {
            InitializeComponent();
            this.fillComboBoxes();
        }

        private void fillComboBoxes()
        {

            /*AGREGO TIPOS DE DOCUMENTOS*/
            cb_docs.Items.Add("DNI");
            cb_docs.Items.Add("DNI Extranjero");
            cb_docs.SelectedIndex = 0;

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {
                //ALTA LOGICA (si es que no existe aun)
                Dictionary<String, Object> values = this.getFildsValues();
                UserRecepsionist new_client = new UserRecepsionist(values);

                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Campo incompleto",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Dictionary<String, Object> getFildsValues(){
            
            Dictionary<String, Object> values = new Dictionary<String, Object>();
          
                foreach (Control tb in this.Controls)
                {
                    String control = tb.GetType().Name;
                    
                    if (control.Contains("TextBox") || control.Contains("ComboBox"))
                    {
                        if (tb.Text == "")
                            throw new Exception("Todos los campos deben estar llenos, porfavor completelos");
                        
                        /*Obtengo los valores de los textbox*/
                        if (tb.Name.Contains("txt_")) { 
                            String name = tb.Name;
                            String key = tb.Name.Substring(4, name.Length - 4); // el textbox tiene que llamarse igual que el atributo
                            String value = tb.Text;

                            values[key.ToLower()] = value;
                        }    
                    }


                }
            
             
            return values;
        
        
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
