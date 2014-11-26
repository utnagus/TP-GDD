using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FrbaHotel.Model
{
    public class Hotel
    {
        private String name = "";
        private String email = "";
        Int64 telephone = 0;
        int stars= 0;
        private String city="";
        private String country = "";
        private DateTime creation_date = new DateTime();
        private List<String> regimenes = new List<String>();
 

        public Hotel() { }
        public Hotel(String name) { this.name = name; }
    
        public String getName(){return this.name;}
        public void setName(String name) { this.name = name; }
        
        private DataBase db = new DataBase();

        public DataTable dameListadoHoteles()
        {
            String query = "select * from QWERTY.Hotel";
            DataTable dt = db.select_query(query);
            return dt;
        }
    }
}
