using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    internal class row
    {
        public List<string> Values { get; private set; }

        // Constructor
        public row(List<string> values)
        {
            Values = values;
        }

    }
}
