using MVaahan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVaahan.Component.Interface
{
   public interface IUserComponent
    {
        User FetchUserDetails(string emailId);
    }
}
