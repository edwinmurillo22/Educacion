using Educacion.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacion.WebAdmin.Controllers
{
    public class CursosController : Controller
    {
        CursosBL _cursosBL;


        public CursosController()
        {
            _cursosBL = new CursosBL();

        }

        // GET: Estudiantes
        public ActionResult Index()
        {
            var listadeCursos = _cursosBL.ObtenerCursos();


            return View(listadeCursos);
        }

        public ActionResult Crear()
        {
            var nuevoCursos = new Cursos();
            return View(nuevoCursos);

        }

        [HttpPost]
        public ActionResult Crear(Cursos cursos)
        {
            _cursosBL.GuardarCursos(cursos);


            return RedirectToAction("Index");

        }

        public ActionResult Editar(int id)
        {
            var cursos = _cursosBL.ObtenerCursos(id);
            return View(cursos);

        }

        [HttpPost]
        public ActionResult Editar(Cursos cursos)
        {
            _cursosBL.GuardarCursos(cursos);
            return RedirectToAction("Index");

        }

        public ActionResult Detalle(int id)
        {
            var cursos = _cursosBL.ObtenerCursos(id);

            return View(cursos);
        }

        public ActionResult Eliminar(int id)
        {
            var cursos = _cursosBL.ObtenerCursos(id);

            return View(cursos);
        }
        [HttpPost]
        public ActionResult Eliminar(Cursos cursos)
        {
            _cursosBL.EliminarCursos(cursos.Id);
            return RedirectToAction("Index");
        }
    }
}