using MVaahan.Models;
using MVaahan.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVaahan.Repository.Impl
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRepo : IUserRepo
    {
        public User FetchUserDetails(string emailId)
        {
            return new User(Guid.NewGuid().ToString(), "Rishab", 31, "rishab@haha.com");
        }
    }
}
