using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RoomDAL
    {
        private UtilDAL dal;
        public RoomDAL() 
        {
            dal = new UtilDAL();
        }

        public DataTable GetAllRoom()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM v_LayTatCaPhong", ct);
        }

        public bool InsertRoom(string ten, string loai, int sucChua, string tinhTrang, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@TenPhong", ten),
                new SqlParameter("@LoaiPhong", loai),
                new SqlParameter("@SucChua", sucChua),
                new SqlParameter("@TinhTrang", tinhTrang)
            };
            return dal.ExecuteNonQuery("sp_ThemPhong", ct, ref error, parameters);
        }

        public bool UpdateRoom(string ma, string ten, string loai, int sucChua, string tinhTrang, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhong", ma),
                new SqlParameter("@TenPhong", ten),
                new SqlParameter("@LoaiPhong", loai),
                new SqlParameter("@SucChua", sucChua),
                new SqlParameter("@TinhTrang", tinhTrang)
            };
            return dal.ExecuteNonQuery("sp_SuaPhong", ct, ref error, parameters);
        }

        public bool DeleteRoom(string ma, ref string error)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhong", ma)
            };
            return dal.ExecuteNonQuery("sp_XoaPhong", ct, ref error, parameters);
        }

        public DataTable GetRoomById(string ma)
        {
            CommandType ct =  CommandType.Text;
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhong", ma)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_LayPhongQuaMaPhong(@MaPhong)", ct, parameters);
        }

        public DataTable FindRoom(string keyword)
        {
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters = {
                new SqlParameter("@Keyword", keyword)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_TimPhong(@Keyword)", ct, parameters);
        }

        public DataTable FilterRoom(string loaiPhong, string tinhTrang)
        {
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters = {
                new SqlParameter("@LoaiPhong", (object)loaiPhong ?? DBNull.Value),
                new SqlParameter("@TinhTrang", (object)tinhTrang ?? DBNull.Value)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_LocPhong(@LoaiPhong, @TinhTrang);", ct, parameters);
        }
        public DataTable FilterRoomByStatus(string tinhTrang)
        {
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters = {
                new SqlParameter("@TinhTrang", tinhTrang)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_LocPhongTheoTinhTrang(@TinhTrang);", ct, parameters);
        }

        public DataTable GetAllRoomAndDevice()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM v_ThongTinChiTietPhongThietBi", ct);
        }
        public DataTable GetDevicesByRoomId(string maPhong, string tinhTrang)
        {
            CommandType ct = CommandType.Text;
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhong", maPhong),
                new SqlParameter("@TinhTrang", (object)tinhTrang ?? DBNull.Value)
            };
            return dal.ExecuteQueryDataTable("SELECT * FROM dbo.fn_LayCacThietBiQuaPhong(@MaPhong, @TinhTrang);", ct, parameters);
        }

        public int GetCountRooms()
        {
            CommandType ct = CommandType.Text;
            object result = dal.ExecuteScalar("SELECT dbo.fn_DemSoPhong();", ct);

            if (result == null || result == DBNull.Value)
                return 0;

            return Convert.ToInt32(result);
        }
    }
}
