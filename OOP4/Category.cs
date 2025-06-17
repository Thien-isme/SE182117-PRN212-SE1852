using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    public class Category
    {
        

        public int Id { get; set; }
        public string Name { get; set; }

        public Dictionary<int, Product> Products { get; set; }

        public Category()
        {
            Products = new Dictionary<int, Product>();
        }

        // CRUD: Thêm mới Product
        public void AddProduct(Product p)
        {
            // Kiểm tra Id có tồn tại trong Products hay chưa
            if (Products.ContainsKey(p.Id) == false)
            {
                Products.Add(p.Id, p);
            }
        }

        public void PrintAllProducts()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);

            }
        }

        public Product GetProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
            {
                return null;
            }

            return Products[id];
        }

        public Dictionary<int, Product> SortProduct()
        {
            return Products.OrderBy(item=>item.Value.Price).ToDictionary<int, Product>();
        }

        public Dictionary<int, Product> ComplexSort()
        {
            return Products
                .OrderByDescending(item=>item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }

        public void Edit(Product p)
        {
            // Kiểm tra Id có tồn tại trong Products hay chưa
            if (Products.ContainsKey(p.Id) == false)
            {
                return;
            }
            Products[p.Id] = p;
        }

        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(Id) == false)
            {
                return false;
            }
            return Products.Remove(id);
        }




    }
}
