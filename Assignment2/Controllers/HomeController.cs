using Assignment2.Core;
using Assignment2.Data;
using Assignment2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Assignment2Context _context;

        public HomeController(ILogger<HomeController> logger, Assignment2Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = Constants.Policies.RequireManager)]
        //[Authorize(Roles = Constants.Roles.Manager)]
        public IActionResult Manager()
        {
            return View();
        }

        [Authorize(Policy = Constants.Policies.RequireReception)]
        public IActionResult Reception()
        {
            return View();
        }

        [Authorize(Policy = Constants.Policies.RequireHousekeeper)]
        public IActionResult Housekeeper()
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