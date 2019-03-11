using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
   public class Materias
    {
        public Materias()
        {
            Activo = true;
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese la Materia")]
        public string Materia { get; set; }
        public int CursoId { get; set; }
        public Cursos Curso { get; set; }
        public bool Activo { get; set; }

    }
}
