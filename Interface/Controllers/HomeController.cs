using System.Web.Mvc;

namespace Interface.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("{client}")]
        public ActionResult Index(string client)
        {
            ViewBag.Title = "Home Page - " + client;
            
            return View();
        }
    }
}
