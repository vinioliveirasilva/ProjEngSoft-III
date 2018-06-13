using System.Web.Mvc;

namespace Interface.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("{client}")]
        public ActionResult Index(string client, string senha)
        {
            ViewBag.Title = "Home Page - " + client;

            //if(client != string.Empty)
            //    Models.Cliente cliente = new Models.Cliente(client, "Vinicius");

            return View();
        }
    }
}
