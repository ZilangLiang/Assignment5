﻿namespace Assignment5
{
    partial class Metric
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.InchesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.PoundsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.InputLabel = new System.Windows.Forms.Label();
            this.ShowBMI = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ImperialButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MetricButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.InchesTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PoundsTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.45544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.54456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 235);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(160, 43);
            this.ImperialButton.TabIndex = 0;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Location = new System.Drawing.Point(195, 3);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(130, 43);
            this.MetricButton.TabIndex = 1;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 63);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(179, 39);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height:";
            // 
            // InchesTextBox
            // 
            this.InchesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InchesTextBox.ForeColor = System.Drawing.Color.Silver;
            this.InchesTextBox.Location = new System.Drawing.Point(195, 66);
            this.InchesTextBox.Multiline = true;
            this.InchesTextBox.Name = "InchesTextBox";
            this.InchesTextBox.Size = new System.Drawing.Size(100, 25);
            this.InchesTextBox.TabIndex = 3;
            this.InchesTextBox.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "(Cm)";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 142);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(186, 39);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "My Weight:";
            // 
            // PoundsTextBox
            // 
            this.PoundsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoundsTextBox.ForeColor = System.Drawing.Color.Silver;
            this.PoundsTextBox.Location = new System.Drawing.Point(195, 145);
            this.PoundsTextBox.Multiline = true;
            this.PoundsTextBox.Name = "PoundsTextBox";
            this.PoundsTextBox.Size = new System.Drawing.Size(100, 25);
            this.PoundsTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "(Kg)";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.CalculateButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(52, 263);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 45);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CalculateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(54, 3);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(91, 39);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.InputLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ShowBMI, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(52, 330);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // InputLabel
            // 
            this.InputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(3, 30);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(194, 20);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "Your BMI:";
            this.InputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowBMI
            // 
            this.ShowBMI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowBMI.BackColor = System.Drawing.Color.White;
            this.ShowBMI.Enabled = false;
            this.ShowBMI.ForeColor = System.Drawing.Color.Silver;
            this.ShowBMI.Location = new System.Drawing.Point(50, 53);
            this.ShowBMI.Multiline = true;
            this.ShowBMI.Name = "ShowBMI";
            this.ShowBMI.Size = new System.Drawing.Size(100, 28);
            this.ShowBMI.TabIndex = 1;
            // 
            // Metric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "Metric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metric Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox InchesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox PoundsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox ShowBMI;
    }
}