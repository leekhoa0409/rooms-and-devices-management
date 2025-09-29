using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class AnalysisBLL
    {
        private AnalysisDAL analysisDAL;
        public AnalysisBLL()
        { 
            analysisDAL = new AnalysisDAL();
        }
        public DataTable ThongKePhong()
        {
            return analysisDAL.ThongKePhong();
        }
        public DataTable ThongKeThietBi()
        {
            return analysisDAL.ThongKeThietBi();
        }
        public DataTable ThongKeBaoTriTheoNam(int nam)
        {
            return analysisDAL.ThongKeBaoTriTheoNam(nam);
        }
        public DataTable ThongKeChiPhiBaoTriPhongTheoThangNam(int nam)
        {
            return analysisDAL.ThongKeChiPhiBaoTriPhongTheoThangNam(nam);
        }
        public DataTable GetAllYear()
        {
            return analysisDAL.GetAllYear();
        }
    }
}
