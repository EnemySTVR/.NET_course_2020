using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shinkarev_Dmitriy_Task19.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Information page";
            return View();
        }
    }
}
