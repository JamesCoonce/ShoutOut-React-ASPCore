using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoutOut.Models
{
    public class Status : BaseEntity
    {
        public int StatusId { get; set; }
        public string Content { get; set; }

        public List<Comment> Comments { get; set; }
        public User User { get; set; }
    }
}
