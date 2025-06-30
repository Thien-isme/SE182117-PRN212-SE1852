using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BussinessObjects;
using DataAccessLayerr;
using TreeViewWPF.models;
namespace DataAccessLayerr
{
    public class CategoryDAO
    {
        public Dictionary<int, Category> GenerateDataset()
        {
           return SampleDataset.GenerateDataset();
        }
    }
}
