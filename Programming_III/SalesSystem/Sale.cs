using System;
using System.Collections.Generic;

namespace Programming_III.SalesSystem
{
    public class Sale
    {
        public  Salesman Seller;
        public List<Product> Products = new List<Product>();

        public void AddNewProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }
    }
}
