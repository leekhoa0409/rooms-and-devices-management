using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class UserDAL
    {
        private UtilDAL dal;
        public UserDAL()
        {
            dal = new UtilDAL();
        }
        public DataTable LoginCheck(string tenTK, string matKhau)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTK", tenTK),
                new SqlParameter("@MatKhau", matKhau)
            };
            return dal.ExecuteQueryDataTable("sp_KiemTraDangNhap", ct, parameters);
        }
        public string GetCurrentDbUser()
        {
            string sql = "SELECT USER_NAME()";
            object result = dal.ExecuteScalar(sql, CommandType.Text);

            return result != null ? result.ToString() : string.Empty;
        }

        public DataTable GetCurrentRole()
        {
            CommandType ct = CommandType.StoredProcedure;
            return dal.ExecuteQueryDataTable("sp_XemRole", ct);
        }
    }
}
