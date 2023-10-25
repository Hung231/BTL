using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private IOrderItemsBUSS _OrderItemsBUS;
        public OrderItemsController(IOrderItemsBUSS orderitems)
        {
            _OrderItemsBUS = orderitems;
        }

        [Route("get-all-order-item")]
        [HttpGet]
        public IEnumerable<OrderItemsModel> GetOrderItemsModel()
        {
            return _OrderItemsBUS.GetallOrderItems();
        }

        [Route("create-order-item")]
        [HttpPost]
        public bool create(OrderItemsModel model)
        {
            return _OrderItemsBUS.create(model);
        }

        [Route("update-order")]
        [HttpPut]
        public bool update(OrderItemsModel model)
        {
            return _OrderItemsBUS.update(model);
        }

        [Route("delete-order")]
        [HttpDelete]
        public bool delete(int order_item_id)
        {
            return _OrderItemsBUS.delete(order_item_id);
        }
    }
}
