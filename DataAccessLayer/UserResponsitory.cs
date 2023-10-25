using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class UserResponsitory : IUserResponsitory
    {
        public IDatabaseHelper _dbHelper;

        public UserResponsitory(IDatabaseHelper databaseHelper)
        {
            _dbHelper = databaseHelper;
        }

        public List<UserModel> GetallUser()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_get_all_user");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<UserModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool create(UserModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_create_user",
                    "@user_id", model.user_id,
                    "@username", model.username,
                    "@password", model.password,
                    "@email", model.email,
                    "@full_name", model.full_name,
                    "@address",model.address,
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

        public bool update(UserModel model)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_update_product",
                    "@user_id", model.user_id,
                    "@username", model.username,
                    "@password", model.password,
                    "@email", model.email,
                    "@full_name", model.full_name,
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

        public bool delete(int user_id)
        {
            string msgError = "";
            try
            {
                string result = "";
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_delete_product",
                    "@user_id", user_id);
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
