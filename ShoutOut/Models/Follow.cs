using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoutOut.Models
{
    public class Follow : BaseEntity
    {
        public int Id { get; set; }

        //User Being Followed
        public int FolloweeId { get; set; }
        public User Followee { get; set; }
        
        //User Following
        public int FollowerId { get; set; }
        public User Follower { get; set; }

    }
}
