using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int firstVal = 10;
            int secondVal = 2;
            int result = firstVal / secondVal;

            ViewBag.Message = "Отладка приложения ASP.NET MVC!";

            return View(result);
        }
    }
}
