using Educacion.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacion.WebAdmin.Controllers
{
    public class EstudiantesController : Controller
    {
        EstudiantesBL _estudiantesBL;

        public EstudiantesController()
        {
            _estudiantesBL = new EstudiantesBL();

        }

        // GET: Estudiantes
        public ActionResult Index()
        {
            var listadeEstudiantes = _estudiantesBL.ObtenerEstudiantes();


            return View(listadeEstudiantes);
        }

        public ActionResult Crear()
        {
            var nuevoEstudiante = new Estudiantes();
            return View(nuevoEstudiante);

        }

        [HttpPost]
        public ActionResult Crear(Estudiantes estudiantes)
        {
            _estudiantesBL.GuardarEstudiantes(estudiantes);


            return RedirectToAction("Index");

        }

        public ActionResult Editar (int id)
        {
            var estudiantes = _estudiantesBL.ObtenerEstudiante(id);
            return View(estudiantes);

        }

        [HttpPost]
        public ActionResult Editar (Estudiantes estudiantes)
        {
            _estudiantesBL.GuardarEstudiantes(estudiantes);
            return RedirectToAction("Index");

        }

        public ActionResult Detalle(int id)
        {
            var estudiante = _estudiantesBL.ObtenerEstudiante(id);

            return View(estudiante);
        }

        public ActionResult Eliminar(int id)
        {
            var estudiante = _estudiantesBL.ObtenerEstudiante(id);

            return View(estudiante);
        }
        [HttpPost]
        public ActionResult Eliminar (Estudiantes estudiantes)
        {
            _estudiantesBL.EliminarEstudiante(estudiantes.Id);
            return RedirectToAction("Index");
        }
    }
}