using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Model;
using FrbaHotel.ABM_de_Usuario;
using FrbaHotel.Home;
namespace FrbaHotel.ABM_de_Cliente
{
    public partial class guestABM : Form
    {
        private UserRecepsionist user = new UserRecepsionist();
        private homeClient home_client = new homeClient();
        private List<Client> clients= new List<Client>();
        public guestABM()
        {
            InitializeComponent();
        }

        public guestABM(User user)
        {
            InitializeComponent();
            this.fillClientListBoxOnCreate();
            this.user = user as UserRecepsionist;
        }

        private void fillClientListBoxOnCreate() {
            clients = home_client.getClients();
            foreach (Client client in clients) {
                lb_clients.Items.Add(client.getName());
            }             
        
        }

        private void guestABM_Load(object sender, EventArgs e)
        {
            //EL MAIL ES UNICO, SI QUIERE AGREGAR UN MAIL EXISTENTE DEBE APARECER
            // UN POPUP QUE AVISE QUE NO SE PUEDE

            //
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            AddClient wclientAdd = new AddClient();
            wclientAdd.Show();
        }

        private void btn_avaible_client_Click(object sender, EventArgs e)
        {
            //DEBO PODER AGARRAR CLIENTES EN LA TABLA CLIENTES INHABILITADOS Y PODER VOLVER A HABILITARLOS
            Avaible_Users abm = new Avaible_Users();
            abm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unavaible_users abm = new Unavaible_users();
            abm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String client = lb_clients.SelectedItem.ToString();
            Client new_client = new Client();
            bool founded = false;
            int i = 0;
            while (i < clients.Count && !founded)
            {
                if (clients[i].getName().Equals(client))
                {
                    new_client = clients[i];
                    founded = true;
                }
                i++;
            }

            new_client.setYouDOWN();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            String client = lb_clients.SelectedItem.ToString();
            Client new_client = new Client();
            bool founded = false;
            int i = 0;
            while(i < clients.Count && !founded){
                if (clients[i].getName().Equals(client)) {
                    new_client = clients[i];
                    founded = true;
                }
                i++;                    
            }
            EditClient editW = new EditClient(new_client);
            editW.Show();
        }
    }
}
