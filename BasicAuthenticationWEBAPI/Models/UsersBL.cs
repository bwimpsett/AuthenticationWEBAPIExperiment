using System.Collections.Generic;

namespace BasicAuthenticationWEBAPI.Models
{
    public class UsersBL
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User { ID = 101, UserName = "MaleUser", Password = "123456" },
                new User { ID = 101, UserName = "FemaleUser", Password = "abcdef" }
            };
        }
    }
}