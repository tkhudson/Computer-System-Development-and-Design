using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorRecursive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int InputNo = 0, Result = 0, Y = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                InputNo = int.Parse(textBox1.Text);
                Result = ComputeTheFactorial(InputNo);
                label1.Text = Result.ToString("N0");
            }
            catch
            {
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            label1.Text = "";
        }
        public int ComputeTheFactorial(int InNum)
        {
            MessageBox.Show(" Call of recursive method number = " + Y++);
            MessageBox.Show(" InNum = " + InNum);
            if (InNum == 1)
                return 1;
            else
                MessageBox.Show(" Result before recursive call = " + Result);
                Result = ComputeTheFactorial(InNum - 1) * InNum;
                MessageBox.Show(" Return from recursive method number = " + Y--);
                MessageBox.Show(" Sec InNum = " + InNum);
                MessageBox.Show(" Result after return from recursive call = " + Result);
            return Result;
        }
    }
}
