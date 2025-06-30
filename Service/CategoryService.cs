using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerr;
using BussinessObjects;
using 
namespace Service
{
    public class CategoryService
    {
        private readonly CategoryRe

        public CategoryService()
        {
            categoryDAO = new CategoryDAO();
        }

        public Dictionary<int, Category> GetAllCategories()
        {
            return categoryDAO.GenerateDataset();                                                                     
        }
    }
}
