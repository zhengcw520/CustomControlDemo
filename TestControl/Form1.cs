using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestControl
{
    public partial class Form1 : Form
    {
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            progressBarControl1.ForeColor = Color.Red;
            progressBarControl1.FontColor = Color.Green;

            timer1.Start();

            //progressBarControl1. = 67;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index++;
            textEdit1.Text = index.ToString();
            progressBarControl1.CurrentValue += 1;
            if (progressBarControl1.CurrentValue > progressBarControl1.MaxValue)
                progressBarControl1.CurrentValue = 0;
        }
    }
}
