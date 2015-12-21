using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Cart : CartGUI
    {

        double total = 0.0;
        List<string> cart = new List<string>();

        

        //Method to add item
        public void addItem(string name) {
            cart.Add(name);
        }

        //Method to remove item
        public void removeItem(string name) {
            cart.Remove(name);
        }

        //Add items to the listbox
        public void listCart() {
            foreach (string item in cart) {
                lstCart.Items.Add(item);
            }
        }

        //Method to get total
        public void updatetotal(double price) {
            total = total + price;
        }
        
}
}
