using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    public partial interface IProductBUSS
    {
        List<ProductModel> GetallProduct();

        bool create(ProductModel model);

        bool update(ProductModel model);

        bool delete(int product_id);
    }
}
