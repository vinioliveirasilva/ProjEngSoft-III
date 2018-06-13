using System.Web.Mvc;

namespace Interface.Controllers
{
    [RoutePrefix("login")]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("{cpf}&{senha}")]
        public ActionResult Index(string cpf, string senha)
        {
            ViewBag.Token = cpf + senha;
            return View();
        }

        [HttpGet]
        [Route("{token}")]
        public ActionResult Main(string token)
        {
           return View();
        }
    }
}