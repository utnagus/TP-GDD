using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Model;
using System.Data;
namespace FrbaHotel.Home
{
    class homeClient
    {
        private DataBase db = new DataBase();

        public List<Client> getClients()
        {
            List<Client> clients = new List<Client>();
            String query = "select top 5 * from qwerty.clientes a inner join qwerty.domicilio b on a.id_domicilio = b.id_domicilio;";
            DataTable dt = db.select_query(query);  
            
            /*CARGO VALORES DEL CLIENTE*/
            Dictionary<String,Object> values = new Dictionary<String,Object>() ;
            
            int rows = dt.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                foreach (DataColumn dc in dt.Columns) {
                    values[dc.ToString().ToLower()] = dt.Rows[i][dc];
                }

                Client client = new Client(values);
                clients.Add(client);                
                values = new Dictionary<string,object>();
            }

            return clients;
        }

        public List<Client> get_unavabile_clients(){
            List<Client> clients= new List<Client>();
            String query = "select top 10 * from qwerty.clientes_inhabilitados a inner join QWERTY.domicilio b on a.id_domicilio=b.id_domicilio;";
            DataTable dt = db.select_query(query);
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            int rows = dt.Rows.Count;
            for (int i = 0; i < rows; i++) {
                foreach (DataColumn dc in dt.Columns)
                { 
                    dic[dc.ToString().ToLower()] = dt.Rows[i][dc];
                }
                clients.Add(new Client(dic));
                dic = new Dictionary<string, object>();
            }
            
            return clients;      
        }

        public List<String> get_columns_headers() {
            String query = "select top 1 * from qwerty.clientes_inhabilitados;";
            List<String> headers = new List<String>();
            DataTable dt = db.select_query(query);
            foreach (DataColumn dc in dt.Columns)
            { 
                headers.Add(dc.ToString());
            }

            return headers;
        }
        public void set_avaible_clients(List<Client> clients) {
            foreach (Client client in clients)
                client.setYouUP();
        }

        public DataTable get_docs() {
            String query_combobox = "select distinct b.descripcion as doc from qwerty.clientes_inhabilitados a inner join qwerty.tipo_doc b on a.tipo_doc = b.tipo_doc_id;";
            DataTable dt = db.select_query(query_combobox);
            return dt;
        }
    }
}
