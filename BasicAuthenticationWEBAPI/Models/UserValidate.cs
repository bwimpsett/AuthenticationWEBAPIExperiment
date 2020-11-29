using System;
using System.Linq;

namespace BasicAuthenticationWEBAPI.Models
{
    public class UserValidate
    {
        //check user credentials
        public static bool Login(string username, string password)
        {
            UsersBL usersBL = new UsersBL();
            var UserLists = usersBL.GetUsers();
            return UserLists.Any(user =>
                user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                && user.Password == password);
        }
    }
}