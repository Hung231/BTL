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

        [Route("get-all-product")]
        [HttpGet]
        public IEnumerable<ProductModel> GetProductModel() 
        {
            return _ProductBUS.GetallProduct();
        }

        [Route("create-product")]
        [HttpPost]
        public bool create(ProductModel model) 
        {
            return _ProductBUS.create(model);
        }

        [Route("update-product")]
        [HttpPut]
        public bool update(ProductModel model)
        {
            return _ProductBUS.update (model);
        }

        [Route("delete-product")]
        [HttpDelete]
        public bool delete(int Product_id)
        {
            return _ProductBUS.delete(Product_id);
        }
    }

}
