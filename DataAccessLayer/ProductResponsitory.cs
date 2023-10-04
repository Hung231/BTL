using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public partial class ProductResponsitory : IProductResponsitory
    {
        public IDatabaseHelper _dbHelper;

        public ProductResponsitory(IDatabaseHelper databaseHelper)
        {
            _dbHelper = databaseHelper;
        }

        public List<ProductModel> GetallProduct()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_product");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<ProductModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool create(ProductModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_product",
                    "@product_id", model.product_id,
                    "@product_name", model.product_name,
                    "@description", model.description,
                    "@price", model.price,
                    "@category", model.category);
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

        public bool update(ProductModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_product",
                    "@product_id", model.product_id,
                    "@product_name", model.product_name,
                    "@description", model.description,
                    "@price", model.price,
                    "@category", model.category);
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

        public bool delete(int product_id)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delete_product",
                    "@product_id", product_id);
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
