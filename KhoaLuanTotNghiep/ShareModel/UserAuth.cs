using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;


namespace ShareModel
{
    public class UserAuth : IdentityUser
    {
        public UserAuth() : base()
        {
        }

        public UserAuth(string userName) : base(userName)
        {
        }

        [PersonalData]
        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsChange { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
