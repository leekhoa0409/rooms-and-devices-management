using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class WarrantyBLL
    {
        private WarrantyDAL warrantyDAL;
        public WarrantyBLL()
        {
            warrantyDAL = new WarrantyDAL();
        }
        public DataTable GetRoomWarrantyInfo()
        {
            return warrantyDAL.GetRoomWarrantyInfo();
        }
        public DataTable GetDeviceWarrantyInfo()
        {
            return warrantyDAL.GetDeviceWarrantyInfo();
        }
        public DataTable GetRequestWarrantyInfo()
        {
            return warrantyDAL.GetRequestWarrantyInfo();
        }
        public bool AcceptRequest(string maYC, ref string error)
        {
            return warrantyDAL.AcceptRequest(maYC, ref error);
        }
        public bool DenyRequest(string maYC, ref string error)
        {
            return warrantyDAL.DenyRequest(maYC, ref error);
        }
        public bool CreateRequest(string tenTK, DateTime ngayYC, string noiDung, string maPhong, string maTB, ref string error)
        {
            return warrantyDAL.CreateRequest(tenTK, ngayYC, noiDung, maPhong, maTB, ref error);
        }
        public DataTable FilterRequestsByStatus(string status)
        {
            return warrantyDAL.FilterRequestsByStatus(status);
        }
        public bool UpdateWarrantyInfo(string maBaoTri, DateTime? ngayBaoTri, int? chiPhi, string donViThucHien, string trangThai, ref string error)
        {
            return warrantyDAL.UpdateWarrantyInfo(maBaoTri, ngayBaoTri, chiPhi, donViThucHien, trangThai, ref error);
        }
        public bool UpdateRequestWarrantyInfo(string maYC, DateTime ngayYC, string noiDung, string trangThai, ref string error) 
        { 
            return warrantyDAL.UpdateRequestWarrantyInfo(maYC, ngayYC, noiDung, trangThai, ref error);
        }
        public int DeleteRoomWarrantyByYears(string soNam)
        {
            return warrantyDAL.DeleteRoomWarrantyByYears(soNam);
        }
        public int DeleteDeviceWarrantyByYears(string soNam)
        {
            return warrantyDAL.DeleteDeviceWarrantyByYears(soNam);
        }
        public DataTable GetRequestByUser(string username)
        {
            return warrantyDAL.GetRequestByUser(username);
        }
    }   
}
