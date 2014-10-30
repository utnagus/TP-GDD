using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Home
{
    class homeUser
    {
        private homeUser instance = null;

        private homeUser sharedInstance(){
               if(instance == null)
                    instance = new homeUser();

            return instance;
        }



    }
}
