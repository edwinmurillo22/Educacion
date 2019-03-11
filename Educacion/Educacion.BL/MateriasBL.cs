using Educacion.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
    public class MateriasBL
    {

        Contexto _contexto;

        public List<Materias> ListadeMaterias { get; set; }

        public MateriasBL()
        {
            _contexto = new Contexto();
            ListadeMaterias = new List<Materias>();
        }


        public List<Materias> ObtenerMaterias()
        {

            ListadeMaterias = _contexto.Materias
               .Include("Curso")
               .ToList();
            return ListadeMaterias;

        }

        public void GuardarMaterias(Materias materias)

        {
            if (materias.Id == 0)
            {
                _contexto.Materias.Add(materias);
            }
            else
            {
                var materiasExistente = _contexto.Materias.Find(materias.Id);
                materiasExistente.Materia = materias.Materia;
                materiasExistente.CursoId = materias.CursoId;
                materiasExistente.Activo = materias.Activo;



            }
            _contexto.SaveChanges();

        }

        public Materias ObtenerMaterias(int id)
        {
            var materias = _contexto.Materias
                 .Include("Curso").FirstOrDefault(p => p.Id == id);
            return materias;

        }

        public void EliminarMaterias(int id)
        {
            var materias = _contexto.Materias.Find(id);
            _contexto.Materias.Remove(materias);
            _contexto.SaveChanges();


        }
    }
}


 
