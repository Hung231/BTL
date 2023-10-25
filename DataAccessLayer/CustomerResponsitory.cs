using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public  class CustomerResponsitory : ICustomerResponsitory
    {
        public IDatabaseHelper _dbHelper;

        public CustomerResponsitory(IDatabaseHelper databaseHelper)
        {
            _dbHelper = databaseHelper;
        }

        public List<CustomerModel> GetallCustomer()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_customer");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<CustomerModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool create(CustomerModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_customer",
                    "@customer_id", model.customer_id,
                    "@customer_name", model.customer_name,
                    "@email", model.email,
                    "@address", model.address,
                    "@phone", model.phone);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool update(CustomerModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_customer",
                    "@customer_id", model.customer_id,
                    "@customer_name", model.customer_name,
                    "@email", model.email,
                    "@address", model.address,
                    "@phone", model.phone);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool delete(int customer_id)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delete_customer",
                    "@customer_id", customer_id);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
