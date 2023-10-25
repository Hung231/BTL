using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    public partial interface IOrderItemsBUSS
    {
        List<OrderItemsModel> GetallOrderItems();

        bool create(OrderItemsModel model);

        bool update(OrderItemsModel model);

        bool delete(int order_item_id);
    }
}
