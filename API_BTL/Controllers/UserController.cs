using BussinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserBUSS _UserBUS;
        public UserController(IUserBUSS user)
        {
            _UserBUS = user;
        }

        [Route("get-all-user")]
        [HttpGet]
        public IEnumerable<UserModel> GetUserModel()
        {
            return _UserBUS.GetallUser();
        }

        [Route("create-user")]
        [HttpPost]
        public bool create(UserModel model)
        {
            return _UserBUS.create(model);
        }

        [Route("update-user")]
        [HttpPut]
        public bool update(UserModel model)
        {
            return _UserBUS.update(model);
        }

        [Route("delete-user")]
        [HttpDelete]
        public bool delete(int user_id)
        {
            return _UserBUS.delete(user_id);
        }
    }
}
