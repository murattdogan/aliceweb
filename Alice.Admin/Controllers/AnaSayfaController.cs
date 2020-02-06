using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Admin.Controllers
{
    public class AnaSayfaController : Controller
    {
        private readonly KeywordPoolService _keywordPoolService;

        public AnaSayfaController(KeywordPoolService keywordPoolService)
        {
            _keywordPoolService = keywordPoolService;
        }


        public IActionResult Yonetim()
        {
            ViewBag.AlreadyImageList = ;
            ViewBag.SelectAllKeyword = _keywordPoolService.GetAll();
            return View();
        }
    }
}