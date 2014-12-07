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
            monthCalendar1.Visible = false;
            monthCalendar1.MaxSelectionCount = 1;
            
            
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
            
            if(vacio==false){ //si no hay ningun campo vacio entonces seteo los campos del objeto hotel
            hotel.setName(textBox_nombre.Text);
            hotel.setEmail(textBox_mail.Text);
            hotel.setStars(Convert.ToInt32(estrellas.Value));
            hotel.setCity(textBox_ciudad.Text);
            hotel.setCountry(textBox_pais.Text);
            hotel.setTel(Convert.ToInt64(textBox_telefono.Text));
            hotel.setDireccion(textBox_direccion.Text);
            hotel.setFecha(Convert.ToDateTime(textBox_fecha.Text));

            foreach (int i in regimenes.CheckedIndices) {                
                hotel.setRegimenes(i);          //cargo los regimenes en una lista de int
            }
            
            
            hotel.inserta_Hotel(); //agrego el hotel a la base
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //Dia d = new Dia();
            //monthCalendar1.SetDate(d.Hoy());
                
            textBox_fecha.Text = monthCalendar1.SelectionStart.ToLongDateString();
            monthCalendar1.Visible = false;

        }
        private void textBox_fecha_TextChanged(object sender, EventArgs e)
        {
            textBox_fecha.Text = monthCalendar1.SelectionStart.ToString("dd-MM-yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dia d = new Dia();
            monthCalendar1.SetDate(d.Hoy());
            monthCalendar1.Show();
        }

        private void ABMHotel_Alta_Load(object sender, EventArgs e)
        {

        }



        
        

        
    }
}
