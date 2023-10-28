using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminBUSS _AdminBUS;
        public AdminController(IAdminBUSS admin)
        {
            _AdminBUS = admin;
        }

        [Route("get-all-admin")]
        [HttpGet]
        public IEnumerable<AdminModel> GetAdminModel()
        {
            return _AdminBUS.GetallAdmin();
        }

        [Route("create-admin")]
        [HttpPost]
        public bool create(AdminModel model)
        {
            return _AdminBUS.create(model);
        }

        [Route("update-admin")]
        [HttpPut]
        public bool update(AdminModel model)
        {
            return _AdminBUS.update(model);
        }

        [Route("delete-admin")]
        [HttpDelete]
        public bool delete(int admin_id)
        {
            return _AdminBUS.delete(admin_id);
        }
    }
}
