using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderResponsitory : IOrderResponsitory
    {
        public IDatabaseHelper _dbHelper;

        public OrderResponsitory(IDatabaseHelper databaseHelper)
        {
            _dbHelper = databaseHelper;
        }

        public List<OrderModel> GetallOrder()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_order");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<OrderModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool create(OrderModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_order",
                    "@order_id", model.order_id,
                    "@customer_id", model.customer_id,
                    "@order_date", model.order_date,
                    "@total_amount", model.total_amount);

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

        public bool update(OrderModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_order",
                    "@order_id", model.order_id,
                    "@customer_id", model.customer_id,
                    "@order_date", model.order_date,
                    "@total_amount", model.total_amount);
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

        public bool delete(int order_id)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delete_order",
                    "@order_id", order_id);
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
