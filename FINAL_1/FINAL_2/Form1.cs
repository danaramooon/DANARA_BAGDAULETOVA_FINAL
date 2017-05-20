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
        Button[,] button = new Button[3, 3];
        string memorize = "";
        int memnum = 0;
        public int x = 1, y = 1;
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
                    return false;
            }
            return true;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "0")
            btn.Text = " ";
            btn.Text = x.ToString();
            x++;
            memnum = x;
            memorize = btn.Text;
            if (x != memnum)
                x = int.Parse(btn.Text);
            


            if (is_prime(int.Parse(btn.Text)))
            {
                textBox1.Text = y.ToString();
                y++;

            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Size = new Size(51, 51);
                    button[i, j].Location = new Point(i * 51, j * 51);
                    button[i, j].Text = "0";
                    button[i, j].Click += new EventHandler(button15_Click);
                    Controls.Add(button[i, j]);
                }
            }
        }
       
    }
}
