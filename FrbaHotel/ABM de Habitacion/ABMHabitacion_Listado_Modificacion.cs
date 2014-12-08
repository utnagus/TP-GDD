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
    public partial class ABMHabitacion_Listado_Modificacion : Form
    {
        public ABMHabitacion_Listado_Modificacion(int id_hab,int id_tipo)
        {
            InitializeComponent();
            llenarComboBoxTipos();
            this.id_hab = id_hab;
            this.id_tipo = id_tipo;
            
        }
        private int id_hab;
        private int id_tipo;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class Item
        {//creo una clase Item donde voy a agregar los nombres de los hoteles junto con sus ids
            public string Name { get; set; }
            public int Value { get; set; }

            public Item(string name, int value)
            {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        private void llenarComboBoxTipos()
        {
            List<Item> lista = new List<Item>();


            DataTable dt = new DataTable();
            Habitacion coneccionHabitacion = new Habitacion();
            dt = coneccionHabitacion.dameTiposHabitaciones();
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new Item(row[1].ToString(), row.Field<int>(0)));
            }
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Value";
            comboBox1.DataSource = lista;
            comboBox1.SelectedIndex = id_tipo;
        }
        private void ABMHabitacion_Listado_Modificacion_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
