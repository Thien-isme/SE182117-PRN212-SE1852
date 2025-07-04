﻿using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        public void InitilizeDataset();
        public bool SaveProduct(Product p);
        public bool UpdateProduct(Product p);
    }
}
