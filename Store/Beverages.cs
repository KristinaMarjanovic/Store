using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Beverages:PerishableProducts
    {
        public Beverages(string name, string brand, double price, DateTime expDate) : base(name, brand, price, expDate)
        {

        }

        public void printBeverages()
        {
            Console.WriteLine(this.name + " " + this.brand);
            Console.WriteLine(this.quantity + " x " + "$" + this.price + " = " + " $" + this.quantity * this.price);
            if (DateTime.Now.Day == this.expirationDate.Day)
            {
                Console.WriteLine("#discount 50%" + " -" + "$" + this.CalculateDiscount());
            }
            else if (((expirationDate.Day - DateTime.Now.Day) <= 5))
            {
                Console.WriteLine("#discount 10%" + " -" + "$" + this.CalculateDiscount());
            }
            Console.WriteLine();
        }


    }
}
