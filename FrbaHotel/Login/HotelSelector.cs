using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FrbaHotel.Model;
using System.Windows.Forms;

namespace FrbaHotel.Login
{
    public partial class HotelSelector : Form
    {
        private List<CheckBox> cb_list = new List<CheckBox>();
        private Hotel hotel = new Hotel();

        public HotelSelector()
        {
            InitializeComponent();
        }

        public HotelSelector(List<Object> hotels) {
            int pos = 0;
            foreach (Hotel hotel in hotels)
            {
                CheckBox cb = new CheckBox();
                cb.Text = hotel.getName();
                cb.Location = new System.Drawing.Point(20, 20 + pos);
                cb_list.Add(cb);
                Controls.Add(cb);

                pos += 30;
            }
            InitializeComponent();
        
        }
        private void HotelSelector_Load(object sender, EventArgs e)
        {

        }


        public String getSelectedHotel()
        {
            return this.hotel.getName();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {
                int checks = 0;
                foreach (CheckBox cb in cb_list)
                {
                    if (cb.Checked)
                    {
                        checks++;
                        this.hotel.setName(cb.Text);
                    }
                }
                if (checks > 1 || checks == 0)
                {
                    throw new Exception("Debe seleccionar 1 hotel");
                }
                else {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    
    }
}
