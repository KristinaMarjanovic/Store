using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class Appliances : Products
    {
        public string model;
        public DateTime productionDate;
        public double weight;
        public DayOfWeek day;

        public Appliances(string name,string brand, double price, string m, DateTime prodDate, double w) : base(name, brand, price)
        {
            this.model = m;
            this.productionDate = prodDate;
            this.weight = w;
            this.day = DateTime.Now.DayOfWeek;
            //this.day = DayOfWeek.Saturday; Use this line to test how the app works if it is a weekend, and comment the previous line
        }

        public override double CalculateDiscount()
        {
            if ((this.price > 999) && ((this.day == DayOfWeek.Saturday) || (this.day == DayOfWeek.Sunday)))
            {
                this.discount = (this.price*this.quantity) / 20;
            }
            return this.discount;
        }

        public void printAppliances()
        {
            Console.WriteLine(this.name + " " + this.brand + " " + this.model);
            Console.WriteLine(this.quantity + "x" + " $" + this.price + " = " + "$"+ this.quantity * this.price);
            if ((this.price > 999) && ((this.day == DayOfWeek.Saturday) || (this.day == DayOfWeek.Sunday)))
            {
                Console.WriteLine("#discount 5% " + "-" + " $" + this.CalculateDiscount());
            }
            Console.WriteLine();
            
        }
    }
}
