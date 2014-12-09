using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Home;
using FrbaHotel.Model;
namespace FrbaHotel.ABM_de_Cliente
{
    public partial class Unavaible_users : Form
    {
        homeClient home_client = new homeClient();
        BindingSource bs = new BindingSource();
        
        public Unavaible_users()
        {
            InitializeComponent();
            fillGridOnCreate();
        }

        private void fillGridOnCreate() {
            //Cargo ComboBox con distintos tipos de doc
            DataTable dt_docs = home_client.get_docs();
            for (int i = 0; i < dt_docs.Rows.Count; i++)
            {
                cb_id.Items.Add(dt_docs.Rows[i]["doc"]);
            }

            
/*            //Cargo las columnas del DataGridView
            List<String> headers = new List<String>();
            headers = home_client.get_columns_headers();
            foreach (String header in headers) {
                DataGridViewColumn col = new DataGridViewColumn();
                col.HeaderText = header;
                col.CellTemplate = new DataGridViewTextBoxCell();
               dgv_clients.Columns.Add(col);
               
            }
            */
            //Obtengo los clientes
            List<Client> clients = home_client.get_unavabile_clients();
            
            foreach(Client client in clients){
                dgv_clients.Rows.Add(client.getName(), client.getLastName(), "DNI", client.getDocument(), client.getMail());
            }
        }

        

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Unavaible_users_Load(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            Dictionary<String, String> filters = new Dictionary<String, String>();
            try
            {
                //Valido si textBox documento tiene solo numeros
                int n;
                if(txt_id.Text != ""){
                    if (int.TryParse(txt_id.Text, out  n))
                    {
                        filters["nro_doc"] = txt_id.Text;
                    }
                    else
                    {
                        throw new Exception("El campo documento no puede tener letras");
                    }
                }
                

                //Valido que textBox nombre solo sea de letras
                if(txt_name.Text != "" ){
                    if (!hasNumber(txt_name.Text))
                    {
                        filters["nombre"] = txt_name.Text;
                    }
                    else
                    {
                        throw new Exception("El campo nombre no puede tener numeros");
                    }
                }
                //Valido que textBox apellido solo sea de letras
                if(txt_lastname.Text != "" ){
                    if (!hasNumber(txt_name.Text))
                    {
                        filters["apellido"] = txt_lastname.Text;
                    }
                    else {
                        throw new Exception("El campo apellido no puede tener numeros");
                    }
                }
                //Valido que textBox email solo sea de letras
                if (txt_email.Text != "")
                {
                    filters["email"] = txt_email.Text;
                }

                if (cb_id.SelectedText.ToString() != "")
                    filters["tipo_doc"] = cb_id.SelectedItem.ToString();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Campo mal cargado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            //FILTRA ROWS
            foreach(String column in filters.Keys) {
                int i;
                for(i=0;i < dgv_clients.Rows.Count -1 ; i++){
                   var filter = filters[column]; 
                   var value=  dgv_clients.Rows[i].Cells[column].FormattedValue.ToString();

                   if (column.ToLower() == "nombre" || column.ToLower() == "apellido" || column.ToLower() == "nro_doc" || column.ToLower() == "email" || column.ToLower() == "tipo_doc")
                   {
                        if (value.ToString().ToLower().Contains(filter))
                        {
                            if (dgv_clients.Rows[i].Visible)
                                dgv_clients.Rows[i].Visible = true;
                        }
                        else {
                            dgv_clients.Rows[i].Visible = false;
                        }
                   }
                                   
                 }
             }
                
           }
        

         private bool hasNumber(String text)
        {
            foreach (char c in text) {
                if (char.IsNumber(c)) {
                    return true;
                }
            }
            return false;
        }

         private void btn_clean_Click(object sender, EventArgs e)
         {
             foreach (DataGridViewRow row in dgv_clients.Rows)
                 row.Visible = true;
         }

         private void btn_unavaible_Click(object sender, EventArgs e)
         {
             Dictionary<String, Object> dic = new Dictionary<String, Object>();
             Client client = new Client();
             if (dgv_clients.SelectedRows.Count == 1) { 
                 int rowindex = dgv_clients.CurrentCell.RowIndex;
                 client.setName(dgv_clients.Rows[rowindex].Cells[0].Value.ToString());
                 client.setLastName(dgv_clients.Rows[rowindex].Cells[1].Value.ToString());
                 dic["tipo_doc"] = dgv_clients.Rows[rowindex].Cells[2].Value.ToString();
                 client.setDocument((int)dgv_clients.Rows[rowindex].Cells[3].Value);
                 client.setMail(dgv_clients.Rows[rowindex].Cells[4].Value.ToString());
             }

             client.setYouDOWN();
         }
      }
        
    }

