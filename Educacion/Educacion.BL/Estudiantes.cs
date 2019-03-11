using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educacion.BL
{
    public class Estudiantes
    {
        public Estudiantes()
        {
            Activo = true;
        }


        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Ingrese el Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese la Direccion")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Ingrese el Telefono")]

        public int Telefono { get; set; }

        public int CursoId { get; set; }

        public Cursos Curso { get; set; }
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }
        public bool Activo { get; set; }

    }
}
