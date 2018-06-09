using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoutOut.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Who's following you
        public List<Follow> Followers { get; set; }
        //Who you are following
        public List<Follow> Followed { get; set; }

        public Profile Profile { get; set; }

        public List<Status> Statuses { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
