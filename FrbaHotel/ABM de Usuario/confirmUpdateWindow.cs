using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class confirmUpdateWindow : Form
    {
        private edit_window window_parent = new edit_window();

        public confirmUpdateWindow()
        {
            InitializeComponent();
        }
        public confirmUpdateWindow(edit_window parent)
        {
            InitializeComponent();
            this.window_parent = parent;
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            window_parent.update_user();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
