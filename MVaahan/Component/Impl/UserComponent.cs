using MVaahan.Component.Interface;
using MVaahan.Models;
using MVaahan.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVaahan.Component.Impl
{
    /// <summary>
    /// 
    /// </summary>
    public class UserComponent : IUserComponent
    {
        private IUserRepo UserRepo { get; set; }
        public UserComponent(IUserRepo UserRepo)
        {
            this.UserRepo = UserRepo;
        }
        public User FetchUserDetails(string emailId)
        {
          //  IUserRepo userRepo = new UserRepo();
           return UserRepo.FetchUserDetails(emailId);
        }
    }
}
