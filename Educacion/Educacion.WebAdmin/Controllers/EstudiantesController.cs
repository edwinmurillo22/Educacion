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
        CursosBL _cursosBL;
        

        public EstudiantesController()
        {
            _estudiantesBL = new EstudiantesBL();
            _cursosBL = new CursosBL();

        }

        // GET: Estudiantes
        public ActionResult Index()
        {
            var listadeEstudiantes = _estudiantesBL.ObtenerEstudiantes();


            return View(listadeEstudiantes);
        }

        public ActionResult Crear()
        {
            var nuevoEstudiantes = new Estudiantes();
            var cursos = _cursosBL.ObtenerCursos();

            ViewBag.CursoId = 
                new SelectList(cursos, "Id", "Curso");

            return View(nuevoEstudiantes);

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
            var cursos = _cursosBL.ObtenerCursos();

            ViewBag.CursoId =
                new SelectList(cursos, "Id", "Curso", estudiantes.CursoId);

            return View(estudiantes);

        }

        [HttpPost]
        public ActionResult Editar(Estudiantes estudiantes)
        {
            _estudiantesBL.GuardarEstudiantes(estudiantes);
            return RedirectToAction("Index");

        }

        public ActionResult Detalle(int id)
        {
            var estudiantes = _estudiantesBL.ObtenerEstudiante(id);
            var cursos = _cursosBL.ObtenerCursos();

            ViewBag.CursoId =
                new SelectList(cursos, "Id", "Curso", estudiantes.CursoId);


            return View(estudiantes);
        }

        public ActionResult Eliminar(int id)
        {
            var estudiantes = _estudiantesBL.ObtenerEstudiante(id);
            var cursos = _cursosBL.ObtenerCursos();

            ViewBag.CursoId =
                new SelectList(cursos, "Id", "Curso", estudiantes.CursoId);

            return View(estudiantes);
        }
        [HttpPost]
        public ActionResult Eliminar (Estudiantes estudiantes)
        {
            _estudiantesBL.EliminarEstudiante(estudiantes.Id);
            return RedirectToAction("Index");
        }
    }
}