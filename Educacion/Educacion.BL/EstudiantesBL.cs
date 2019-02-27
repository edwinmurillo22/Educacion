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

        public void GuardarEstudiantes(Estudiantes estudiantes)
        
        {
            if (estudiantes.Id == 0)
            {
                _contexto.Estudiantes.Add(estudiantes);
            }
            else
            {
                var estudiantesExistente = _contexto.Estudiantes.Find(estudiantes.Id);
                estudiantesExistente.Nombre = estudiantes.Nombre;
                estudiantesExistente.Direccion = estudiantes.Direccion;
                estudiantesExistente.Telefono = estudiantes.Telefono;

            }
                _contexto.SaveChanges();

        }

        public Estudiantes ObtenerEstudiante(int id)
        {
            var estudiantes = _contexto.Estudiantes.Find(id);
            return estudiantes;

        }

        public void EliminarEstudiante(int id)
        {
            var estudiantes = _contexto.Estudiantes.Find(id);
            _contexto.Estudiantes.Remove(estudiantes);
            _contexto.SaveChanges();

        }
    }
}