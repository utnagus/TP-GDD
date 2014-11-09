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
            //ALTA LOGICA (si es que no existe aun)
            Dictionary<String, Object> values = this.getFildsValues();
            UserRecepsionist new_client = new UserRecepsionist(values);

            this.Close();
        }

        private Dictionary<String, Object> getFildsValues()
        {
            return new Dictionary<String, Object>;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
