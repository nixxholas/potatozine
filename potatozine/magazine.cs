using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class magazine : product
    {
        private string type; //Magazine type

        public magazine () { }

        public magazine (int a, string b, string c) : base(a, b)
        {
            type = c;
        }

        public override void getDetails()
        {
            base.getDetails();
        }
    }
}
