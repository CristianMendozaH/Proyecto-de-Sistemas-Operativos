using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodesustemas
{
    public class ActivosProcesos
    {
        string aplicacion;
        int pid;
        string ram;
        bool status;

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);


        public string Aplicacion { get => aplicacion; set => aplicacion = value; }
        public int Pid { get => pid; set => pid = value; }
        public string Ram { get => ram; set => ram = value; }
        public bool Status { get => status; set => status = value; }

        public static List<ActivosProcesos> fillProcess()
        {
            var lstProcess = new List<ActivosProcesos>();
            try
            {
                // Ejecutar el comando tasklist
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "tasklist",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Arguments = "/V /FO CSV"
                };
                process.StartInfo = startInfo;
                process.Start();

                int i = 0;
                // Leer la salida del comando y agregarla a la lista
                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    string[] subs = line.Split(',');

                    ActivosProcesos tmpProccess = new ActivosProcesos();
                    if (i > 1)
                    {
                        tmpProccess.Aplicacion = subs[0].Replace("\"", "");
                        tmpProccess.Ram = subs[4].Replace("\"", "");
                        tmpProccess.Pid = int.Parse(subs[1].Replace("\"", ""));

                        lstProcess.Add(tmpProccess);
                    }
                    i++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lstProcess;
        }
        public static void KillProccess(int pid)
        {

            var process = Process.GetProcessById(pid); // throws exception if process does not exist

            process.Kill();
        }

        public static void SuspendProcess(int pid)
        {
            var process = Process.GetProcessById(pid); // throws exception if process does not exist

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                SuspendThread(pOpenThread);

                CloseHandle(pOpenThread);
            }
        }

        public static void ResumeProcess(int pid)
        {
            var process = Process.GetProcessById(pid);

            if (process.ProcessName == string.Empty)
                return;

            foreach (ProcessThread pT in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    continue;
                }

                var suspendCount = 0;
                do
                {
                    suspendCount = ResumeThread(pOpenThread);
                } while (suspendCount > 0);

                CloseHandle(pOpenThread);
            }
        }
    }
}
