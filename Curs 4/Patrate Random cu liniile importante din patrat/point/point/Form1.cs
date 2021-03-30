using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myGraphics.initGraph(pictureBox1);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            myGraphics.refreshGraph();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            myGraphics.clearGraph();
            myGraphics.refreshGraph();
        }

        static Random randomPozition = new Random();
        static Random randomSize = new Random();
        private void btn_addPoint_Click(object sender, EventArgs e)
        {
            for(int i=0; i<8; i++)
            {
                // float X = float.Parse(textBox1.Text); ///orizontala
                //float Y = float.Parse(textBox2.Text);  ///verticala
                float X = randomPozition.Next(0, 250);
                float Y = X;
                float size = randomSize.Next(10, 200);
                Engine.points.Add(new myPoint(X, Y));
                Engine.points.Add(new myPoint(X + size, Y));
                Engine.points.Add(new myPoint(X + size, Y + size));
                Engine.points.Add(new myPoint(X, Y + size));
                Engine.draw(myGraphics.grp);

                point.myPoint p0 = new point.myPoint();
                point.myPoint p1 = new point.myPoint();
                point.myPoint p2 = new point.myPoint();
                point.myPoint p3 = new point.myPoint();
                p0.X = (Engine.points[0].X + Engine.points[1].X) / 2;
                p0.Y = (Engine.points[0].Y + Engine.points[1].Y) / 2;
                p1.X = (Engine.points[1].X + Engine.points[2].X) / 2;
                p1.Y = (Engine.points[1].Y + Engine.points[2].Y) / 2;
                p3.X = (Engine.points[0].X + Engine.points[3].X) / 2;
                p3.Y = (Engine.points[0].Y + Engine.points[3].Y) / 2;
                p2.X = (Engine.points[3].X + Engine.points[2].X) / 2;
                p2.Y = (Engine.points[3].Y + Engine.points[2].Y) / 2;
                Engine.pointsMedians.Add(p0);
                Engine.pointsMedians.Add(p1);
                Engine.pointsMedians.Add(p2);
                Engine.pointsMedians.Add(p3);
                Engine.drawMedians(myGraphics.grp);
                Engine.drawDiagonals(myGraphics.grp);

                myGraphics.refreshGraph();
                Engine.points.Clear();
                Engine.pointsMedians.Clear();
            }

            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            myGraphics.clearGraph();
            Engine.remove();
            Engine.draw(myGraphics.grp);
            myGraphics.refreshGraph();
        }

        private static Graphics gfx;
        private void btn_drawMedians_Click(object sender, EventArgs e)
        {
           
            point.myPoint p0 = new point.myPoint();
            point.myPoint p1 = new point.myPoint();
            point.myPoint p2 = new point.myPoint();
            point.myPoint p3 = new point.myPoint();
            p0.X = (Engine.points[0].X + Engine.points[1].X) / 2;
            p0.Y = (Engine.points[0].Y + Engine.points[1].Y) / 2;
            p1.X = (Engine.points[1].X + Engine.points[2].X) / 2;
            p1.Y = (Engine.points[1].Y + Engine.points[2].Y) / 2;
            p3.X = (Engine.points[0].X + Engine.points[3].X) / 2;
            p3.Y = (Engine.points[0].Y + Engine.points[3].Y) / 2;
            p2.X = (Engine.points[3].X + Engine.points[2].X) / 2;
            p2.Y = (Engine.points[3].Y + Engine.points[2].Y) / 2;
            Engine.pointsMedians.Add(p0);
            Engine.pointsMedians.Add(p1);
            Engine.pointsMedians.Add(p2);
            Engine.pointsMedians.Add(p3);
            Engine.drawMedians(myGraphics.grp);
            Engine.drawDiagonals(myGraphics.grp);
            myGraphics.refreshGraph();
           // myGraphics.refreshGraph();
        }
    }
}
