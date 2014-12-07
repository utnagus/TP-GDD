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
            llenarComboBox();
        }

        private void ABMHabitacion_Listado_Load(object sender, EventArgs e)
        {

        }
        
        
        private void llenarComboBox() {
        DataTable dt =    new DataTable();
        Hotel coneccionHotel = new Hotel();
        dt = coneccionHotel.dameListadoHotelesEstado01(null, null, null, null,1);
        foreach (DataRow row in dt.Rows)
        {
            comboBox1.Items.Add(row[1]);
        }
        }
    }
}
