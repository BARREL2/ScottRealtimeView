﻿namespace ScottRealtimeView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            formsPlot1 = new ScottPlot.FormsPlot();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(13, 48);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(774, 390);
            formsPlot1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(90, 12);
            button1.Name = "button1";
            button1.Size = new Size(285, 39);
            button1.TabIndex = 1;
            button1.Text = "開始";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 12);
            button2.Name = "button2";
            button2.Size = new Size(310, 39);
            button2.TabIndex = 2;
            button2.Text = "終了";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(formsPlot1);
            Name = "Form1";
            Text = "プロット";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
    }
}