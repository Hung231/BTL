using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    public partial interface ICustomerBUSS
    {
        List<CustomerModel> GetallCustomer();

        bool create(CustomerModel model);

        bool update(CustomerModel model);

        bool delete(int customer_id);
    }
}
