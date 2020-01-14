using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{   /// <summary>
/// Entry Point of Application
/// </summary>
    static class Program
    {   
        /// <summary>
        /// Method without Parameters
        /// </summary>
        static void MyMethod()
        {
            Console.WriteLine("Program has been Executed.");
            MessageBox.Show("Press Ok to Continue...");
        }
        /// <summary>
        /// Method with Parameters
        /// </summary>
        /// <param name="fname"></param>
        static void Method1(string fname)
        {
            Console.WriteLine("This Application is Created By " + fname + ".");
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyMethod();
            Method1("Nischal Gyawali");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
