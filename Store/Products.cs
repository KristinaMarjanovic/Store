using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public abstract class Products
    {
        public string name;
        public string brand;
        public double price;
        public double discount;
        public double quantity;
        

        public abstract double CalculateDiscount();

        public Products(string name, string brand, double price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            /*this.discount=0;
            this.quantity = 0;*/
        }
    }
}
