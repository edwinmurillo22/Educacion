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
    public partial class Form2 : Form
    {
        ReportedeAlumnosporClaseBL _reportedeAlumnosporClaseBL;

        public Form2()
        {
            InitializeComponent();


            _reportedeAlumnosporClaseBL = new ReportedeAlumnosporClaseBL();

            RefrescarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
        private void RefrescarDatos()
        {
            var listaAlumnosporClase = _reportedeAlumnosporClaseBL.ObtenerAlumnosporClase();
            listaAlumnosporClaseBindingSource.DataSource = listaAlumnosporClase;
            listaAlumnosporClaseBindingSource.ResetBindings(false);
        }
    }
}
