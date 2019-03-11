using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
   public class Cursos
    {
        [Required(ErrorMessage = "Ingrese el Id")]
        public int Id { get; set; }
        [Display(Name = "Curso")]
        [Required(ErrorMessage = "Ingrese el curso")]
        public string Curso { get; set; }
        [Required(ErrorMessage = "Ingrese la Modalidad")]
        public string Modalidad { get; set; }
        [Required(ErrorMessage = "Ingrese la seccion")]
        public string Seccion { get; set; }
        [Required(ErrorMessage = "Ingrese la Jornada")]
        public string Jornada { get; set; }
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        public bool Activo { get; set; }
    }
}
