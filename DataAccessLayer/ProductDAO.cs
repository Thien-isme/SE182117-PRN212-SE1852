using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();

        public void InitilizeDataset()
        {
            products.Add(new Product() { Id = 1, Name = "Coca", Quantity = 10, Price = 200 });
            products.Add(new Product() { Id = 2, Name = "Pepsi", Quantity = 20, Price = 800 });
            products.Add(new Product() { Id = 3, Name = "String", Quantity = 30, Price = 600 });
            products.Add(new Product() { Id = 4, Name = "Redbul", Quantity = 40, Price = 400 });
            products.Add(new Product() { Id = 5, Name = "7Up", Quantity = 50, Price = 100 });
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public bool SaveProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old != null)
            {
                return false;
            }
            products.Add(p);
            return true;

        }

        public bool UpdateProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old == null)
            {
                return false; // khong tim thay san pham
            }
            old.Name = p.Name;
            old.Quantity = p.Quantity;
            old.Price = p.Price;
            return true;
            

        }
    }

}
