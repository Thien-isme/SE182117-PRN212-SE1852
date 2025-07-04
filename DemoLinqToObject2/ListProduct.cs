﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinqToObject2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>(); 
        }

        public void gen_sample_products()
        {
            products.Add(new Product { Id = 1, Name = "P1", Quantity = 10, Price = 100 });
            products.Add(new Product { Id = 2, Name = "P2", Quantity = 20, Price = 500 });
            products.Add(new Product { Id = 3, Name = "P3", Quantity = 60, Price = 200 });
            products.Add(new Product { Id = 4, Name = "P4", Quantity = 90, Price = 400 });
            products.Add(new Product { Id = 5, Name = "P5", Quantity = 80, Price = 900 });
            products.Add(new Product { Id = 6, Name = "P6", Quantity = 100, Price = 600 });
            products.Add(new Product { Id = 7, Name = "P7", Quantity = 180, Price = 700 });
            products.Add(new Product { Id = 8, Name = "P18", Quantity = 200, Price = 200 });
            products.Add(new Product { Id = 9, Name = "P9", Quantity = 360, Price = 300 });
            products.Add(new Product { Id = 10, Name = "P10", Quantity = 410, Price = 500 });

        }

        public void PrintProducts()
        {
            products.ForEach(p => Console.WriteLine(p));
        }

        public void FilterProductByPrice(double price1, double price2)
        {
            var result = products.Where(p=>p.Price >= price1 && p.Price<=price2);
            result.ToList().ForEach(p => Console.WriteLine(p));
        }

        public void FilterProductByPriceAsc(double price1, double price2)
        {
            var result = from p in products
                         where p.Price >= price1 && p.Price <= price2
                         orderby p.Price descending, p.Quantity ascending
                         select p;

            result.ToList().ForEach(p => Console.WriteLine(p));
        }

        public void FilterProductByQuantity(int q1, int q2)
        {
            var result = from p in products
                         where p.Quantity >= q1 && p.Quantity <= q2
                         select new {p.Id, p.Name, p.Quantity};

            result.ToList().ForEach(p => Console.WriteLine(p.Id+"\t"+p.Name+"\t"+p.Quantity));
        }

    }
}
