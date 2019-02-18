using Educacion.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educacion.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var estudiantesBL = new EstudiantesBL();

            var listadeEstudiantes = estudiantesBL.ObtenerEstudiantes();

            listadeEstudiantesBindingSource.DataSource = listadeEstudiantes;
        }
    }
}
