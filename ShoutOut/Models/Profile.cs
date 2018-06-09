using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoutOut.Models
{
    public class Profile : BaseEntity
    {
        public int ProfileId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string URL { get; set; }

        public User User { get; set; }
    }
}
