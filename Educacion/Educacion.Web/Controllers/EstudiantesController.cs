using Educacion.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacion.Web.Controllers
{
    public class EstudiantesController : Controller
    {
        // GET: Educacion
        public ActionResult Index()
        {
            var estudiantesBL = new EstudiantesBL();
            var listadeEstudiantes = estudiantesBL.ObtenerEstudiantes();


            return View(listadeEstudiantes);
        }
    }
}