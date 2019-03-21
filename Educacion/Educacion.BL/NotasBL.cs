using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
  public  class NotasBL
    {
        Contexto _contexto;

        public List<Notas> listadeNotas { get; set; }

        public NotasBL()
        {
            _contexto = new Contexto();
            listadeNotas = new List<Notas>();
        }


        public List<Notas> ObtenerNotas()
        {
            listadeNotas = _contexto.Notas
                .Include("Estudiante")
                .Include("Curso")
               .ToList();

            return listadeNotas;

        }

        public List<NotasDetalle> ObtenerNotasDetalle(int notasId)
        {
            var listadeNotasDetalle = _contexto.NotasDetalle
                .Include("Materia")
                .Where(o => o.NotaId ==notasId).ToList();

            return listadeNotasDetalle;
        }

        public NotasDetalle ObtenerNotasDetallePorId(int id)
        {
            var notasDetalle = _contexto.NotasDetalle
                .Include("Materia").FirstOrDefault(p => p.Id == id);

            return notasDetalle;
        }

        public Notas ObtenerNotas(int id)
        {
            var notas = _contexto.Notas
                .Include("Estudiante")
                .Include("Curso")
                .FirstOrDefault(p => p.Id == id);

            return notas;
        }

        public void GuardarNotas(Notas notas)

        {
            if (notas.Id == 0)
            {
                _contexto.Notas.Add(notas);
            }
            else
            {
                var notasExistente = _contexto.Notas.Find(notas.Id);
                notasExistente.CursoId = notas.CursoId;
                notasExistente.EstudianteId = notas.EstudianteId;
                notasExistente.Anio = notas.Anio;
              
                notasExistente.Activo =  notas.Activo;

              
            }
            _contexto.SaveChanges();

        }

        public void GuardarNotasDetalle(NotasDetalle notasDetalle)
        {
           

            notasDetalle.NotaFinal = notasDetalle.PrimerParcial + notasDetalle.SegundoParcial + notasDetalle.TercerParcial/3; 

                _contexto.NotasDetalle.Add(notasDetalle);


            _contexto.SaveChanges();
        }

        public void EliminarNotasDetalle(int id)
        {
            var notasDetalle = _contexto.NotasDetalle.Find(id);
            _contexto.NotasDetalle.Remove(notasDetalle);

          

            _contexto.SaveChanges();
        }
    }
}

