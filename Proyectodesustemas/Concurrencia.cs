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
    public partial class Concurrencia : Form
    {
        public Concurrencia()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private async Task addlv(String platillo, int noPlatillo, String bebida, int noBebida)
        {
            String res = await prepareAsync(platillo, Convert.ToString(noPlatillo));
            lvOrdenes.Items.Add(res);

            String res1 = await prepareAsync(bebida, Convert.ToString(noBebida));
            lvOrdenes.Items.Add(res1);
            /*
            var res = new Task[1];
            Task.WaitAll(res);
            */
        }
        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            String platillo = cbxMenu.Text;
            String bebida = cbxBebida.Text;
            int noPlatillo = Convert.ToInt32(txtCantidadPlatillo.Text);
            int noBebida = Convert.ToInt32(txtCantidadBebida.Text);
            if (noPlatillo > 0 || noBebida > 0)
            {

                addlv(platillo, noPlatillo, bebida, noBebida);

            }
            else
            {
               lblNotificationOrden.Text = "no puede generar orden";
            }
        }
        static async Task<String> prepareAsync(string cocinar, String tiempo)
        {
            int tiemp = Convert.ToInt32(tiempo);
            await Task.Delay(tiemp * 1000);
            String ar = cocinar + " Tiempo en se tardo en minutos" + tiempo;

            return ar;
        }

        private void btnAceptarConcurrencia_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Concurrencia_Load(object sender, EventArgs e)
        {

        }
    }
}
