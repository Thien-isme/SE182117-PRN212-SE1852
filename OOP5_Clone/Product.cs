using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Clone
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity   { get; set; }
        public int Price { get; set; }

        public Product()
        {
        }
        public Product(int id, string name, int quantity, int price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public Product clone()
        {
            return MemberwiseClone() as Product;
        }

        
    }
}
