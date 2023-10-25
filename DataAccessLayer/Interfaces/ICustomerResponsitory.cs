using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public partial interface ICustomerResponsitory
    {
        List<CustomerModel> GetallCustomer();

        bool create(CustomerModel model);

        bool update(CustomerModel model);

        bool delete(int customer_id);
    }
}
