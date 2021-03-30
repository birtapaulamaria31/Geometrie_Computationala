using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing.PointF;

namespace Desenare_triunghi
{
    public partial class Form1 : Form
    {
        private static Graphics gfx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gfx = pictureBox1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Point[] points = new Point[3];
            points[0] = new Point(x: int.Parse(textBox1.Text), y: int.Parse(textBox2.Text));
            points[1] = new Point(x: int.Parse(textBox3.Text), y: int.Parse(textBox4.Text));
            points[2] = new Point(x: int.Parse(textBox5.Text), y: int.Parse(textBox6.Text));

            gfx.Clear(Color.White);
            gfx.DrawPolygon(new Pen(Color.Black), points);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox2.Text.Length > 0 ? textBox2.Text : "0");
            if (value > 250)
            {
                textBox2.Text = "250";
            }
        }
    }
}
