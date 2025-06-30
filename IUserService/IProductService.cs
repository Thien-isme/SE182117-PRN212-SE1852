using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductService
    {
        public void IntializeDataset();
        public List<Product> GetProducts();
        public bool SaveProduct(Product p);

        public bool UpdateProduct(Product p);
    }
}
