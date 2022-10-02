using CRM.Models;
using CRM.Services.Db;

namespace CRM.Services.CRM
{
    public class UserService
    {
        public static bool ValidateUser(USER_LOGIN obj)
        {
            //sql query / call API

            if(obj.USER_ID == obj.USER_PSWD)
            {
                AppsData.USER_ID = obj.USER_ID;
                return true;
            }
            return false;
        }

        public static bool ChangePassword(USER_PASSWORD obj)
        {
            //sql query / call API
            if (obj.USER_PSWD != obj.USER_PSWD_NEW)
            {
                return true;
            }
            return false;
        }
    }
}
