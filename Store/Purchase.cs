using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Store
{
    public class Purchase 
    {
        public Purchase()
        {

        }

        public Collection<Products> cart = new Collection<Products>();

        public void addToCart(Collection<Products> cart, Products product, double quantity)
        {
            cart.Add(product);
            product.quantity += quantity;
        
        }

    }
}
