using MVaahan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVaahan.Repository.Interface
{
    /// <summary>
/// 
/// </summary>
   public interface IUserRepo
    {
        User FetchUserDetails(string emailId);
    }
}
