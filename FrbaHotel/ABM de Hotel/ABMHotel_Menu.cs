﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class ABMHotel_Menu : Form
    {
        public ABMHotel_Menu()
        {
            InitializeComponent();
        }

        private void ABMHotel_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button_Listado_Click(object sender, EventArgs e)
        {
            ABMHotel_Listado abm = new ABMHotel_Listado();
            abm.Show();
        }

        private void button_Alta_Click(object sender, EventArgs e)
        {
            ABMHotel_Alta abm = new ABMHotel_Alta();
            abm.Show();
        }

        private void button_Modificacion_Click(object sender, EventArgs e)
        {
            ABMHotel_Modificacion abm = new ABMHotel_Modificacion();
            abm.Show();
        }

        private void button_Baja_Click(object sender, EventArgs e)
        {
            ABMHotel_Baja abm = new ABMHotel_Baja();
            abm.Show();
        }
    }
}
