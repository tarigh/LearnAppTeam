using Microsoft.AspNetCore.Mvc;

namespace LearnApp.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
