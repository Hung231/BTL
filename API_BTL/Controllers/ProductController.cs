using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductBUSS _ProductBUS;
        public ProductController(IProductBUSS product)
        {
            _ProductBUS = product;
        }

        [Route("get-all-prroduct")]
        [HttpGet]
        public IEnumerable<ProductModel> GetProductModel() 
        {
            return _ProductBUS.GetallProduct();
        }
    }
}
