using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient; 
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.Model
{
            
    class DataBase
    {
        private SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2008;Initial Catalog=GD2C2014;Persist Security Info=True;User ID=sa;Password=gestiondedatos");
      
        public DataBase() { }

        public void openConnection() {
            conexion.Open();
        }

        public void closeConnection() { conexion.Close(); }
        
        public DataTable select_query(String query) {

            try
            {
                conexion.Open();
                SqlCommand queryCommand = new SqlCommand(query, conexion);
                SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(queryCommandReader);
                conexion.Close();
                return dataTable;
            }
            catch (Exception ex) {
                MessageBox.Show("Fallo al ejectuar la query : "+ query);
            }

            return new DataTable();  
        }

        public void insert_query(String query) {

            conexion.Open();
            SqlCommand queryCommand = new SqlCommand(query, conexion);
            conexion.Close();
        }



        public void connect(){
            try
            {
                string query = String.Format("select top 1 * from gd_esquema.usuarios;");
                conexion.Open();
                SqlCommand queryCommand = new SqlCommand(query, conexion);
                SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                                // Use the DataTable.Load(SqlDataReader) function to put the results of the query into a DataTable.
                dataTable.Load(queryCommandReader);

                // Columnas - Imprimo el nombre de las columnas
                String columns = string.Empty;
                foreach (DataColumn column in dataTable.Columns)
                {
                    columns += column.ColumnName + " | ";
                }
                MessageBox.Show(columns);

                // Registros - Imprimo Por cada registro de la tabla
                int ColumnsCount = dataTable.Columns.Count;
                MessageBox.Show("Cantidad de rows: "+ColumnsCount.ToString());
                
                for (int i = 0; i < ColumnsCount; i++)
                {
                    String rowText = string.Empty;
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        rowText += dataTable.Rows[i][column.ColumnName] ;
                    }
                    MessageBox.Show(rowText);
                }
 
                conexion.Close();

                //MessageBox.Show(adapt.ToString());
            }
            catch (Exception ex)
            {

                 MessageBox.Show("me cabe");
            }        
        }

       
    }
}
