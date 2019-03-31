using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
    public class ReportedeAlumnosporClaseBL
    {
        Contexto _contexto;
        public List<ReportedeAlumnosporClase> ListaAlumnosporClase { get; set; }

        public ReportedeAlumnosporClaseBL()
        {
            _contexto = new Contexto();
            ListaAlumnosporClase = new List<ReportedeAlumnosporClase>();
        }

        public List<ReportedeAlumnosporClase> ObtenerAlumnosporClase()
        {
            ListaAlumnosporClase = _contexto.NotasDetalle
                .Include("Estudiante")
                .Include("Curso")
               
                .Where(r => r.Nota.Activo)
                .GroupBy(r => r.Materia.Materia)

                
                .Select(r => new ReportedeAlumnosporClase()
                {
                Materia = r.Key,

            } ).ToList();
            return ListaAlumnosporClase;

        }
    }
}