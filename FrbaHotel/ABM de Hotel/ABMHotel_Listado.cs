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
    public partial class ABMHotel_Listado : Form
    {

        public ABMHotel_Listado()
        {
            InitializeComponent();
        }

        private void ABMHotel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dataGridView1.DataSource = null;
        }
    }
}
