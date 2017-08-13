using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    /*
     * Name: ZiLang Liang
     * Date: August 3,2017
     * version 0.1 - Changed to Metric in order to test Metric calculator
     * */
    static class Program
    {
        //Create Reference to FOrms
        public static BMICalculator bmicalculatorForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bmicalculatorForm = new BMICalculator();

            Application.Run(new Metric());
        }
    }
}
