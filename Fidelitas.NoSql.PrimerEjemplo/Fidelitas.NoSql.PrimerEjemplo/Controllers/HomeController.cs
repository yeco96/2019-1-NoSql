using Fidelitas.NoSql.PrimerEjemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fidelitas.NoSql.PrimerEjemplo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SayHello()
        {
            return View();
        }

        public ActionResult SayHelloToSomebody()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SayHelloToSomebody(MessageModel elModelo)
        {
            return View("ShowMessageFromSomebody", elModelo);
        }

    }
}