using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Model;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class EditClient : Form
    {
        private Client client = new Client();
        public EditClient()
        {
            InitializeComponent();
            
        }

        public EditClient(Client client)
        {
            this.client = client;
            InitializeComponent();
            this.fillOnCreate();
        }

        private void fillOnCreate() { 
            txt_apellido.Text = (string)client.getLastName();
            txt_dni.Text = (string)client.getDocument().ToString();
            txt_mail.Text = client.getMail();
            txt_nombre.Text = client.getName();
            txt_telefono.Text = client.getTelephone().ToString();
            txt_nacionalidad.Text = client.getNationality();
            txt_fech_nacimiento.Text =client.getDate().ToString();
            txt_direccion.Text = client.getAddress().getName();
            cb_docs.Text = "DNI";
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditClient_Load(object sender, EventArgs e)
        {

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            //HACER UPDATE EN LA TABLA CLIENTES
            this.Close();
        }
    }
}
