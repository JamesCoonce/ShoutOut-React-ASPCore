using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoutOut.Models
{
    public class Comment : BaseEntity
    {
        public int CommentId { get; set; }
        public string Content { get; set; }

        public Status Status { get; set; }
        public User User { get; set; }
    }
}
