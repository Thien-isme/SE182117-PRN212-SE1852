using BussinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO = new ProductDAO();
        public List<Product> GetProducts()
        {
            return productDAO.GetProducts();
        }

        public void InitilizeDataset()
        {
            productDAO.InitilizeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return productDAO.SaveProduct(p);
            
        }

        public bool UpdateProduct(Product p)
        {
            return productDAO.UpdateProduct(p);
        }
    }
}
