using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    public partial interface IAdminBUSS
    {
        List<AdminModel> GetallAdmin();

        bool create(AdminModel model);

        bool update(AdminModel model);

        bool delete(int admin_id);
    }
}
