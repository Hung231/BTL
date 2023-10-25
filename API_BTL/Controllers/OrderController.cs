using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderBUSS _OrderBUS;
        public OrderController(IOrderBUSS order)
        {
            _OrderBUS = order;
        }

        [Route("get-all-order")]
        [HttpGet]
        public IEnumerable<OrderModel> GetOrderModel()
        {
            return _OrderBUS.GetallOrder();
        }

        [Route("create-order")]
        [HttpPost]
        public bool create(OrderModel model)
        {
            return _OrderBUS.create(model);
        }

        [Route("update-order")]
        [HttpPut]
        public bool update(OrderModel model)
        {
            return _OrderBUS.update(model);
        }

        [Route("delete-order")]
        [HttpDelete]
        public bool delete(int order_id)
        {
            return _OrderBUS.delete(order_id);
        }
    }
}
