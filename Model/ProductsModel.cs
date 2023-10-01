﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductsModel
    {
        public int product_id { get; set; }

        public string product_name { get; set; }

        public string description { get; set;}
        
        public decimal price { get; set; }
        
        public string category { get; set; }
    }
}
