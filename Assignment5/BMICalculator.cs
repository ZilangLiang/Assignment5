using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Date:August 13, 2017
/// Description: Finish the calculate for Imperial calculator, and add CalculatorButton method to the calculator.
/// version 0.1 - Added method to BMI calculator
/// </summary>
namespace Assignment5
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(InchesTextBox.Text);
            double height = Convert.ToDouble(PoundsTextBox.Text);
            double BMI = (weight * 703) / (height * height);
            ResultTextBox.Text = string.Format("{0:f}", BMI);

            if(BMI < 18.5)
            {
                label3.Text = "You are Unerweight";
            }
            if ((BMI > 18.5)&&(BMI < 24.9))
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
    }
}
