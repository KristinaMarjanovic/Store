using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Food : PerishableProducts
    {
        public Food(string name, string brand, double price, DateTime expDate) : base(name, brand, price, expDate)
        {

        }

        public void printFood()
        {
            Console.WriteLine(this.name + " - " + this.brand + "\n");
            Console.WriteLine(this.quantity + " x " + "$" + this.price + " = " + " $" + this.quantity * this.price + "\n");
            if (DateTime.Now.Day == this.expirationDate.Day)
            {
                Console.Write("#discount 50%" + " -" + "$" + this.CalculateDiscount());
            }
            else if (((expirationDate.Day - DateTime.Now.Day) <= 5))
            {
                Console.Write("#discount 10%" + " -" + "$" + this.CalculateDiscount());
            }
            Console.WriteLine("\n");

        }


    }
}
