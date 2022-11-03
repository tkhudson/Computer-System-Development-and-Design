using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorIterations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int NumIn = 0, Fact = 0, i = 0;
        private void button1_Click(object sender, EventArgs e)
        {//Code behind the COMPUTE button
            try
            {
                Fact = 1;
                NumIn = int.Parse(textBox1.Text);
                for (i = 1; i <= NumIn; i++)
                {
                    Fact = Fact * i;
                }
                label1.Text = Fact.ToString("N0");
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                label1.Text = "";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
