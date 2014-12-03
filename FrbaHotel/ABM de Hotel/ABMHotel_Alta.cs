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
    public partial class ABMHotel_Alta : Form
    {
        public ABMHotel_Alta()
        {
            InitializeComponent();
        }

        private Hotel hotel = new Hotel();
        private void button1_Click(object sender, EventArgs e)
        {
            hotel.setName(textBox_nombre.Text);
            hotel.setEmail(textBox_mail.Text);
            hotel.setStars(Convert.ToInt32(textBox_estrellas.Text));
            hotel.setCity(textBox_ciudad.Text);
            hotel.setCountry(textBox_pais.Text);
            hotel.setTel(Convert.ToInt64(textBox_telefono.Text));
            hotel.setDireccion(textBox_direccion.Text);
            /*hotel.setRegimenes(textBox_regimenes.Text);
            hotel.setCreation_date(textBox_fecha.Text);*/

            /* aca tengo qe agregar la logica para cheqear que los campos sean cargados con
             los tipo de datos qe tienen qe ser*/

            /*hotel.inserta_Hotel(hotel.getName, hotel.getEmail, hotel.getTel, hotel.getDir, hotel.getStars, hotel.getCity, hotel.getCountry, hotel.getCreation_date);*/
            hotel.inserta_Hotel(textBox_nombre.Text, textBox_mail.Text, Convert.ToInt64(textBox_telefono.Text), textBox_direccion.Text, Convert.ToInt32(textBox_estrellas.Text), textBox_ciudad.Text, textBox_pais.Text, Convert.ToDateTime(textBox_fecha.Text));



        }

        private void textBox_telefono_TextChanged(object sender,  KeyPressEventArgs  e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_estrellas_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        
    }
}
