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
    public partial class ABMHotel : Form
    {

        public ABMHotel()
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
            
            dt = coneccionHotel.dameListadoHoteles2();
            bsource.DataSource = dt;
            dataGridView1.DataSource = bsource;

        }
    }
}
