using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public partial interface IProductResponsitory
    {
        List<ProductModel> GetallProduct();

        bool create(ProductModel model);

        bool update(ProductModel model);

        bool delete(int product_id);    
    }

     
}
