using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer4;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoutOut.Data;
using ShoutOut.Models;
using ShoutOut.Models.AccountViewModels;

namespace ShoutOut.Controllers
{
    public class UsersController : Controller
    {
        private UserManager<User> _userManager;

        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context,
            UserManager<User> userMgr)
        {
            _context = context;
            _userManager = userMgr;
        }
        [HttpGet]
        [Route("/users")]
        public IEnumerable<ProfileViewModel> GetUsers()
        {
            var users = _userManager.Users;
            var profiles = ProfileViewModel.GetUserProfiles(_userManager.Users);
            return profiles;
        }

        [HttpGet]
        [Route("/userclaims")]
        public async Task<IActionResult> GetAsync()
        {
            var userId = User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier)
                   .Select(c => c.Value).SingleOrDefault();
            var user = await _userManager.FindByIdAsync(userId);

            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }

    }

}