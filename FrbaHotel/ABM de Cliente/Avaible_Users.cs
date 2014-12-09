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
    public partial class Avaible_Users : Form
    {
        homeClient home_client = new homeClient();
        List<Client> _clients_avaibles = new List<Client>();
        List<Client> _clients_unavaibles = new List<Client>();
        public Avaible_Users()
        {
            InitializeComponent();
            this.fillUnavabilesOnCreate();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Obtengo los clientes inhabilitados*/
        private void fillUnavabilesOnCreate(){
            _clients_unavaibles = home_client.get_unavabile_clients();
            foreach (Client client in _clients_unavaibles)
            {
                lb_unavaible.Items.Add(client.getName());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String client = lb_unavaible.GetItemText(lb_unavaible.SelectedItem);
            int i=0;
            bool founded = false;
            while(i<_clients_unavaibles.Count && !founded){
                if (_clients_unavaibles[i].getName().Equals(client))
                    founded = true;
                else
                    i++;
            }
            //agrego el cliente al listBox habilitados y a un array de habilitados
            lb_avaible.Items.Add(client);
            _clients_avaibles.Add(_clients_unavaibles[i]);

            //saco al cliente del listBox inhabilitados y saco del array de inhabilitados
            lb_unavaible.Items.Remove(client);
            _clients_unavaibles.RemoveAt(i);
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String client = lb_avaible.GetItemText(lb_avaible.SelectedItem);
            int i = 0;
            bool founded = false;
            while (i < _clients_avaibles.Count && !founded)
            {
                if (_clients_avaibles[i].getName().Equals(client))
                    founded = true;
                else
                    i++;
            }
            
            lb_unavaible.Items.Add(client);
            _clients_unavaibles.Add(_clients_avaibles[i]);

            lb_avaible.Items.Remove(client);
            _clients_avaibles.RemoveAt(i);

        }

        /*Puedo confirmar solo si habilito usuarios*/
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lb_avaible.Items.Count != 0)
            {
                home_client.set_avaible_clients(_clients_avaibles);
                MessageBox.Show("Clientes habilitados satisfactoriamente", "Confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
                
            
            
        }

    }
}
