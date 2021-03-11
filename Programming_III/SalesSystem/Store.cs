using System;
using System.Collections.Generic;

namespace Programming_III.SalesSystem
{
    public class Store
    {
        List<Sale> Sales = new List<Sale>();

        public void AddSale(Sale newSale)
        {
            Sales.Add(newSale);
        }

        public Salesman SellerWithTheCheapestSale()
        {
            Salesman seller = Sales[0].Seller;
            Product cheapestProduct = Sales[0].Products[0];

            for(int i=1; i<Sales.Count; i++){
                for (int j=0; j<Sales[i].Products.Count; j++)
                {
                    if(Sales[i].Products[j].Price < cheapestProduct.Price)
                    {
                        cheapestProduct = Sales[i].Products[j];
                        seller = Sales[i].Seller;
                    }
                }
            }

            return seller;
        }
    }
}
