﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Cart : CartGUI
    {
        List<int> cart = new List<int>();

        public void addItem(int itemcode) {
            cart.Add(itemcode);
        }
        public void removeItem(int itemcode) {
            cart.Remove(itemcode);
        }

        /**
        Supposed to add items to the listBox
            That's it
        **/
        public void listCart() {
            foreach (int a in cart) {
                lstCart.Items.Add(a);
            }
        }
        
}
}