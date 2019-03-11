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
        private object _;


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
        public ActionResult Crear(Cursos cursos, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {

                if (cursos.Curso != cursos.Curso.Trim())
                {
                    ModelState.AddModelError("Curso", "El curso no debe de llevar espacios al inicio o al final");
                    return View(cursos);

                }
                if (imagen != null)
                {
                    cursos.UrlImagen = GuardarImagen(imagen);
                }


                _cursosBL.GuardarCursos(cursos);


                return RedirectToAction("Index");
            }

            return View(cursos);
        }

        public ActionResult Editar(int id)
        {
            var cursos = _cursosBL.ObtenerCursos(id);
            return View(cursos);

        }

        [HttpPost]
        public ActionResult Editar(Cursos cursos)
        {
            if (ModelState.IsValid)
            {

                if (cursos.Curso != cursos.Curso.Trim())
                {
                    ModelState.AddModelError("Curso", "El curso no debe de llevar espacios al inicio o al final");
                    return View(cursos);

                }
                _cursosBL.GuardarCursos(cursos);


                return RedirectToAction("Index");
            }

            return View(cursos);

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
        private string GuardarImagen(HttpPostedFileBase imagen)
        {
            string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
            imagen.SaveAs(path);

            return "/Imagenes/" + imagen.FileName;
        }
    }
}