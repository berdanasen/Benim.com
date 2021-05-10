using Benim.Data;
using Benim.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Benim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager,UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }
        
        public IActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //    await _userManager.AddToRoleAsync(user, "Customer");
            //}
            return View();
        }
        //[Authorize(Roles = "Customer")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
