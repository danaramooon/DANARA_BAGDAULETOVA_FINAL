using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FINAL_4
{
    public partial class Form1 : Form
    {
        int x = 50, y = 50;
        int r = 100;
        Graphics g;
        SolidBrush br ;
        public Form1()
        {
            InitializeComponent();
            br = new SolidBrush(Color.Aqua);
            g = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            g.FillEllipse(br,x, y, r, r);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 100;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
