using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class addons : product
    {
        private string weight;

        public addons () { }

        public addons (int a, string b, double c, string d) : base(a, b, c)
        {
            weight = d;
        }

        public override void getDetails()
        {
            base.getDetails();
        }
    }
}
