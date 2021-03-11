using System;
namespace Programming_III.SalesSystem
{
    public class Program
    {
        public static void MainSalesSystem(String[] args)
        {
            Product p1 = new Product();
            p1.Name = "a";
            p1.Price = 100;
            Product p2 = new Product();
            p2.Name = "b";
            p2.Price = 200;
            Salesman s1 = new Salesman();
            s1.Name = "Pepito";
            Sale sale1 = new Sale();
            sale1.AddNewProduct(p1);
            sale1.AddNewProduct(p2);
            sale1.Seller = s1;

            Product p3 = new Product();
            p3.Name = "c";
            p3.Price = 60;
            Product p4 = new Product();
            p4.Name = "d";
            p4.Price = 720;
            Salesman s2 = new Salesman();
            s2.Name = "Natalia";
            Sale sale2 = new Sale();
            sale2.AddNewProduct(p3);
            sale2.AddNewProduct(p4);
            sale2.Seller = s2;


            Product p5 = new Product();
            p5.Name = "e";
            p5.Price = 400;
            Salesman s3 = new Salesman();
            s3.Name = "Maria";
            Sale sale3 = new Sale();
            sale3.AddNewProduct(p5);
            sale3.Seller = s3;

            Store store = new Store();
            store.AddSale(sale1);
            store.AddSale(sale2);
            store.AddSale(sale3);

            Salesman sellerWhoHasSoldTheCheapestProduct = store.SellerWithTheCheapestSale();
            Console.WriteLine("The seller who has sold the cheapest product is: " + sellerWhoHasSoldTheCheapestProduct.Name);
        }
    }
}
