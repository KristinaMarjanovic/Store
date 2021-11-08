using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Store
{
    public class Cashier
    {
        public double sum;
        public double discounts;
        public double total;
        public Cashier()
        {

        }

        public void printReceipe(Collection<Products> cart, DateTime datePurchase)
        {
            Console.WriteLine(datePurchase);
            Console.WriteLine();
            Console.WriteLine("-----Products-----");
            Console.WriteLine("\n");

            var last = cart.Last();

            foreach (Products prod in cart)
            {
                if (prod is Food)
                {
                    Food food = (Food)prod;
                    food.printFood();
                    sum += food.price * food.quantity;
                    discounts += food.discount;
                    Console.WriteLine();
                }
                else if (prod is Beverages)
                {
                    Beverages bev = (Beverages)prod;
                    bev.printBeverages();
                    sum += bev.price * bev.quantity;
                    discounts += bev.discount;
                    Console.WriteLine();
                }
                else if (prod is Clothes)
                {
                    Clothes clothes = (Clothes)prod;
                    clothes.printClothes();
                    sum += clothes.price * clothes.quantity;
                    discounts += clothes.discount;
                    Console.WriteLine();
                }
                else if (prod is Appliances)
                {
                    Appliances app = (Appliances)prod;
                    app.printAppliances();
                    sum += app.price * app.quantity;
                    discounts += app.discount;
                    Console.WriteLine();
                }

                if (prod.Equals(last))
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Subtotal: " + this.sum);
                    Console.WriteLine("Discount: " + this.discounts + "\n");
                    Console.WriteLine("Total: " + (this.sum - this.discounts));
                }
            }
        }
    }
}
