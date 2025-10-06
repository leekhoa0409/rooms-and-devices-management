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
        public bool UpdateRoleAccount(string username, string role, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTK", username),
                new SqlParameter("VaiTro", role)
            };
            return dal.ExecuteNonQuery("sp_SuaVaiTroTaiKhoan", ct, ref error, parameters);
        }

        public DataTable GetAccountInfo(string username)
        {
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTK", username)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_ThongTinTaiKhoan(@TenTK);", ct, parameters);
        }
    }
}
