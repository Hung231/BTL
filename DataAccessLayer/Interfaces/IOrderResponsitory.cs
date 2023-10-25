using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public partial interface IOrderResponsitory
    {
        List<OrderModel> GetallOrder();

        bool create(OrderModel model);

        bool update(OrderModel model);

        bool delete(int order_id);
    }
}
