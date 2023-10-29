using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Linq;

namespace Proyectodesustemas
{
    public partial class MenuP : Form
    {
        public MenuP()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Confirmacion Confirma = new Confirmacion();
            //this.Hide();
            //Confirma.ShowDialog();
            //this.Show();

            Inicio primero = new Inicio();
            this.Hide();
            primero.ShowDialog();
            this.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Creador informacion = new Creador();
            //this.Hide();
            informacion.ShowDialog();
            //this.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\Users\crist\Documents\Proyecto de Sistema\Hola\Proyectodesustemas con loading - copia - copia\Proyectodesustemas\bin\Debug\Manual.pdf";
            proceso.Start();
            //Manual manualxs = new Manual();
            //this.Hide();
            //manualxs.ShowDialog();
            //this.Show();
        }
    }
}
