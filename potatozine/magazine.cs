using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class magazine : product
    {
        private int pages; //Magazine pages

        public magazine () { }

        public magazine (int a, string b, string c, double d, int e) : base(a, b, c, d)
        {
            pages = e;
        }

        public override void getDetails()
        {
            base.getDetails();
        }
    }
}
