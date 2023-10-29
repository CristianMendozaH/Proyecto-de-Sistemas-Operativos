using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodesustemas
{
    public partial class RedesActivas : Form
    {
        private List<ClassConecciones> connections = new List<ClassConecciones>();
        public RedesActivas(List<ClassConecciones> Lstconnections)
        {
            InitializeComponent();
            this.connections = Lstconnections;
        }

        private void RedesActivas_Load(object sender, EventArgs e)
        {
            datos.DataSource = connections;
            datos.Refresh();
        }
    }
}
