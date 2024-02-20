using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2.BL
{
    internal class stats
    {
        public string name;
        public double damage;
        public double  penetration;
        public double cost;
        public double  heal;
        public string description;

        public stats(string n,double d,double pene,double h,double c, string des) 
        {
            name = n;
            damage=d;
            description=des;
            penetration=pene;
            cost=c;
            heal=h;

        }



    }
}
