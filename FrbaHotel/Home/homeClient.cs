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
    }
}
