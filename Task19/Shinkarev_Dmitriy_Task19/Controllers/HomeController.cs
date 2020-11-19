using Microsoft.AspNetCore.Mvc;

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
