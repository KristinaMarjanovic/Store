using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Store
{
    class Program
    {
        public enum Size
        {
            XS,
            S,
            M,
            L,
            XL
        }
        static void Main(string[] args)
        {
            Collection<Products> cart = new Collection<Products>();

            DateTime dt1 = new DateTime(2021, 11, 20);
            DateTime dt2 = new DateTime(2021, 11, 12);

            Clothes jeans = new Clothes("Jeans", "Gucci", 1000, Clothes.Size.M, "blue");
            Clothes jacket = new Clothes("Jacket", "Armani", 500, Clothes.Size.S, "red");

            Appliances laptop = new Appliances("Laptop", "HP", 1500, "Pavilion", DateTime.Now, 2.5);
            Appliances tv = new Appliances("TV", "Samsung", 1000, "ModelS5", dt1, 25);

            Food apple = new Food("Apples", "BrandA", 10, dt1);
            Food chocolate = new Food("Chocolate", "Milka", 5, dt2);
            Beverages milk = new Beverages("Milk", "Imlek", 30, DateTime.Now);

            Purchase purchase = new Purchase();
            Cashier cashier = new Cashier();

            purchase.addToCart(cart, jeans, 2);
            purchase.addToCart(cart, jacket, 3);
            purchase.addToCart(cart, laptop, 2);
            purchase.addToCart(cart, tv, 5);
            purchase.addToCart(cart, apple, 3);
            purchase.addToCart(cart, chocolate, 5);
            purchase.addToCart(cart, milk, 10);

            cashier.printReceipe(cart, DateAndTime.Now);


        }
    }
}
