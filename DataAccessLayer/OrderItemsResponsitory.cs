using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderItemsResponsitory : IOrderItemsResponsitory
    {
        public IDatabaseHelper _dbHelper;

        public OrderItemsResponsitory(IDatabaseHelper databaseHelper)
        {
            _dbHelper = databaseHelper;
        }

        public List<OrderItemsModel> GetallOrderItems()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_order_item");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<OrderItemsModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool create(OrderItemsModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_order_item",
                    "@order_item_id", model.order_item_id,
                    "@order_id", model.order_id,
                    "@product_id", model.product_id,
                    "@quantity", model.quantity,
                    "@price", model.price);
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

        public bool update(OrderItemsModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_order_item",
                    "@order_item_id", model.order_item_id,
                    "@order_id", model.order_id,
                    "@product_id", model.product_id,
                    "@quantity", model.quantity,
                    "@price", model.price);
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

        public bool delete(int order_item_id)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delete_order_item",
                    "@order_item_id", order_item_id);
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
