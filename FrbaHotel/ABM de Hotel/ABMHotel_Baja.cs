using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using FrbaHotel.Model;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class ABMHotel_Baja : Form
    {

        public ABMHotel_Baja()
        {
            InitializeComponent();
        }

        private void ABMHotel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (e.ColumnIndex ==10) //es la columna donde esta el boton de eliminar
            {
                //check if anything needs to be validated here
                //Form1 f = new Form1();
                coneccionHotel.setId(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                coneccionHotel.delete_Hotel();
                dt = coneccionHotel.dameListadoHotelesEstado01(textBoxname.Text, textBoxestrellas.Text, textBoxciudad.Text, textBoxpais.Text, 1);
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
                
                dataGridView1.Refresh();  
                
                

                  

            }
        }

        new DataTable dt;
        private Hotel coneccionHotel = new Hotel();
        BindingSource bsource = new BindingSource();

        

        private void button1_Click(object sender, EventArgs e)
        {

            dt = coneccionHotel.dameListadoHotelesEstado01(textBoxname.Text, textBoxestrellas.Text, textBoxciudad.Text, textBoxpais.Text,1);
            bsource.DataSource = dt;
            dataGridView1.DataSource = bsource;
            this.dataGridView1.Columns[0].Visible = false; //oculto columna id
            this.dataGridView1.Columns[9].Visible = false; //oculto columna estado
            this.dataGridView1.AllowUserToAddRows = false;//si no pongo esto me agrega una ultima fila editable

            DataGridViewButtonColumn col = new DataGridViewButtonColumn(); //agrego la columna con el boton eliminar
            col.UseColumnTextForButtonValue = true;
            col.Name = "Eliminar";
            col.HeaderText = "Eliminar";
            col.Text = "Eliminar";
            dataGridView1.Columns.Add(col);

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxciudad.Clear();
            textBoxestrellas.Clear();
            textBoxname.Clear();
            textBoxpais.Clear();
            dataGridView1.Columns.Clear();
        }
    }
}
