﻿using System;
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

        public magazine (int a, string b, double c, int d) : base(a, b, c)
        {
            pages = d;
        }

        public override void getDetails()
        {
            base.getDetails();
        }
    }
}
