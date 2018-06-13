using System.Web.Mvc;

namespace Interface.Controllers
{
    [RoutePrefix("login")]
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}