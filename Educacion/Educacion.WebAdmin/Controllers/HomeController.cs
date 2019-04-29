using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacion.WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}