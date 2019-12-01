using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Admin.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public IActionResult List()
        {

            return View();
        }
    }
}