using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Model;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class ABMHabitacion_Modificacion : Form
    {
        public ABMHabitacion_Modificacion()
        {
            InitializeComponent();
            
        }
       

        

        private void ABMHabitacion_Modificacion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Habitacion coneccionHab = new Habitacion();
            BindingSource bsource = new BindingSource();
            
            dt = coneccionHab.dameTodosLasHabitaciones(textBox_nro.Text,textBox_piso.Text,textBox_ubic.Text,textBox_desc.Text,textBox_nombre.Text,textBox_tipo.Text);
            bsource.DataSource = dt;
            dataGridView1.DataSource = bsource;
            this.dataGridView1.AllowUserToAddRows = false;//para q nadie agregue filas
            this.dataGridView1.Columns[0].Visible = false;//id de habitacion
            this.dataGridView1.Columns[1].Visible = false;// id de tipo de habitacion
            
        }
       

       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox_desc.Clear();
            textBox_nro.Clear();
            textBox_piso.Clear();
            textBox_ubic.Clear();
            textBox_nombre.Clear();
            textBox_tipo.Clear();
            
            dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 id_hab = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Int32 id_tipo = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            ABMHabitacion_Listado_Modificacion abmlist = new ABMHabitacion_Listado_Modificacion(id_hab,id_tipo);

            abmlist.textBox_nro.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            abmlist.textBox_piso.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            abmlist.textBox_desc.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if (this.dataGridView1.CurrentRow.Cells[4].Value.ToString() == "N") { abmlist.radioButton1.Checked = true; }
            else { abmlist.radioButton2.Checked = true; }

            abmlist.Show();
              
            
        }
    }
}
