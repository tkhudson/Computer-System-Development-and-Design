using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2Palindrome
{
    //Devs: Slytherin House
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string intext = txtInput.Text;
            char[] comptext = intext.ToCharArray();
            Array.Reverse(comptext);
            string endtext = new string(comptext);

            //then test if palindrome or not

            if (intext == endtext)
            {
                MessageBox.Show("This is a palindrome!");
            }
            if (intext != endtext)
            {
                MessageBox.Show("This is not a palindrome :(");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Exit");
            }
        }
    }
}
