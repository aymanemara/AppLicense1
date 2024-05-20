using SoftwareLocker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void StartSplash()
        {
            try
            {
                Application.Run(new SplashScreen1());
            }
            catch (Exception) { }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread t1;
            try
            {
                t1 = new Thread(new ThreadStart(StartSplash));
                t1.Start();
                Thread.Sleep(5000);
                t1.Abort();
            }
            catch (Exception) { }
            TrialMaker t = new TrialMaker("AiPOS",
                  Application.StartupPath + "\\Key.reg",
                  Environment.GetFolderPath(Environment.SpecialFolder.System) +
                    "\\AppLic.dbf",
                  "Phone: +84933913122\nMobile: +84 937416907",
                  3, // allow use trial app 3 days
                  5, // or allow use app 5 times
                  "183" // password for make license
                  );

            t.UseProcessorID = true;
            t.UseBiosVersion = true;

            byte[] MyOwnKey = { 97, 250,  1,  5,  84, 21,   7, 63,
                         4,  54, 87, 56, 123, 10,   3, 62,
                         7,   9, 20, 36,  37, 21, 101, 57};
            t.TripleDESKey = MyOwnKey;
            // if you don't call this part the program will
            //use default key to encryption

            TrialMaker.RunTypes RT = t.ShowDialog();
            bool is_trial;
            if (RT != TrialMaker.RunTypes.Expired)
            {
                if (RT == TrialMaker.RunTypes.Full)
                    is_trial = false;
                else
                    is_trial = true;

                Application.Run(new Form1());
            }
          
        }
    }
}
