using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodesustemas
{
    public partial class ProgramasXD : Form
    {
        public ProgramasXD()
        {
            InitializeComponent();
        }

        private void ProgramasXD_Load(object sender, EventArgs e)
        {
         

            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
            int count = 0;
            while (count != 10)
            {
                count++;
                lvMonitoreo.Items.Add(cpuCounter.NextValue() + "%");
                Thread.Sleep(1000);
            }
            grpMonitoreo.Visible = true;
        }
    }
}
