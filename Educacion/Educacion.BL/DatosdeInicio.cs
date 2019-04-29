using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {

        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "antony";
            nuevoUsuario.Contraseña = Encriptar.CodificarContraseña("1234");
            nuevoUsuario.Nombre = "edwin";
            nuevoUsuario.Contraseña = Encriptar.CodificarContraseña("123");

            nuevoUsuario.Nombre = "amaya";
            nuevoUsuario.Contraseña = Encriptar.CodificarContraseña("123");

            contexto.Usuarios.Add(nuevoUsuario);
            base.Seed(contexto);
        }

    }
}
