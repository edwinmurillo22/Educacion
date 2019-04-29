using Educacion.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Educacion.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        SeguridadBL _seguridadBL;

        public LoginController()
        {
            _seguridadBL = new SeguridadBL();
        }
        // GET: Login
        public ActionResult Index()
        {

            FormsAuthentication.SignOut();
            return View();
        }


        [HttpPost]

        public ActionResult Index(FormCollection data)
        {
            var nombreUsuario = data["username"];
            var contraseña = data["password"];

            var usuarioValido = _seguridadBL
                .Autorizar(nombreUsuario, contraseña);

            if (usuarioValido)
            {
                FormsAuthentication.SetAuthCookie(nombreUsuario, true);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Usuario o contraseña invalido");




            return View();

        }


    }
}