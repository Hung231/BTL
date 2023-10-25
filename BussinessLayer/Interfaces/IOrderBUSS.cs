using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    public partial interface IOrderBUSS
    {
        List<OrderModel> GetallOrder();

        bool create(OrderModel model);

        bool update(OrderModel model);

        bool delete(int order_id);
    }
}
