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
        private double price; //Product Price

        public product () { }

        public product (int a, string b, double c)
        {
            pid = a;
            name = b;
            price = c;
        }

        public virtual void getDetails()
        {

        }
    }
}
