using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public partial class OrderItemsBUS : IOrderItemsResponsitory
    {
        public IOrderItemsResponsitory _res;

        public OrderItemsBUS(IOrderItemsResponsitory orderitemsResponsitory)
        {
            _res = orderitemsResponsitory;
        }

        public List<OrderItemsModel> GetallOrderItems()
        {
            return _res.GetallOrderItems();
        }

        public bool create(OrderItemsModel model)
        {
            return _res.create(model);
        }

        public bool update(OrderItemsModel model)
        {
            return _res.update(model);
        }

        public bool delete(int order_item_id)
        {
            return _res.delete(order_item_id);
        }
    }
}
