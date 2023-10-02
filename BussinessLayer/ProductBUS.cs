﻿using BussinessLayer.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public partial class ProductBUS : IProductBUSS
    {
        public IProductResponsitory _res;

        public ProductBUS(IProductResponsitory productResponsitory)
        {
            _res = productResponsitory;
        }

        public List<ProductModel> GetallProduct()
        {
            return _res.GetallProduct();
        }
    }
}
