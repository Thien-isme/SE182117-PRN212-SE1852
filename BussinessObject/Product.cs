﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects
{
    public class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return Id + "\t" + Name + "\t" + Quantity + "\t" + Price;
        }
    }
}
