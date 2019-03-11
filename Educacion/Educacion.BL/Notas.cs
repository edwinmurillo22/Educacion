using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
    public class Notas
    {
        public int Id { get; set; }

        public int CursoId { get; set; }
        public Cursos Curso { get; set; }
        public int Anio { get; set; }
        public int NotaFinal { get; set; }
        public bool Activo { get; set; }


        public Notas()
        {
            Activo = true;
       
           
        }


    }

    public class NotasDetalle
    {
        public int Id { get; set; }

        public int NotaId { get; set; }
        public Notas Nota { get; set; }

        

        public int EstudianteId { get; set; }
        public Estudiantes Estudiante { get; set; }

        public int MateriaId { get; set; }
        public Materias Materia { get; set; }

        public int PrimerParcial { get; set; }
        public int SegundoParcial { get; set; }
        public int TercerParcial { get; set; }
        public int CuartoParcial { get; set; }

        public int NotaFinal { get; set; }
    }

}
