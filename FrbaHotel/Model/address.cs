using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Model
{
    public class address
    {
     
        String name = "";
        int direction = 0;
        int floor = 0;
        String department = "";

        public address() { }
        public address(Dictionary<String, Object> values)
        {
            if (values["altura"] != "")
                this.direction = (int)values["altura"];
            if (values["piso"] != "")
                this.floor = (int)values["piso"];
            this.department = (String)values["dpto"];
            this.name = (String)values["calle"];
        }

        public String getName() { return this.name; }
        public String getDepartment() { return this.name; }
        public int getFloor() { return this.floor; }
        public int getDirection() { return this.direction; }

        public void setName(string name) { this.name = name; }
        public void setDepartment(String dpto) { this.department = dpto; }
        public void setFloor(int floor) { this.floor = floor; }
        public void setDirection(int direction) { this.direction = direction; }
    }
}
