using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public partial interface IUserResponsitory
    {
        List<UserModel> GetallUser();

        bool create(UserModel model);

        bool update(UserModel model);

        bool delete(int user_id);
    }
}
