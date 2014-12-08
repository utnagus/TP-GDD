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
    public partial class ABMHabitacion_Alta : Form
    {
        public ABMHabitacion_Alta()
        {
            InitializeComponent();
            llenarComboBoxNombres();
            llenarComboBoxTipos();
        }
        char ubicacion;
        
        private void ABMHabitacion_Listado_Load(object sender, EventArgs e)
        {

        }

        public class Item {//creo una clase Item donde voy a agregar los nombres de los hoteles junto con sus ids
            public string Name { get; set; }
            public int Value { get; set; }

            public Item(string name, int value) {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        
        private void llenarComboBoxNombres() {
            List<Item> lista = new List<Item>();
            

            DataTable dt =    new DataTable();
            Hotel coneccionHotel = new Hotel();
            dt = coneccionHotel.dameListadoHotelesEstado01(null, null, null, null,1);
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Item(row[1].ToString(),row.Field<int>(0)));
            }
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = lista;
        }

        private void llenarComboBoxTipos(){
            List<Item> lista = new List<Item>();


            DataTable dt = new DataTable();
            Habitacion coneccionHabitacion = new Habitacion();
            dt = coneccionHabitacion.dameTiposHabitaciones();
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Item(row[1].ToString(), row.Field<int>(0)));
            }
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Value";
            comboBox2.DataSource = lista;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private bool vacio;
        private void validar(Form form)
        {
            foreach (Control cont in form.Controls)
            {
                if (cont is TextBox && (cont.Text == String.Empty)) { vacio = true; }
            }
            if (vacio == true) { MessageBox.Show("Por favor llene todos los campos"); }


            if ((radioButton1.Checked == false) && (radioButton2.Checked == false)) { vacio = true; MessageBox.Show("Elija ubicacion por favor"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habitacion hab = new Habitacion();
            Hotel hotel = new Hotel();
            
            vacio = false;
            validar(this);

            if (vacio == false)
            {
                // aca tengo el id Convert.ToInt32(comboBox1.SelectedValue.ToString())
                // aca tengo el nro de habitacion 
                // tengo que buscar el nro de habitacion con el id y ver si ya existen
                if (hab.existe_Habitacion(Convert.ToInt32(comboBox1.SelectedValue.ToString()), Convert.ToInt32(textBox_Nro.Text)) == false)
                {
                    hab.setId(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
                    hab.setNro(textBox_Nro.Text);
                    hab.setPiso(textBox_Piso.Text);
                    hab.setTipo(Convert.ToInt32(comboBox2.SelectedValue.ToString()));
                    hab.setDescripcion(textBox_desc.Text);
                    hab.setUbicacion(ubicacion);

                    hab.inserta_Habitacion();
                    this.Close();
                }
                else { MessageBox.Show("No puede ingresar el nro de habitacion "+Convert.ToInt32(textBox_Nro.Text)+" porque ya existe"); }
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ubicacion = 'N';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ubicacion = 'S';
        }

        private void textBox_Nro_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_Piso_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void textBox_desc_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) &&  (e.KeyChar != ' '))
            {
                MessageBox.Show("Solo se permiten letras, digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
