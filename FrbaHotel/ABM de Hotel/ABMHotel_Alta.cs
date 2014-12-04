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
        public bool vacio;
        private void validar(Form form) { 
        foreach (Control cont in form.Controls){
            if (cont is TextBox && (cont.Text == String.Empty)){ vacio = true; }
        }
        if (vacio == true) { MessageBox.Show("Por favor llene todos los campos"); }

        if (regimenes.CheckedItems.Count < 1) { vacio = true; MessageBox.Show("Por favor complete el/los regimenes deseados"); }
        
        }
        
        private Hotel hotel = new Hotel();
        private void button1_Click(object sender, EventArgs e)
        {
            vacio = false;
            validar(this);
            
            if(vacio==false){
            hotel.setName(textBox_nombre.Text);
            hotel.setEmail(textBox_mail.Text);
            hotel.setStars(Convert.ToInt32(estrellas.Value));
            hotel.setCity(textBox_ciudad.Text);
            hotel.setCountry(textBox_pais.Text);
            hotel.setTel(Convert.ToInt64(textBox_telefono.Text));
            hotel.setDireccion(textBox_direccion.Text);
            /*hotel.setRegimenes(textBox_regimenes.Text);
            hotel.setCreation_date(textBox_fecha.Text);*/

            /* aca tengo qe agregar la logica para cheqear que los campos sean cargados con
             los tipo de datos qe tienen qe ser*/

            /*hotel.inserta_Hotel(hotel.getName, hotel.getEmail, hotel.getTel, hotel.getDir, hotel.getStars, hotel.getCity, hotel.getCountry, hotel.getCreation_date);*/
            foreach (int i in regimenes.CheckedIndices) 
            {                
                hotel.setRegimenes(i);
                //MessageBox.Show("el valor es" +i);
                
            }
            
            //hotel.inserta_Hotel(textBox_nombre.Text, textBox_mail.Text, Convert.ToInt64(textBox_telefono.Text), textBox_direccion.Text, Convert.ToInt32(estrellas), textBox_ciudad.Text, textBox_pais.Text, Convert.ToDateTime(textBox_fecha.Text));
            hotel.inserta_Hotel();
            this.Close();
            }

            
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

        
        private void textBox_nombre_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != ',') && (e.KeyChar != ' '))
            {
                MessageBox.Show("Solo se permiten letras, digitos y el uso de la coma(,)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_mail_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != '@') && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros, letras y @", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_direccion_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != ',') && (e.KeyChar != ' '))
            {
                MessageBox.Show("Solo se permiten letras, digitos y el uso de la coma(,)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_ciudad_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar))  && (e.KeyChar != ' '))
            {
                MessageBox.Show("Solo se permiten letras, digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox_pais_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != ' '))
            {
                MessageBox.Show("Solo se permiten letras, digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        
        

        
    }
}
