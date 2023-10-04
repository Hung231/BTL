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
    public partial class CustomerBUS : ICustomerBUSS
    {
        public ICustomerResponsitory _res;

        public CustomerBUS(ICustomerResponsitory customerResponsitory)
        {
            _res = customerResponsitory;
        }

        public List<CustomerModel> GetallCustomers()
        {
            return _res.GetallCustomers();
        }

        public bool create(CustomerModel model)
        {
            return _res.create(model);
        }

        public bool update(CustomerModel model)
        {
            return _res.update(model);
        }

        public bool delete(int customer_id)
        {
            return _res.delete(customer_id);
        }
    }
}
