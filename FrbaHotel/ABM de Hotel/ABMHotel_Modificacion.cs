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
    public partial class ABMHotel_Modificacion : Form
    {

        public ABMHotel_Modificacion()
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

            dt = coneccionHotel.dameTodosLosHoteles(textBoxname.Text, textBoxestrellas.Text, textBoxciudad.Text, textBoxpais.Text);
            bsource.DataSource = dt;
            dataGridView1.DataSource = bsource;
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
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


      

        private void button3_Click_1(object sender, EventArgs e)
        {

            Int32 id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Listado_Modificacion frm = new Listado_Modificacion(id);


            frm.textBox_nombre.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textBox_mail.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.textBox_telefono.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.textBox_direccion.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.estrellas.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.textBox_ciudad.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.textBox_pais.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.monthCalendar1.SelectionStart = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[8].Value.ToString());
            frm.textBox_fecha.Text = frm.monthCalendar1.SelectionStart.ToString("dd-MM-yyyy");
            



            Hotel hotel = new Hotel();
            DataTable dt = hotel.buscameRegimenes(id); /*busco los regimenes que tiene el hotel*/
            foreach (DataRow row in dt.Rows)
            {//cargo los regimenes que tiene en el checkedBoxList
                frm.regimenes.SetItemChecked((Convert.ToInt32(row[1])) - 1, true);
            }


            if (Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[9].Value) == 1) { frm.radioButton1.Checked = true; }
            else { frm.radioButton2.Checked = true; }


            frm.Show();

        }
    }
}