using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class product
    {
        private int pid; //Product ID
        private string name; //Product Name

        public product () { }

        public product (int a, string b)
        {
            pid = a;
            name = b;
        }

        public virtual void getDetails()
        {

        }
    }
}
