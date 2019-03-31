using Educacion.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Educacion.WebAdmin.Controllers
{
    public class NotasDetalleController : Controller
    {
        NotasBL _notasBL;
        MateriasBL _materiasBL;

        public NotasDetalleController()
        {
            _notasBL = new NotasBL();
            _materiasBL = new MateriasBL();
        }

        public ActionResult Index(int id)
        {
            var notas = _notasBL.ObtenerNotas(id);
            notas.ListadeNotasDetalle = _notasBL.ObtenerNotasDetalle(id);

            return View(notas);
        }


        public ActionResult Crear(int id)
        {
            var nuevaNotasDetalle = new NotasDetalle();
            nuevaNotasDetalle.NotaId = id;

            var materias = _materiasBL.ObtenerMateriasActivos();
            ViewBag.MateriaId = new SelectList(materias, "Id", "Materia");

            return View(nuevaNotasDetalle);

        }


        [HttpPost]
        public ActionResult Crear(NotasDetalle notasDetalle)
        {
            if (ModelState.IsValid)
            {
                if (notasDetalle.MateriaId == 0)
                {
                    ModelState.AddModelError("MateriaId", "Seleccione una Materia");
                    return View(notasDetalle);
                }

                _notasBL.GuardarNotasDetalle(notasDetalle);
                return RedirectToAction("Index", new { id = notasDetalle.NotaId });
            }

            var materias = _materiasBL.ObtenerMateriasActivos();
            ViewBag.MateriaId = new SelectList(materias, "Id", "Materia");

            return View(notasDetalle);

        }



        public ActionResult Eliminar(int id)
        {
            var notasDetalle = _notasBL.ObtenerNotasDetallePorId(id);

            return View(notasDetalle);
        }

        [HttpPost]
        public ActionResult Eliminar(NotasDetalle notasDetalle)
        {
            _notasBL.EliminarNotasDetalle(notasDetalle.Id);

            return RedirectToAction("Index", new { id = notasDetalle.NotaId });
        }

    }
}