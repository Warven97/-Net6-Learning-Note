using Microsoft.AspNetCore.Mvc;

namespace Advanced.NET6.Project.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            {

            }
            ViewBag.User1 = "张三";
            ViewData["User2"] = "李四";

            return View();
        }
    }
}
