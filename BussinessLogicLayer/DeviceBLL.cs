using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessLogicLayer
{
    public class DeviceBLL
    {
        private DeviceDAL deviceDAL;
        public DeviceBLL() 
        { 
            deviceDAL = new DeviceDAL();
        }
        public DataTable GetAllDevices()
        {
            return deviceDAL.GetAllDevices();
        }
        public bool InsertDevice(string ten, string loai, DateTime ngayMua, string tinhTrang, ref string error)
        {
            return deviceDAL.InsertDevice(ten, loai, ngayMua, tinhTrang, ref error);
        }
        public bool UpdateDevice(string ma, string ten, string loai, DateTime ngayMua, string tinhTrang, ref string error)
        {
            return deviceDAL.UpdateDevice(ma, ten, loai, ngayMua, tinhTrang, ref error) ;
        }
        public bool DeleteDevice(string ma, ref string error) {
            return deviceDAL.DeleteDevice(ma, ref error) ;
        }
        public DataTable FindDevice(string keyword)
        {
            return deviceDAL.FindDevice(keyword);
        }
        public DataTable GetDeviceById(string ma)
        {
            return deviceDAL.GetDeviceById(ma);
        }
        public DataTable FilterDevice(DateTime fromDate, DateTime toDate, string tinhTrang)
        {
            return deviceDAL.FilterDevice(fromDate, toDate, tinhTrang);
        }
        public DataTable GetRoomAndDevice()
        {
            return deviceDAL.GetRoomAndDevice();
        }
        public bool InsertDeviceIntoRoom(string maPhong, string maTB, int soLuong, ref string error)
        {
            return deviceDAL.InsertDeviceIntoRoom(maPhong, maTB, soLuong, ref error);
        }
        public bool UpdateDeviceInRoom(string maPhong, string maTB, int soLuong, ref string error)
        {
            return deviceDAL.UpdateDeviceInRoom(maPhong, maTB, soLuong, ref error);
        }
        public bool DeleteDeviceInRoom(string maPhong, string maTB, ref string error) {
            return deviceDAL.DeleteDeviceInRoom(maPhong, maTB, ref error);
        }
        public DataTable FilterDeviceByStatus(string tinhTrang)
        {
            return deviceDAL.FilterDeviceByStatus(tinhTrang);
        }
    }
}
