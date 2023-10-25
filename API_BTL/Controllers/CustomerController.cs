using BussinessLayer;
using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerBUSS _CustomerBUS;
        public CustomerController(ICustomerBUSS customer)
        {
            _CustomerBUS = customer;
        }

        [Route("get-all-customer")]
        [HttpGet]
        public IEnumerable<CustomerModel> GetCustomerModel()
        {
            return _CustomerBUS.GetallCustomer();
        }

        [Route("create-customer")]
        [HttpPost]
        public bool create(CustomerModel model)
        {
            return _CustomerBUS.create(model);
        }

        [Route("update-customer")]
        [HttpPut]
        public bool update(CustomerModel model)
        {
            return _CustomerBUS.update(model);
        }

        [Route("delete-customer")]
        [HttpDelete]
        public bool delete(int customer_id)
        {
            return _CustomerBUS.delete(customer_id);
        }
    }
}
