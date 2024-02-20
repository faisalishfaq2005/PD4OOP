using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1.BL
{
    internal class ship
    {
        public string shipNo;
       
        public angle latitude;
        public angle longitude;

        public ship() { }
        public ship(string shipNo,angle latitude,angle longitude)
        {
            this.shipNo = shipNo;
            this.latitude = latitude;
            this.longitude = longitude;


        }

        
        public string display()
        {
            string val = "Ship is at: " + latitude.degrees + "\\u00b0\\" + latitude.minutes+"^"+latitude.degrees + " and "+ longitude.degrees + "\\u00b0\\" + longitude.minutes + "^" + longitude.degrees;
            return val;
        }
        


    }
}
