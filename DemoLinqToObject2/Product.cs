using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinqToObject2
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

        public override string ToString()
        {
            return Id+"\t"+ Name + "\t"+ Quantity + "\t"+ Price + "\t";
        }

        public Product clone()
        {
            return MemberwiseClone() as Product;
        }

        
    }
}
