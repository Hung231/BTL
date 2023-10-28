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
    public partial class AdminBUS : IAdminBUSS
    {
        public IAdminResponsitory _res;

        public AdminBUS(IAdminResponsitory adminResponsitory)
        {
            _res = adminResponsitory;
        }

        public List<AdminModel> GetallAdmin()
        {
            return _res.GetallAdmin();
        }

        public bool create(AdminModel model)
        {
            return _res.create(model);
        }

        public bool update(AdminModel model)
        {
            return _res.update(model);
        }

        public bool delete(int admin_id)
        {
            return _res.delete(admin_id);
        }
    }
}
