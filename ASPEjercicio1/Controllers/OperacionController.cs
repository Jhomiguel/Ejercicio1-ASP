using ASPEjercicio1.Models;
using System.Web.Mvc;

namespace ASPEjercicio1.Controllers
{
    public class OperacionController : Controller
    {
        // GET: Operation
        public ActionResult Index()
        {
            return View(new operacion());
        }
        [HttpPost]
        public ActionResult Index(operacion num)
        {
            string numS = num.numero.ToString();
            char[] c = new char[2];
            c[0] = numS[1];
            c[1] = numS[0];
            string result = new string(c);
            num.numero =int.Parse(result);
            return View(num);  
        }

    }
}