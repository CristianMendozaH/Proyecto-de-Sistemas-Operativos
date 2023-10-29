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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Info_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Animation.Start();

        }

        private void Animation_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            bar.Value += 1;
            //lblValue.Text = $"{bar.Value.ToString()}%";
            if (bar.Value == 100)
            { 
                Animation.Stop();
                HideAnimation.Start();
            }
            
        }

        private void HideAnimation_Tick(object sender, EventArgs e)
        {
            this .Opacity -= 1;
            if (this.Opacity == 0)
            {
                HideAnimation .Stop();
                MenuP menu11 = new MenuP();
                menu11.Show();    
                this.Hide();
            }
        }
    }
}
