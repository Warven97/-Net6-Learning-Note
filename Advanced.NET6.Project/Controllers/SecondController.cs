using Microsoft.AspNetCore.Mvc;

namespace Advanced.NET6.Project.Controllers
{
    public class SecondController : Controller
    {
        private readonly ILogger<SecondController> _Logger;
        private readonly ILoggerFactory _LoggerFactory;
        public SecondController(ILogger<SecondController> logger , ILoggerFactory loggerFactory)
        {
            this._Logger = logger;
            this._Logger.LogInformation($"{this.GetType().Name} 被构造了...");
            this._LoggerFactory = loggerFactory;
            ILogger<SecondController> _Logger2 = this._LoggerFactory.CreateLogger<SecondController>();
            _Logger2.LogInformation($"{this.GetType().Name} 被构造了... _Logger2");


        }
        public IActionResult Index()
        {
            ILogger<SecondController> _Logger3 = this._LoggerFactory.CreateLogger<SecondController>();
            _Logger3.LogInformation("Inex 被执行了... _Logger3");
            this._Logger.LogInformation("Index 被执行了...");
            return View();
        }
    }
}
