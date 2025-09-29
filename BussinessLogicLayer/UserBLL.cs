using DataAccessLayer;
using System.Data;

namespace BussinessLogicLayer
{
    public class UserBLL
    {
        private UserDAL userDAL;
        private UtilDAL utilDAL;
        public UserBLL () 
        { 
            userDAL = new UserDAL ();
            utilDAL = new UtilDAL ();
        }
        public DataTable LoginCheck(string tenTK, string matKhau)
        {
            return userDAL.LoginCheck(tenTK, matKhau);
        }
        public string CreateConnectionString(string username, string passwd)
        {
            return utilDAL.CreateConnectionString(username, passwd);
        }
        public string GetCurrentDBUser()
        {
            return userDAL.GetCurrentDbUser();
        }
        public DataTable GetCurrentRole()
        {
            return userDAL.GetCurrentRole();
        }
    }
}
