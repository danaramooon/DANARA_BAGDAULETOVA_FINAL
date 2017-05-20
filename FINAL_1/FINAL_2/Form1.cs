using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_2
{
    public partial class Form1 : Form
    {
        public int x = 0, y = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public bool is_prime(int x)
        {
            if (x == 1 | x == 0)
                return false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return true;
            }
            return true;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text += x;
            x++;
            btn.Text = btn.Text;
            if (is_prime(int.Parse(btn.Text)))
            {
                textBox1.Text += y;
                y++;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
