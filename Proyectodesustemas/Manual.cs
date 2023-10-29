using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodesustemas
{
    public partial class Manual : Form
    {
        public Manual()
        {
            InitializeComponent();
        }

        private void Manual_Load(object sender, EventArgs e)
        {

            //var p = new Process();
            //p.StartInfo.Arguments = @"C:\Temp\tests\bin\Debug\netcoreapp2.1\ElPDF.pdf";
            //p.StartInfo.FileName = @"C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe";
            //p.Start();


        //    openfiledialog opf = new openfiledialog();
        //    opf.filter = "manual|*.pdf";
        //    if (opf.showdialog() == dialogresult.ok)
        //    {
        //        if (file.exists(opf.filename))
        //        {
        //            this.pdfviewer1.loadfromfile(opf.filename);
        //        }
        //    }
        }

        private void pdfViewer1_Click(object sender, EventArgs e)
        {
      
        }
    }
}
