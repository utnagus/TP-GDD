using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class ABMHabitacion_Menu : Form
    {
        public ABMHabitacion_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABMHabitacion_Alta abm = new ABMHabitacion_Alta();
            abm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMHabitacion_Baja abm = new ABMHabitacion_Baja();
            abm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMHabitacion_Modificacion abm = new ABMHabitacion_Modificacion();
            abm.Show();
        }
    }
}
