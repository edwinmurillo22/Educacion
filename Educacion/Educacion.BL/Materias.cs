using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
   public class Materias
    {
        public int Id { get; set; }
        public string Materia { get; set; }
        public Cursos Curso { get; set; }
       
    }
}
