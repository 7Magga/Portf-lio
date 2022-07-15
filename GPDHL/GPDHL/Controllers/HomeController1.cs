using Microsoft.AspNetCore.Mvc;

namespace GPDHL.Controllers
{
    public class HomeController1 : Controller
    {
        public JsonResult Index()
        {
            var a = "Test";
            return Json(a);
        }
    }
}
