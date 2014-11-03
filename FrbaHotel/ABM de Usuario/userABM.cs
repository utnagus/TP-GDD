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
        private UserAdmin logged_admin = new UserAdmin();
        private UserAdmin lb_selected_user = new UserAdmin();
        
        private List<User> listBox_users = new List<User>();

        public userABM()
        {
            InitializeComponent();
            this.fillWindowOnCreate();
       
        }

        public userABM(User admin)
        {
            InitializeComponent();
            this.logged_admin = admin as UserAdmin;
            this.fillWindowOnCreate();

        }

        private void refreshWindow()
        {
            this.fillWindowOnCreate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ABRIR LA VENTANA DE EDICION
            editUser edition = new editUser();
            edition.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //MUESTRO LOS DATOS DEL USUARIO A LA TABLA (SI LO SELECCIONO)
        private void lb_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_selected_user.setUsername(lb_users.GetItemText(lb_users.SelectedItem));
            String selected_name = lb_selected_user.getUserName();

            if (selected_name != null && !selected_name.Equals(""))
            {

                Console.WriteLine("tocas en " + selected_name);
                User new_user = listBox_users.Find(user => user.getUserName().Equals(selected_name));
                this.addUsersToGrid(new_user);
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                
            }
            else {
            
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
            
            }
        }


        //Obtengo todos los usuarios y los agrego al listBox
        //Los usuarios solo deben ser los que esten en el mismo hotel que
        // el admin que este usando esta abm
        private void fillWindowOnCreate()
        {

            DataTable users_table = home_db.getUsersList(this.logged_admin); 
            lb_users.Items.Clear();

            foreach (DataColumn dc in users_table.Columns)
            {
                Dictionary<String, Object> dic = new Dictionary<String, Object>();
                int rows = users_table.Rows.Count;
                for (int i = 0; i < rows; i++)
                {
                    dic[dc.ToString().ToLower()] = users_table.Rows[i][dc];

                    lb_users.Items.Add(dic["username"]);
                    Dictionary<String, Object> values = home_db.getUserConfig((string)dic["username"], "");

                    //creo el usuario con el diccionario que me traje
                    User user = new UserAdmin(values);

                    // lo agrego a un array local asi userABM tiene una array de usuarios
                    listBox_users.Add(user);
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.addNewUser add_form = new ABM_de_Usuario.addNewUser();
            add_form.Show();
            add_form.setParent(this);
        }

       
        public void addUsersToGrid(User user) {
            dgv_users.Rows.Clear();
            dgv_users.Rows.Add(user.getUserName(),user.getName(),user.getLastName(),user.getMail(),user.getLoggedHotel());
        }

        public void addUser_to_listBox(User user) {
             //  lb_users.Items.Add(user.getUserName());
             //INSERTAR EN LA BASE Y HACER UN REFRESH
            user.setYouUP();
            this.refreshWindow();
            
        }

        

        private void btn_delete_Click(object sender, EventArgs e)
        {
             //ELIMINAR LA ROW DE LA GRIDVIEW 
             String selected_user = lb_users.GetItemText(lb_users.SelectedItem);
             lb_users.Items.Remove(lb_users.SelectedItem);            
             
             //INSERTAR EN UNA TABLA LOS USUARIOS QUE SE DIERON DE BAJA(BAJA LOGICA)
             //Elimina de la tabla usuarios y deberia eliminar en las asociadas 
             User user = new UserAdmin();
             user.setUsername(selected_user);
             user.setYouDown(); 
        
             //ELIMINAR DE LA TABLA DE USUARIOS
             //tener una tabla de historia de usuarios para cuando los demos de baja
             Console.WriteLine("Falta eliminar usuario de la tabla usuarios, queda en la tabla historica");   
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userABM_Load(object sender, EventArgs e)
        {

        }




       

    }
}
