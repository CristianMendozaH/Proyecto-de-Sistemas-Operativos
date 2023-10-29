using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectodesustemas
{
    internal class ClassActions
    {
        public static string executeCmd(string cmd)
        {
            try
            {
                System.Diagnostics.Process.Start(cmd);
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static string executeProcess(string path)
        {
            var myProccess = new Process();
            try
            {

                myProccess.StartInfo = new ProcessStartInfo(path)
                {
                    UseShellExecute = true
                };
                myProccess.Start();
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public static IntPtr runProcces(string procName)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = procName,
                UseShellExecute = true, // Utilizar el shell para mostrar la ventana en el panel
                RedirectStandardOutput = false,
                CreateNoWindow = true
            };
            process.StartInfo = startInfo;
            process.EnableRaisingEvents = true;
            process.Exited += (s, args) =>
            {
                // Cerrar el proceso y liberar recursos cuando se cierre la ventana "winver"
                process.Close();
                process.Dispose();
            };
            process.Start();

            // Espera a que se cargue la ventana "winver"
            process.WaitForInputIdle();

            // Obtén el identificador de ventana de "winver"
            IntPtr winverHandle = process.MainWindowHandle;

            return winverHandle;
        }
    }
}
