using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = {int.Parse(label1.Text), int.Parse(label3.Text), int.Parse(label4.Text), int.Parse(label5.Text), int.Parse(label6.Text) };
            for(int i = 1; i <=12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (int.Parse(label2.Text) == i)
                    
                            label2.ForeColor = Color.Red;
                        if (int.Parse(label3.Text) == i)
                            label3.ForeColor = Color.Red;
                    
                }

            }
            
        }
    }
}
