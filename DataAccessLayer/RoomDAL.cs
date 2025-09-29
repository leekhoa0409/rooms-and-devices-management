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
            CommandType ct =  CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@MaPhong", ma)
            };
            return dal.ExecuteQueryDataTable("sp_LayPhongQuaMaPhong", ct, parameters);
        }

        public DataTable FindRoom(string keyword)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@Keyword", keyword)
            };
            return dal.ExecuteQueryDataTable("sp_TimPhong", ct, parameters);
        }

        public DataTable FilterRoom(string loaiPhong, string tinhTrang)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@LoaiPhong", loaiPhong),
                new SqlParameter("@TinhTrang", tinhTrang)
            };
            return dal.ExecuteQueryDataTable("sp_LocPhong", ct, parameters);
        }
        public DataTable FilterRoomByStatus(string tinhTrang)
        {
            CommandType ct = CommandType.StoredProcedure;
            SqlParameter[] parameters = {
                new SqlParameter("@TinhTrang", tinhTrang)
            };
            return dal.ExecuteQueryDataTable("sp_LocPhongTheoTinhTrang", ct, parameters);
        }

        public DataTable GetAllRoomAndDevice()
        {
            CommandType ct = CommandType.Text;
            return dal.ExecuteQueryDataTable("SELECT * FROM v_ThongTinChiTietPhongThietBi", ct);
        }
    }
}
