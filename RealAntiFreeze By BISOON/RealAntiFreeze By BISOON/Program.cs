using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealAntiFreeze_By_BISOON
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //try
            //{
            //    WebClient wb = new WebClient();
            //    string[] info = wb.DownloadString("http://pastebin.com/raw.php?i=mxfrFkpL").Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //    if (bool.Parse(info[0]) == false)
            //    {
            //        string appPath = Application.ExecutablePath;
            //        MessageBox.Show(info[1], "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        new Process { StartInfo = { WindowStyle = ProcessWindowStyle.Minimized, FileName = "cmd.exe", Arguments = "/C Y /N /D Y /T 6 & Del \"" + appPath + "\"", CreateNoWindow = true } }.Start();
            //        Environment.Exit(0);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Should Connect To The Enternet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Process.GetCurrentProcess().Kill();
            //}
            Application.Run(new mainForm());
        }
    }
}
