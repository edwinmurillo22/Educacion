﻿using System;
using System.Collections.Generic;
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

        public int Id  { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int CursoId { get; set; }
        public Cursos Curso { get; set; }
        public bool Activo { get; set; }


    }
}
