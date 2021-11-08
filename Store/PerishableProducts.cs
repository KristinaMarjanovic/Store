using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class PerishableProducts : Products
    {
        public DateTime expirationDate;

        protected PerishableProducts(string name, string brand, double price, DateTime expDate) : base(name, brand, price)
        {
            this.expirationDate = expDate;
        }

        public override double CalculateDiscount()
        {
            if (DateTime.Now.Day == expirationDate.Day)
            {
                discount = (this.price / 2)*this.quantity;
                
            }
            else if ((expirationDate.Day - DateTime.Now.Day) <= 5)
            {
                discount = (this.price / 10)*this.quantity;
            }

            return discount;

        }
    }
}
