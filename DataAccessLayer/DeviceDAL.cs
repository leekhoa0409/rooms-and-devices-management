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
    public class DeviceDAL
    {
        private UtilDAL dal;
        public DeviceDAL() 
        { 
            dal = new UtilDAL();
        }
        public DataTable GetAllDevices()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM v_LayTatCaThietBi", ct);
        }
        public bool InsertDevice(string ten, string loai, DateTime ngayMua, string tinhTrang, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = { 
                new SqlParameter("@TenTB", ten),
                new SqlParameter("@LoaiTB", loai),
                new SqlParameter("@NgayMua", ngayMua),
                new SqlParameter("@TinhTrang", tinhTrang)
            };
            return dal.ExecuteNonQuery("sp_ThemThietBi", ct, ref error, parameters);
        }
        public bool DeleteDevice(string ma, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaTB", ma)
            };
            return dal.ExecuteNonQuery("sp_XoaThietBi", ct, ref error, parameters);
        }
        public bool UpdateDevice(string ma, string ten, string loai, DateTime ngayMua, string tinhTrang, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaTB", ma),
                new SqlParameter("@TenTB", ten),
                new SqlParameter("@LoaiTB", loai),
                new SqlParameter("@NgayMua", ngayMua),
                new SqlParameter("@TinhTrang", tinhTrang)
            };
            return dal.ExecuteNonQuery("sp_SuaThietBi", ct, ref error, parameters);
        }
        public DataTable FindDevice(string keyword)
        {
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters = {
                new SqlParameter("@Keyword", keyword)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_TimThietBi(@Keyword);", ct, parameters);
        }
        public DataTable GetDeviceById(string ma)
        {
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters = {
                new SqlParameter("@MaTB", ma)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_LayThietBiQuaMaThietBi(@MaTB);", ct, parameters);
        }
        public DataTable FilterDevice(DateTime fromDate, DateTime toDate, string tinhTrang)
        {
            if (tinhTrang == "Tất cả") tinhTrang = null;
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters = {
                new SqlParameter("@FromDate", fromDate),
                new SqlParameter("@ToDate", toDate),
                new SqlParameter("@TinhTrang", (object)tinhTrang ?? DBNull.Value)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_LocThietBi(@FromDate, @ToDate, @TinhTrang);", ct, parameters);
        }

        public DataTable GetRoomAndDevice()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM v_Phong_ThietBi", ct);
        }
        public bool InsertDeviceIntoRoom(string maPhong, string maTB, int soLuong, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("@MaTB", maTB),
                new SqlParameter("@SoLuong", soLuong)
            };
            return dal.ExecuteNonQuery("sp_ThemThietBiVaoPhong", ct, ref error, parameters);
        }
        public bool UpdateDeviceInRoom(string maPhong, string maTB, int soLuong, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("@MaTB", maTB),
                new SqlParameter("@SoLuong", soLuong)
            };
            return dal.ExecuteNonQuery("sp_SuaSoLuongThietBiTrongPhong", ct, ref error, parameters);
        }
        public bool DeleteDeviceInRoom(string maPhong, string maTB, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("MaTB", maTB)
            };
            return dal.ExecuteNonQuery("sp_XoaThietBiKhoiPhong", ct, ref error, parameters);
        }
        public DataTable FilterDeviceByStatus(string tinhTrang)
        {
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters = {
                new SqlParameter("@TinhTrang", tinhTrang)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_LocThietBiTheoTinhTrang(@TinhTrang);", ct, parameters);
        }
        public int GetCountDevices()
        {
            CommandType ct = CommandType.Text;
            object result = dal.ExecuteScalar("SELECT dbo.fn_DemSoThietBi();", ct);

            if (result == null || result == DBNull.Value)
                return 0;

            return Convert.ToInt32(result);
        }

    }
}
