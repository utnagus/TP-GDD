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
    public partial class userABM : Form
    {
        private homeDB home_db = new homeDB();
        private User logged_admin = new User();

        public userABM()
        {
            InitializeComponent();
            fillWindowOnCreate();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void lb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }

        //Obtengo todos los usuarios y los agrego al listBox
        //Los usuarios solo deben ser los que esten en el mismo hotel que
        // el admin que este usando esta abm
        public void fillWindowOnCreate()
        {
            
            DataTable users_table = home_db.getUsersList();
            lb_users.Items.Clear();

            int RowCount = users_table.Rows.Count;
            for (int i = 0; i < RowCount; i++)
            {
                foreach (DataColumn column in users_table.Columns)
                {
                    lb_users.Items.Add(users_table.Rows[i][column.ColumnName]);
                }
            }
            
        
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form add_form = new ABM_de_Usuario.addNewUser();
            add_form.Show();
        }

        public void setLoggedAdmin(User admin) {
            this.logged_admin = admin;
        }

    }
}
