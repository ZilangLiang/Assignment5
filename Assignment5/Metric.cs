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
/// version 0.3 - Changed Metric calculator Method
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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(CmTextBox.Text);
            double height = Convert.ToDouble(KgTextBox.Text);
            double BMI = weight / ((height / 100) * (height / 100));
            ResultTextBox.Text = string.Format("{0:f}", BMI);

            if (BMI < 18.5)
            {
                label3.Text = "You are Unerweight";
            }
            if ((BMI > 18.5) && (BMI < 24.9))
            {
                label3.Text = "You have normal weight";
            }
            if ((BMI > 25) && (BMI < 29.9))
            {
                label3.Text = "you are Overweight";
            }
            else
            {
                label3.Text = "You are obese";
            }
        }

        private void Metric_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
