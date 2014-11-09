using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Model;
namespace FrbaHotel.ABM_de_Cliente
{
    public partial class guestABM : Form
    {
        private UserRecepsionist user = new UserRecepsionist();
        public guestABM()
        {
            InitializeComponent();
        }

        public guestABM(User user)
        {
            InitializeComponent();
            this.user = user as UserRecepsionist;
        }


        private void guestABM_Load(object sender, EventArgs e)
        {
            //EL MAIL ES UNICO, SI QUIERE AGREGAR UN MAIL EXISTENTE DEBE APARECER
            // UN POPUP QUE AVISE QUE NO SE PUEDE

            //
        }
    }
}
