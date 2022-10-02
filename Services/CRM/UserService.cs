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
    }
}
