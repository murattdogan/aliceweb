using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Alice.Admin.Models;
using Alice.Service.Service;
using Alice.Core.Extensions;
using Alice.Service.Model;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Alice.Admin.Filters;

namespace Alice.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService _userService;

        public HomeController(UserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var t = _userService.GetAllUsers();
            return RedirectToAction("Login");
            //return View();
        }

        public IActionResult Login(string username, string password)
        {
            if (username is null || password is null)
                return View();
            else
            {
                var q = _userService.isLoginControl(username, password);
                if (q is null)
                    return View();
                else
                {
                    if (HttpContext.Session.GetString("luxurydbadmin") == null)
                    {
                        HttpContext.Session.SetString("luxurydbadmin", JsonConvert.SerializeObject(q));
                    }

                    return RedirectToAction("Dashboard");
                }
            }
        }

        public IActionResult Cikis()
        {
            if (HttpContext.Session.GetString("luxurydbadmin") != null)
                HttpContext.Session.Remove("luxurydbadmin");

            return RedirectToAction("Login");
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public IActionResult Dashboard()
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
