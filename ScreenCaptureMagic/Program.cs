using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ScreenCaptureMagic.Util;
using System.Windows.Forms;


namespace ScreenCaptureMagic
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                string url;
                if (args.Length > 0)
                {
                    url = args[0];
                    SpiderAndCapture c = new SpiderAndCapture(url);
                    GenerateReport.createReport(c.Site_info);
                    
                }
                else
                {
                    StartAsWinform();
                }
            }
            catch (Exception ex)
            {
                AppHelpers.statusMessage("An unhandled Exception occurred: " + ex.Message);
                StreamWriter fs = new StreamWriter("error.txt", false);
                fs.WriteLine(DateTime.Now.Date + " - " + DateTime.Now.TimeOfDay);
                fs.WriteLine(ex.Message);
                fs.WriteLine(ex.Source);
                fs.WriteLine(ex.StackTrace);
                fs.Close();
                fs.Dispose();
            }
             
        }


        static void StartAsWinform()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppStarter());
        }
    }
}
