using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerr;
namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private CategoryDAO categoryDAO = new CategoryDAO();
        public Dictionary<int, Category> GenerateDataset()
        {
            return categoryDAO.GenerateDataset();
        }
    }
}
