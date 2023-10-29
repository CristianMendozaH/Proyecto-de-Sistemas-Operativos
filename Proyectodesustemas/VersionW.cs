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
    public partial class VersionW : Form
    {
        public VersionW()
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

        private void VersionW_Load(object sender, EventArgs e)
        {
            grpwindows.Visible = true;
            lblWindows.Text = GetOSFriendlyName();
            lblVWindows.Text = "System.Environment.OSVersion:\n\n" + System.Environment.OSVersion.ToString();
            label3.Text = "Version del sistema operativo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
