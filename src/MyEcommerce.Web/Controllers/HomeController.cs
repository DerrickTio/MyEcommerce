using Microsoft.AspNetCore.Mvc;

namespace MyEcommerce.Web.Controllers
{
    public class HomeController : MyEcommerceControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}