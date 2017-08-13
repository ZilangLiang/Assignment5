using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Date: August 13, 2017
/// Description: this is the UI for Metric Calculator
/// version 0.2 - Changed Metric Calculator
/// </summary>
namespace Assignment5
{
    public partial class Metric : Form
    {
        //PUBLIC PROPERTIES
        public BMICalculator BMICalculator
        {
            get
            {
                return Program.bmicalculatorForm;
            }
        }


        public Metric()
        {
            InitializeComponent();
        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BMICalculator.Show();

            this.Hide();
        }
    }
}
