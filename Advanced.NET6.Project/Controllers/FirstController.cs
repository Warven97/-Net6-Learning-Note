using Microsoft.AspNetCore.Mvc;

namespace Advanced.NET6.Project.Controllers
{
    public class FirstController : Controller
    {   /// <summary>
        /// MVC：
        /// C：controller 业务逻辑计算——调用其他的服务做业务逻辑计算
        /// M：modal 实体对象——保存数据，数据传输
        /// V：views 视图——表现层
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            {
                //一堆业务逻辑计算

            }
            ViewBag.User1 = "张三";
            ViewData["User2"] = "李四";
            TempData["User3"] = "王五";
            HttpContext.Session.SetString("User4", "赵六");//Session需要注册
            object User5 = "田七";
            return View(User5);
        }
    }
}
