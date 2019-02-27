using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
    public class CursosBL
    {

        Contexto _contexto;

        public List<Cursos> ListadeCursos { get; set; }

        public CursosBL()
        {
            _contexto = new Contexto();
            ListadeCursos = new List<Cursos>();
        }


        public List<Cursos> ObtenerCursos()
        {

            ListadeCursos = _contexto.Cursos.ToList();
            return ListadeCursos;

        }

        public void GuardarCursos(Cursos cursos)

        {
            if (cursos.Id == 0)
            {
                _contexto.Cursos.Add(cursos);
            }
            else
            {
                var cursosExistente = _contexto.Cursos.Find(cursos.Id);
                cursosExistente.Curso = cursos.Curso;
                cursosExistente.Modalidad = cursos.Modalidad;
                cursosExistente.Seccion = cursos.Seccion;
                cursosExistente.Jornada = cursos.Jornada;

            }
            _contexto.SaveChanges();

        }

        public Cursos ObtenerCursos(int id)
        {
            var cursos = _contexto.Cursos.Find(id);
            return cursos;

        }

        public void EliminarCursos(int id)
        {
            var cursos = _contexto.Cursos.Find(id);
            _contexto.Cursos.Remove(cursos);
            _contexto.SaveChanges();


        }
    }
}
