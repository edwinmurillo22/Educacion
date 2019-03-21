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

        public NotasDetalleController()
        {
            _notasBL = new NotasBL();
        }

        public ActionResult Index(int id)
        {
            var notas = _notasBL.ObtenerNotas(id);
            notas.ListadeNotasDetalle = _notasBL.ObtenerNotasDetalle(id);

            return View(notas);
        }
    }
}