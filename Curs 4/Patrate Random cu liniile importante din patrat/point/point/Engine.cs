using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace point
{
    public static class Engine
    {
        public static List<myPoint> points = new List<myPoint>();
        public static List<myPoint> pointsMedians = new List<myPoint>();
        public static void draw (Graphics grp)
        {
            for (int i = 0; i < points.Count - 1; i++)
                grp.DrawLine(Pens.Black, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            grp.DrawLine(Pens.Black, points[points.Count - 1].X, points[points.Count - 1].Y, points[0].X, points[0].Y);
            foreach (myPoint p in points)
                p.draw(grp);
        }

        public static void drawMedians(Graphics grp)
        {
            for (int i = 0; i <2; i=i+1)
                grp.DrawLine(Pens.Red, pointsMedians[i].X, pointsMedians[i].Y, pointsMedians[i+2].X, pointsMedians[i+2].Y);
            foreach (myPoint p in pointsMedians)
                p.draw(grp);
        }

        public static void drawDiagonals(Graphics grp)
        {
            grp.DrawLine(Pens.Blue, points[0].X, points[0].Y, points[2].X, points[2].Y);
            grp.DrawLine(Pens.Blue, points[1].X, points[1].Y, points[3].X, points[3].Y);
        }

        public static void remove() 
        {
            points.RemoveAt(points.Count - 1);
        }

        //d
        //arie
        //alg Graham
        //alg Jarvis
        //alg ...

    }
}
