using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Clothes : Products
    {
        public enum Size { xs, s, m, l, xl }
        public Size size;
        public string color;
        public DayOfWeek day;

        public Clothes(string name, string brand, double price,Size s, string col) : base(name, brand, price)
        {
            this.size = s;
            this.color = col;
            this.day= DateTime.Now.DayOfWeek;
        }

        public override double CalculateDiscount()
        {
            if ((day >= DayOfWeek.Monday) && (day <= DayOfWeek.Friday)) 
            {
                this.discount=(this.price*this.quantity) / 10;
            
            } 
            
            return discount;
        } 

        public void printClothes()
        {
            Console.WriteLine(this.name + " " + this.brand + " " + this.size + " " + this.color);
            Console.WriteLine(this.quantity + " x " + "$"+ this.price + " = " + "$" + this.quantity * this.price);
            if ((this.day>=DayOfWeek.Monday) && (this.day <= DayOfWeek.Friday))
            {
                Console.Write("#discount 10% " + " -" + "$" + this.CalculateDiscount());
            }
            Console.WriteLine();
            
        }
    }
}
