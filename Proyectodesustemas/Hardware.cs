using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodesustemas
{
    public partial class Hardware : Form
    {
        public Hardware()
        {
            InitializeComponent();
        }

        private void Hardware_Load(object sender, EventArgs e)
        {
            ManagementScope scope = new ManagementScope("\\root\\cimv2");
            //Crear un objeto para consultar una tabla del namespace
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_LogicalDisk where drivetype=3");
            //Ejecutar el query
            ManagementObjectSearcher mos = new ManagementObjectSearcher(scope, query);

            //Iterar en los resultados del query
            foreach (ManagementObject item in mos.Get())
            {
                long hddSizeBytes = Int64.Parse(item["Size"].ToString());
                double hddSizeGBytes = hddSizeBytes / 1024 / 1024 / 1024;
                lvHardware.Items.Add("Tamaño de disco: = " + hddSizeGBytes + "GB");
            }
            String path = "HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(path);
            String processor = key.GetValue("ProcessorNameString").ToString();
            lvHardware.Items.Add("Procesador: =" + processor);
        }

        private void lvHardware_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
