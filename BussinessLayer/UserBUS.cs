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
    public partial class UserBUS : IUserBUSS
    {
        public IUserResponsitory _res;

        public UserBUS(IUserResponsitory userResponsitory)
        {
            _res = userResponsitory;
        }

        public List<UserModel> GetallUser()
        {
            return _res.GetallUser();
        }

        public bool create(UserModel model)
        {
            return _res.create(model);
        }

        public bool update(UserModel model)
        {
            return _res.update(model);
        }

        public bool delete(int user_id)
        {
            return _res.delete(user_id);
        }
    }
}
