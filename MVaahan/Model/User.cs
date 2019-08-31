using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVaahan.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class User
    {
        public User(string id, string name, int age, string emailId)
        {
            Id = id;
            Name = name;
            Age = age;
            EmailId = emailId;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmailId { get; set; }
    }
}
