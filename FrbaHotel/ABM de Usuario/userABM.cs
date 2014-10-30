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
        private User lb_selected_user = new User();
        
        private List<User> listBox_users = new List<User>();

        public userABM()
        {
            InitializeComponent();
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

                this.fillGridView(lb_selected_user);
                btn_delete.Enabled = true;
                btn_edit.Enabled = true;
                
            }
            else {
            
                btn_delete.Enabled = false;
                btn_edit.Enabled = false;
            
            }
        }

        private void fillGridView(User selected_user) { 
            //BUSCAR LOS DATOS DEL USUARIO Y AGREGARO A LA GRIDVIEW
        }


        //Obtengo todos los usuarios y los agrego al listBox
        //Los usuarios solo deben ser los que esten en el mismo hotel que
        // el admin que este usando esta abm
        private void fillWindowOnCreate(){
            
            DataTable users_table = home_db.getUsersList(this.logged_admin); //cambie la query username por *
            lb_users.Items.Clear();
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            
            foreach (DataColumn dc in users_table.Columns)
            {

                int rows = users_table.Rows.Count;
                for (int i = 0; i < rows; i++)
                    dic[dc.ToString().ToLower()] = users_table.Rows[i][dc];
            }
            lb_users.Items.Add(dic["username"]);
            
            //creo el usuario con el diccionario que me traje
            User user = new User(dic);
            
            // lo agrego a un array local asi userABM tiene una array de usuarios
            listBox_users.Add(user);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.addNewUser add_form = new ABM_de_Usuario.addNewUser();
            add_form.Show();
            add_form.setParent(this);
        }

        public void setLoggedAdmin(User admin) {
            this.logged_admin = admin;
        }

        public void addUsersToGrid(User user) {
           dgv_users.Rows.Add(user.getName(),user.getLastName(),user.getMail(),user.getHotel());
        }

        public void addUser_to_listBox(User user) {
            lb_users.Items.Add(user.getUserName());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
             //ELIMINAR LA ROW DE LA GRIDVIEW 
             String selected_user = lb_users.GetItemText(lb_users.SelectedItem);
             lb_users.Items.Remove(lb_users.SelectedItem);            
             
             //INSERTAR EN UNA TABLA LOS USUARIOS QUE SE DIERON DE BAJA(BAJA LOGICA) 
             User user = new User();
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
