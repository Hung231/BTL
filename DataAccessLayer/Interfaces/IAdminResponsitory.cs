using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public partial interface IAdminResponsitory
    {
        List<AdminModel> GetallAdmin();

        bool create(AdminModel model);

        bool update(AdminModel model);

        bool delete(int admin_id);
    }
}
