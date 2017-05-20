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
using System.Xml.Serialization;
using System.IO;

namespace FINAL_4
{
    public partial class Form1 : Form
    {
        int x = 50, y = 50;
        int r = 50;
        Random t;
        Graphics g;
        SolidBrush br ;
        Bitmap btm;
        public Form1()
        {
            InitializeComponent();
            br = new SolidBrush(Color.Aqua);
            g = pictureBox1.CreateGraphics();
            t = new Random();
            //btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //g = Graphics.FromImage(btm);
           // pictureBox1.Image = btm;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            g.FillEllipse(br,x, y, r, r);
            timer1.Enabled = true;
            x = t.Next(10, pictureBox1.Width);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.S)
            {
                try
                {
                    FileStream fs = new FileStream("ball.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    XmlSerializer xml1 = new XmlSerializer(typeof(PictureBox));
                    xml1.Serialize(fs, btm);
                    fs.Close();
                }
                catch (Exception y)
                {

                }
            }
            if (e.KeyCode == Keys.D)
            {
                try
                {
                    FileStream fs = new FileStream("ball.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    XmlSerializer xml1 = new XmlSerializer(typeof(Graphics));
                    //pictureBox1 = xml1.Deserialize(fs); 
                    fs.Close();
                }
                catch (Exception y)
                {


                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            y += 50;
            g.FillEllipse(br, x, y, r, r);

            if (y > pictureBox1.Height)
                y = 50;
           
            

        }
    }
}
