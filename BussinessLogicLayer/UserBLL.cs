using DataAccessLayer;
using System.Data;

namespace BussinessLogicLayer
{
    public class UserBLL
    {
        private UserDAL userDAL;
        private UtilDAL utilDAL;
        public UserBLL()
        {
            userDAL = new UserDAL();
            utilDAL = new UtilDAL();
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
        public DataTable GetAllAccountsInfo()
        {
            return userDAL.GetAllAccountsInfo();
        }
        public bool CreateAccount(string username, string password, string role, ref string error)
        {
            return userDAL.CreateAccount(username, password, role, ref error);
        }
        public bool DeleteAccount(string username, ref string error)
        {
            return userDAL.DeleteAccount(username, ref error);
        }
        public bool UpdateAccount(string username, string password, string role, ref string error)
        {
            return userDAL.UpdateAccount(username, password, role, ref error);
        }
    }
}
