using Microsoft.Win32;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace Proyectodesustemas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
       

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo infor = new ProcessStartInfo();
            //infor.UseShellExecute = true;
            //infor.FileName = "winver.exe";
            //Process.Start(infor);
            VersionW vistss = new VersionW();
            this.Hide();
            vistss.ShowDialog();
            this.Show();
        }

        private void btnhardware_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo hard = new ProcessStartInfo();
            //hard.UseShellExecute = true;
            //hard.FileName = "dxdiag.exe";
            //Process.Start(hard);

            Hardware el2 = new Hardware();
            this.Hide();
            el2.ShowDialog();
            this.Show();

        }

        private void btnProgramas_Click(object sender, EventArgs e)
        {
            ProcessStartInfo oPro = new ProcessStartInfo();
            oPro.UseShellExecute = true;
            oPro.FileName = "appwiz.cpl";
            Process.Start(oPro);

            //ProgramasXD el2 = new ProgramasXD();
            //this.Hide();
            //el2.ShowDialog();
            //this.Show();


        }

        private void btnTareas_Click(object sender, EventArgs e)
        {


            //Procesoss el2 = new Procesoss();
            //this.Hide();
            //el2.ShowDialog();
            //this.Show();


            ////pnlMain.Controls.Clear();

            //ProcesosActivos frmProccess = new ProcesosActivos();
            //this.Hide();
            ////pnlMain.Controls.Add(frmProccess);
            ////frmProccess.WindowState = FormWindowState.Maximized;
            //frmProccess.StartPosition = FormStartPosition.CenterParent;
            //frmProccess.ShowDialog();
            ////frmProccess.Show();
            //this.Show();


            Tareas.PantallaTareas el2 = new Tareas.PantallaTareas();
            this.Hide();
            el2.ShowDialog();
            this.Show();
        }

        private void btnMonitoreo_Click(object sender, EventArgs e)
        {
            //ProcessStartInfo mont = new ProcessStartInfo();

            //mont.UseShellExecute = true;
            //mont.FileName = "perfmon.exe";
            //Process.Start(mont);

            ProgramasXD redess = new ProgramasXD();
            this.Hide();
            redess.ShowDialog();
            this.Show();
        }

        private void btnred_Click(object sender, EventArgs e)
        {


            //RedesActivas redess = new RedesActivas();
            //this.Hide();
            //redess.ShowDialog();
            //this.Show();

            //pnlMain.Controls.Clear();
            List<ClassConecciones> conecciones = ClassConecciones.GetOutput();
            RedesActivas frconecciones = new RedesActivas(conecciones);
            this.Hide();
            //frconecciones.FormBorderStyle = FormBorderStyle.None;
            ////pnlMain.Controls.Add(conexiones);
            //frconecciones.WindowState = FormWindowState.Maximized;
            frconecciones.StartPosition = FormStartPosition.CenterParent;
            frconecciones.ShowDialog();
            //frconecciones.Show();
            this.Show();

        }

        private void btnConcurrencia_Click(object sender, EventArgs e)
        {
            Concurrencia con = new Concurrencia();
            this.Hide();
            con.ShowDialog();
            this.Show();
        }

        private void btninterblock_Click(object sender, EventArgs e)
        {
            Interbloqueo inter = new Interbloqueo();
            this.Hide();
            inter.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
