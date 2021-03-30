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

        private void btn_addPoint_Click(object sender, EventArgs e)
        {
            float X = float.Parse(textBox1.Text);
            float Y = float.Parse(textBox2.Text);
            Engine.points.Add(new myPoint(X, Y));
            Engine.draw(myGraphics.grp);
            myGraphics.refreshGraph();
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
            int len = Engine.points.Count;
            point.myPoint p0 = new point.myPoint();
            point.myPoint p1 = new point.myPoint();
            point.myPoint p2 = new point.myPoint();
            p2.X = (Engine.points[0].X + Engine.points[1].X) / 2;
            p2.Y = (Engine.points[0].Y + Engine.points[1].Y) / 2;
            p0.X = (Engine.points[1].X + Engine.points[2].X) / 2;
            p0.Y = (Engine.points[1].Y + Engine.points[2].Y) / 2;
            p1.X = (Engine.points[0].X + Engine.points[2].X) / 2;
            p1.Y = (Engine.points[0].Y + Engine.points[2].Y) / 2;
            Engine.pointsMedians.Add(p0);
            Engine.pointsMedians.Add(p1);
            Engine.pointsMedians.Add(p2);
            Engine.drawMedians(myGraphics.grp);
            myGraphics.refreshGraph();
           // myGraphics.refreshGraph();
        }
    }
}
