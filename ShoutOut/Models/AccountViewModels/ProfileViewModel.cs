using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoutOut.Models.AccountViewModels
{
    public class ProfileViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ProfileViewModel()
        {

        }

        public ProfileViewModel(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
        }

        public static IEnumerable<ProfileViewModel> GetUserProfiles(IEnumerable<User> users)
        {
            var profiles = new List<ProfileViewModel> { };
            foreach (User user in users)
            {
                profiles.Add(new ProfileViewModel(user));
            }

            return profiles;
        }
    }
}
