using Educacion.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacion.WebAdmin.Controllers
{
    public class NotasController : Controller
    {
        NotasBL _notasBL;
        EstudiantesBL _estudiantesBL;
        CursosBL _cursosBL;

        public NotasController()
        {

            _notasBL = new NotasBL();
            _estudiantesBL = new EstudiantesBL();
            _cursosBL = new CursosBL();
        }

        // GET: Notas
        public ActionResult Index()
        {
            var listadeNotas = _notasBL.ObtenerNotas();

            return View(listadeNotas);
        }

        public ActionResult Crear()
        {
            var nuevaNota = new Notas();
            var estudiantes = _estudiantesBL.ObtenerEstudiantes();
            ViewBag.EstudianteId = new SelectList(estudiantes, "Id", "Nombre");

            var cursos = _cursosBL.ObtenerCursos();
            ViewBag.CursoId = new SelectList(cursos, "Id", "Curso");

            return View(nuevaNota);
        }


        [HttpPost]
        public ActionResult Crear(Notas Notas)
        {
            var estudiantes = _estudiantesBL.ObtenerEstudiantes();
            ViewBag.EstudianteId = new SelectList(estudiantes, "Id", "Nombre");

            var cursos = _cursosBL.ObtenerCursos();
            ViewBag.CursoId = new SelectList(cursos, "Id", "Curso");

            if (ModelState.IsValid)
            {
                if (Notas.EstudianteId == 0)
                {
                    ModelState.AddModelError("EstudianteId", "Seleccione un Estudiante");
                    return View(Notas);
                }


                if (Notas.CursoId == 0)
                {
                    ModelState.AddModelError("CursoId", "Seleccione un Curso");
                    return View(Notas);
                }

                _notasBL.GuardarNotas(Notas);

                return RedirectToAction("Index");

            }

            return View(Notas);

        }

        public ActionResult Editar(int id)
        {
            var Notas = _notasBL.ObtenerNotas(id);

            var estudiantes = _estudiantesBL.ObtenerEstudiantes();
            ViewBag.EstudianteId = new SelectList(estudiantes, "Id", "Nombre", Notas.EstudianteId);

            var cursos = _cursosBL.ObtenerCursos();
            ViewBag.CursoId = new SelectList(cursos, "Id", "Curso", Notas.CursoId);

            return View(Notas);
        }

        [HttpPost]
        public ActionResult Editar(Notas Notas)
        {
            if (ModelState.IsValid)
            {
                if (Notas.EstudianteId == 0)
                {
                    ModelState.AddModelError("EstudianteId", "Seleccione un Estudiante");
                    return View(Notas);
                }


                if (Notas.CursoId == 0)
                {
                    ModelState.AddModelError("CursoId", "Seleccione un Curso");
                    return View(Notas);
                }

                _notasBL.GuardarNotas(Notas);

                return RedirectToAction("Index");
            }

            var estudiantes = _estudiantesBL.ObtenerEstudiantes();
            ViewBag.EstudianteId = new SelectList(estudiantes, "Id", "Nombre", Notas.EstudianteId);

            var cursos = _cursosBL.ObtenerCursos();
            ViewBag.CursoId = new SelectList(cursos, "Id", "Curso", Notas.CursoId);

            return View(Notas);
        }



        public ActionResult Detalle(int id)
        {
            var Notas = _notasBL.ObtenerNotas(id);

            return View(Notas);
        }
    }
}