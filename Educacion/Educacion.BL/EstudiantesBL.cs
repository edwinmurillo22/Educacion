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

        public List<Estudiantes> listadeEstudiantes { get; set; }

        public EstudiantesBL()
        {
            _contexto = new Contexto();
            listadeEstudiantes = new List<Estudiantes>();
        }


        public List<Estudiantes> ObtenerEstudiantes()
        {
            listadeEstudiantes = _contexto.Estudiantes.ToList();
                
            return listadeEstudiantes;

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
              
                estudiantesExistente.Activo = estudiantes.Activo;
                estudiantesExistente.UrlImagen = estudiantes.UrlImagen;
            }
                _contexto.SaveChanges();

        }

        public Estudiantes ObtenerEstudiante(int id)
        {
            var estudiantes = _contexto.Estudiantes.FirstOrDefault(p => p.Id == id);
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