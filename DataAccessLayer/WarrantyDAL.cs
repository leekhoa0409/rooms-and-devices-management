using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class WarrantyDAL
    {
        private UtilDAL dal;
        public WarrantyDAL()
        {
            dal = new UtilDAL();
        }
        public DataTable GetRoomWarrantyInfo()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM v_BaoTriPhong", ct);
        }
        public DataTable GetDeviceWarrantyInfo()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM v_BaoTriThietBi", ct);
        }
        public DataTable GetRequestWarrantyInfo()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM v_YeuCauBaoTri", ct);
        }
        public bool AcceptRequest(string maYC, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@MaYC", maYC)
            };
            return dal.ExecuteNonQuery("sp_PheDuyetYeuCau", ct, ref error, parameters);
        }
        public bool DenyRequest(string maYC, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@MaYC", maYC)
            };
            return dal.ExecuteNonQuery("sp_TuChoiYeuCau", ct, ref error, parameters);
        }
        public bool CreateRequest(string tenTK, DateTime ngayYC, string noiDung, string maPhong, string maTB, ref string error)
        {
            object maPhongValue = string.IsNullOrEmpty(maPhong) ? DBNull.Value : (object)maPhong;
            object maTBValue = string.IsNullOrEmpty(maTB) ? DBNull.Value : (object)maTB;
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenTK", tenTK),
                new SqlParameter("@NgayYC", ngayYC),
                new SqlParameter("@NoiDung", (object) noiDung ?? DBNull.Value),
                new SqlParameter("@MaPhong", maPhongValue),
                new SqlParameter("@MaTB", maTBValue)
            };
            return dal.ExecuteNonQuery("sp_TaoYeuCauBaoTri", ct, ref error, parameters);
        }
        public DataTable FilterRequestsByStatus(string status)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@TrangThai", status)
            };  
            return dal.ExecuteQueryDataTable("sp_LocYeuCauBaoTriTheoTrangThai", ct, parameters);
        }
        public bool UpdateWarrantyInfo(string maBaoTri, DateTime? ngayBaoTri, int? chiPhi, string donViThucHien, string trangThai, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaBT", maBaoTri),
                new SqlParameter("@NgayBT", (object)ngayBaoTri ?? DBNull.Value),
                new SqlParameter("@ChiPhi", (object)chiPhi ?? DBNull.Value),
                new SqlParameter("@DonViThucHien", (object)donViThucHien ?? DBNull.Value),
                new SqlParameter("@TrangThai", (object)trangThai ?? DBNull.Value)
            };
            return dal.ExecuteNonQuery("sp_SuaThongTinBaoTri", ct, ref error, parameters);
        }
        public bool UpdateRequestWarrantyInfo(string maYC, DateTime? ngayYC, string noiDung, string trangThai, string maPhong, string maTB, ref string error)
        {
            object maPhongValue = string.IsNullOrEmpty(maPhong) ? DBNull.Value : (object)maPhong;
            object maTBValue = string.IsNullOrEmpty(maTB) ? DBNull.Value : (object)maTB;

            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaYC", maYC),
                new SqlParameter("@NgayYC", (object)ngayYC ?? DBNull.Value),
                new SqlParameter("@NoiDung", (object)noiDung ?? DBNull.Value),
                new SqlParameter("@TrangThai", trangThai),
                new SqlParameter("@MaPhong", maPhongValue),
                new SqlParameter("@MaTB", maTBValue)
            };
            return dal.ExecuteNonQuery("sp_SuaThongTinYeuCauBaoTri", ct, ref error, parameters);
        }
        public int DeleteDeviceWarrantyByYears(string soNam)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@SoNam", soNam)
            };

            DataTable dt = dal.ExecuteQueryDataTable("sp_XoaBaoTriThietBiQuaSoNam", ct, parameters);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["SoBanGhiDaXoa"]);
            }

            return 0;
        }
        public int DeleteRoomWarrantyByYears(string soNam)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@SoNam", soNam)
            };
            DataTable dt = dal.ExecuteQueryDataTable("sp_XoaBaoTriPhongQuaSoNam", ct, parameters);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["SoBanGhiDaXoa"]);
            }

            return 0;
        }
        public DataTable GetRequestByUser(string username)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@TenTK", username)
            };
            return dal.ExecuteQueryDataTable("sp_XemYeuCauBaoTriTheoUser", ct, parameters);
        }
    }
}
