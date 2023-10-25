using BussinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public partial class OrderBUS : IOrderBUSS
    {
        public IOrderResponsitory _res;

        public OrderBUS(IOrderResponsitory orderResponsitory)
        {
            _res = orderResponsitory;
        }

        public List<OrderModel> GetallOrder()
        {
            return _res.GetallOrder();
        }

        public bool create(OrderModel model)
        {
            return _res.create(model);
        }

        public bool update(OrderModel model)
        {
            return _res.update(model);
        }

        public bool delete(int order_id)
        {
            return _res.delete(order_id);
        }
    }
}
