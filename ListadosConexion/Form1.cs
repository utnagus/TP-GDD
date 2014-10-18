using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinica_Frba.NewFolder9
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=USUARIO-PC\\SQLSERVER2008;Initial Catalog=GD2C2013;Persist Security Info=True;User ID=sa;Password=gestiondedatos");
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (comboBox2.SelectedIndex)
            { 
                case 0:
                    string query = String.Format("select distinct top 5 COUNT(te.Nombre) Cantidad,te.Nombre  from ASDASD.Tipos_especialidades te join ASDASD.Especialidades_Medicas em on te.Tipo_Especialidad_ID=em.Tipo_Especialidad_ID join ASDASD.Profesionales_Especialidades pe on em.Especialidad_ID=pe.Especialidad_ID join ASDASD.Agendas a on pe.Profesional_ID=a.Profesional_ID join ASDASD.Turnos t on a.Agenda_ID=t.Agenda_ID join ASDASD.Turnos_Cancelados tc on t.Turno_ID=tc.Turno_ID group by te.Nombre order by Cantidad desc");
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataAdapter adapt = new SqlDataAdapter();
                    adapt.SelectCommand = cmd;
                    DataTable tabla = new DataTable();
                    adapt.Fill(tabla);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = tabla;
                    dataGridView1.DataSource = bsource;
                    adapt.Update(tabla);

                    conexion.Close();
                    break;
                case 1:
                    string query2 = String.Format("select distinct top 5  p.Persona_ID, SUM(Cantidad) as TotalBonos from ASDASD.Personas p join ASDASD.Compras c on p.Persona_ID=c.Afiliado_ID join ASDASD.Bonos b on c.Compra_ID=b.Compra_ID and b.Fecha_Prescripcion is not null and b.Fecha_Prescripcion < CONVERT(varchar,GETDATE(),126) group by p.Persona_ID order by TotalBonos desc");
                    conexion.Open();
                    SqlCommand cmd2 = new SqlCommand(query2, conexion);
                    SqlDataAdapter adapt2 = new SqlDataAdapter();
                    adapt2.SelectCommand = cmd2;
                    DataTable tabla2 = new DataTable();
                    adapt2.Fill(tabla2);
                    BindingSource bsource2 = new BindingSource();

                    bsource2.DataSource = tabla2;
                    dataGridView1.DataSource = bsource2;
                    adapt2.Update(tabla2);

                    conexion.Close();
                    break;
                case 2:
                    string query3 = String.Format("select te.Nombre from ASDASD.Tipos_especialidades te join ASDASD.Especialidades_Medicas em on te.Tipo_Especialidad_ID=em.Tipo_Especialidad_ID join ASDASD.Profesionales_Especialidades pe on em.Especialidad_ID=pe.Especialidad_ID join ASDASD.Bonos b on pe.Profesional_ID=b.Profesional_ID join ASDASD.Bonos_Medicamentos bm on b.Bono_ID=bm.Bono_Farmacia_ID order by te.Nombre");
                    conexion.Open();
                    SqlCommand cmd3 = new SqlCommand(query3, conexion);
                    SqlDataAdapter adapt3 = new SqlDataAdapter();
                    adapt3.SelectCommand = cmd3;
                    DataTable tabla3 = new DataTable();
                    adapt3.Fill(tabla3);
                    BindingSource bsource3 = new BindingSource();

                    bsource3.DataSource = tabla3;
                    dataGridView1.DataSource = bsource3;
                    adapt3.Update(tabla3);

                    conexion.Close();
                    break;
                case 3:
                    string query4 = String.Format("select top 10 p.Nro_Afiliado from ASDASD.Personas p join ASDASD.Bonos b on p.Nro_Afiliado=b.Afiliado_ID join ASDASD.Compras c on b.Compra_ID=c.Compra_ID where p.Nro_Afiliado <> c.Afiliado_ID");
                    conexion.Open();
                    SqlCommand cmd4 = new SqlCommand(query4, conexion);
                    SqlDataAdapter adapt4 = new SqlDataAdapter();
                    adapt4.SelectCommand = cmd4;
                    DataTable tabla4 = new DataTable();
                    adapt4.Fill(tabla4);
                    BindingSource bsource4 = new BindingSource();

                    bsource4.DataSource = tabla4;
                    dataGridView1.DataSource = bsource4;
                    adapt4.Update(tabla4);

                    conexion.Close();
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
 
        }
    }
}
