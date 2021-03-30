using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invelitori_Convexe
{
    public partial class Form1 : Form
    {
        public static List<point> points = new List<point>();
        public static int n=15;
        

        public Form1()
        {
            InitializeComponent();

            /* Random r = new Random();

             for (int i = 0; i < n; i++)
             {
                 PointF p = new PointF(r.Next(400) % this.Size.Width - 20, r.Next(400) % this.Size.Height - 20);
               if (p.X < 10)
                     p.X = 10;
                 if (p.Y < 10)
                     p.Y = 10; 
                 points.Add(p);
             }*/
            /* PointF point1 = new PointF(300, 600);
             PointF point2 = new PointF(0, 300);
             PointF point3 = new PointF(150, 250);
             PointF point4 = new PointF(200, 0);
             PointF point5 = new PointF(500, 100);
             PointF point6 = new PointF(550, 200);
             PointF point7 = new PointF(700, 300);
             PointF point8 = new PointF(500, 400);
 */
            /*       PointF point1 = new PointF(130, 160);
                   PointF point2 = new PointF(100, 130);
                   PointF point3 = new PointF(115, 125);
                   PointF point4 = new PointF(120, 100);
                   PointF point5 = new PointF(150, 110);
                   PointF point6 = new PointF(155, 120);
                   PointF point7 = new PointF(170, 130);
                   PointF point8 = new PointF(150, 140);
           */
          /*  PointF point1 = new PointF(150, 300);
            PointF point2 = new PointF(0, 150);
            PointF point3 = new PointF(75, 125);
            PointF point4 = new PointF(100, 0);
            PointF point5 = new PointF(250, 50);
            PointF point6 = new PointF(275, 100);
            PointF point7 = new PointF(350, 150);
            PointF point8 = new PointF(250, 200);

            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
            points.Add(point4);
            points.Add(point5);
            points.Add(point6);
            points.Add(point7);
            points.Add(point8);*/
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (point p in points)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Red), p.X - 2, p.Y- 2, 2, 2);
            }
           // AlgSlab.AlgoritmulSlab(points, e);
           // SuperiorInferior.SepararePlanuri(points, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static Graphics gfx;

        static Random rnd = new Random();
        public class point
        {
            public float X, Y;
            public point()
            {
                X = rnd.Next(900);
                Y = rnd.Next(600);
            }
            public void Draw(Graphics grp)
            {
                grp.DrawEllipse(new Pen(Color.Red, 2), X, Y, 2, 2);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            point newPoint = new point();
            string[] text = textBox1.Text.Split(new[] { ' ' });
            newPoint.X= Int32.Parse(text[0]);
            newPoint.Y = Int32.Parse(text[1]);

            points.Add(newPoint);
            foreach (var p in points)
            {
                gfx.FillEllipse(new SolidBrush(Color.Black), p.X, p.Y, 2, 2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuperiorInferior.SepararePlanuri(points, e);
        }
    }
}
