using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace зачет
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mim = textBox1.Text;
            int[] nums = mim.Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            int sum = 0;

            foreach(int num in nums)
            {
                if(num % 2 == 0)
                {
                    count++;
                    sum += num;
                }
            }
            double a = count > 0 ? sum / count : 0;
            label2.Text = "Среднее арифметическое четных чисел: " + a.ToString();
        }
    }
}
