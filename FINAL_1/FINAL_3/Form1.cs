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
            for(int i = 1; i <=12; i++)
            {
                
                    if (int.Parse(label2.Text) == i)
                    {
                        label2.ForeColor = Color.Red;
                    label3.ForeColor = Color.Black;
                        
                    }
                  if (i == int.Parse(label3.Text))
                 {
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Red;
                    label4.ForeColor = Color.Black;

                }
               if (i ==int.Parse(label4.Text) )
                {
                  
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Red;
                    
                }
                if (int.Parse(label5.Text) == i)
                {
                    
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Red;
                    
                }
                if (i == int.Parse(label4.Text))
                {
                    
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Red;

                }
                if (int.Parse(label6.Text) == i)
                {
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label6.ForeColor = Color.Red;

                }
            }
               
        }
    }
}
