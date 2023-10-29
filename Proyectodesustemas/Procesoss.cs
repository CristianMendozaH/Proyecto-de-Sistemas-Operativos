using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodesustemas
{
    public partial class Procesoss : Form
    {
        public Procesoss()
        {
            InitializeComponent();
        }
        public static string GetOSFriendlyName()
        {
            string result = string.Empty;
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Caption")).FirstOrDefault();
            return name != null ? name.ToString() : "Unknown";
        }



        public void procesos()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Process");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                lbxProcesos.Items.Add(queryObj["Caption"].ToString());
            }
        }

        private void Procesoss_Load(object sender, EventArgs e)
        {
     
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            procesos();
            grpProcesos.Visible = true;
        }

        private void btnMaatarTodos_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptarProcesos_Click(object sender, EventArgs e)
        {
            grpProcesos.Visible = false;
        }

        private void btnMatar_Click(object sender, EventArgs e)
        {

        }
    }
}
