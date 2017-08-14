using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    /*
     * Date:August 14,2017
     * Description: This is Splash Form
     * Version 0.2 - Fixed bug
     *
     * */
    public partial class Splash : Form
    {
        // PUBLIC PROPERTIES
        public BMICalculator BMICalculator
        {

            get
            {
                return Program.bmicalculatorForm;
            }

        }
        public Splash()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.BMICalculator.Show();

            this.Hide();

            SplashFormTimer.Enabled = false; // turn timer off
        }
    }
}
