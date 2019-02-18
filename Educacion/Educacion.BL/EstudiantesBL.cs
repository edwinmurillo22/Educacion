using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
   public class EstudiantesBL
    {

        Contexto _contexto;

        public List<Estudiantes> ListadeEstudiantes { get; set; }

        public EstudiantesBL()
        {
            _contexto = new Contexto();
            ListadeEstudiantes = new List<Estudiantes>();
        }


        public List<Estudiantes> ObtenerEstudiantes()
        {

            ListadeEstudiantes = _contexto.Estudiantes.ToList();
            return ListadeEstudiantes;

        }
    }
}