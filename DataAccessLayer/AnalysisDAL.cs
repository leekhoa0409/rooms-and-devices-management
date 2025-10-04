using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AnalysisDAL
    {
        private UtilDAL dal;
        public AnalysisDAL() 
        { 
            dal = new UtilDAL();
        }
        public DataTable ThongKePhong()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_SoLuongPhongTheoLoai();", ct);
        }

        public DataTable ThongKeThietBi()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_SoLuongThietBiTheoTinhTrang();", ct);
        }

        public DataTable ThongKeBaoTriTheoNam(int nam)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nam", nam)
            };
            return dal.ExecuteQueryDataTable("sp_BaoTriTheoNam", ct, parameters);
        }

        public DataTable ThongKeChiPhiBaoTriPhongTheoThangNam(int nam)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nam", nam)
            };
            return dal.ExecuteQueryDataTable("sp_ChiPhiBaoTriPhongTheoThangNam", ct, parameters);
        }
        public DataTable GetAllYear()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM v_LayTatCaCacNamBaoTri", ct);
        }
    }
}
