using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace problem1.BL
{
    internal class angle
    {
        public int degrees;
        public double minutes;
        public char direction;
       

        public angle() { }
        public angle (int deg,double min,char direc)
        {
            degrees = deg;
            minutes = min;
            direction = direc;

        }

        


             
    }
}
