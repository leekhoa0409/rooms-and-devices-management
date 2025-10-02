using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class RoomBLL
    {
        private RoomDAL roomDAL;
        public RoomBLL() 
        { 
            roomDAL = new RoomDAL();
        }
        public DataTable GetAllRoom()
        {
            return roomDAL.GetAllRoom();
        }
        public bool InsertRoom(string ten, string loai, int sucChua, string tinhTrang, ref string error)
        {
            return roomDAL.InsertRoom(ten, loai, sucChua, tinhTrang, ref error);
        }
        public bool UpdateRoom(string ma, string ten, string loai, int sucChua, string tinhTrang, ref string error)
        {
            return roomDAL.UpdateRoom(ma, ten, loai, sucChua,tinhTrang, ref error);
        }
        public bool DeleteRoom(string ma, ref string error)
        {
            return roomDAL.DeleteRoom(ma, ref error);
        }

        public DataTable GetRoomById(string ma)
        {
            return roomDAL.GetRoomById(ma);
        }

        public DataTable FindRoom(string keyword)
        {
            return roomDAL.FindRoom(keyword);
        }

        public DataTable FilterRoom(string loaiPhong, string tinhTrang)
        {
            if (loaiPhong == "Tất cả") loaiPhong = null;
            if (tinhTrang == "Tất cả") tinhTrang = null;
            return roomDAL.FilterRoom(loaiPhong, tinhTrang);
        }
        public DataTable FilterRoomByStatus(string tinhTrang)
        {
            return roomDAL.FilterRoomByStatus(tinhTrang);
        }
        public DataTable GetAllRoomAndDevice()
        {
            return roomDAL.GetAllRoomAndDevice();
        }
        public DataTable GetDevicesByRoomId(string maPhong, string tinhTrang)
        {
            return roomDAL.GetDevicesByRoomId(maPhong, tinhTrang);
        }

        public int GetCountRooms()
        {
            return roomDAL.GetCountRooms();
        }
    }
}
