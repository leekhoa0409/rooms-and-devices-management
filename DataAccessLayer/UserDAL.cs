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
        public DataTable GetAllAccountsInfo()
        {
            CommandType ct = CommandType.StoredProcedure;
            return dal.ExecuteQueryDataTable("sp_LayTatCaTaiKhoan", ct);
        }
        public bool CreateAccount(string username, string password, string role, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTK", username),
                new SqlParameter("@MatKhau", password),
                new SqlParameter("VaiTro", role)
            };
            return dal.ExecuteNonQuery("sp_ThemTaiKhoan", ct, ref error, parameters);
        }
        public bool DeleteAccount(string username, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTK", username)
            };
            return dal.ExecuteNonQuery("sp_XoaTaiKhoan", ct, ref error, parameters);
        }
        public bool UpdateAccount(string username, string password, string role, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTK", username),
                new SqlParameter("@MatKhau", (object)password ?? DBNull.Value),
                new SqlParameter("VaiTro", (object)role ?? DBNull.Value)
            };
            return dal.ExecuteNonQuery("sp_SuaTaiKhoan", ct, ref error, parameters);
        }
    }
}
