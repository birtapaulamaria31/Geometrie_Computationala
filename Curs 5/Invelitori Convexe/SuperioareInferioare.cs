﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invelitori_Convexe
{
    public class SuperiorInferior
    {
        private static Graphics gfx;
        public static void SepararePlanuri(List<Form1.point> points, PaintEventArgs e)
        {
            List<Form1.point> pct = Sortare(points);      //Sorteaza punctele dupa abscisa
            List<Form1.point> PlanSuperior = new List<Form1.point>();
            List<Form1.point> PlanInferior = new List<Form1.point>();
            //Adauga primele doua puncte din pct cu pct[0] ca prim punct
            PlanSuperior.Add(Form1.points[0]);
            PlanSuperior.Add(Form1.points[1]);
            for (int i = 2; i < Form1.points.Count; i++)
            {
                PlanSuperior.Add(Form1.points[i]);
                //Cat timp card(PlanSuperior) > 2
                while (PlanSuperior.Count > 2 && Orientation(PlanSuperior[PlanSuperior.Count - 1], PlanSuperior[PlanSuperior.Count - 2], PlanSuperior[PlanSuperior.Count - 3]) != 1)
                {
                    //Daca ultimele tre puncte nu efectueaza o intoarcere la dreapta, sterge
                    //punctul din mijlocul celor 3
                    PlanSuperior.Remove(PlanSuperior[PlanSuperior.Count - 2]);
                }
            }
            //Adauga ultimele doua puncte din pct cu pct[n] ca prim punct
            PlanInferior.Add(pct[pct.Count - 1]);
            PlanInferior.Add(pct[pct.Count - 2]);
            for (int i = pct.Count - 3; i >= 0; i--)
            {
                PlanInferior.Add(pct[i]);
                //Cat timp card(PlanInferior) > 2
                while (PlanInferior.Count > 2 && Orientation(PlanInferior[PlanInferior.Count - 1], PlanInferior[PlanInferior.Count - 2], PlanInferior[PlanInferior.Count - 3]) != 1)
                {
                    //Daca ultimele trei puncte nu efectueaza o intoarcere la dreapta, sterge punctul din mijlocul celor 3
                    PlanInferior.Remove(PlanInferior[PlanInferior.Count - 2]);
                }
            }
          /*  for (int i = 0; i < PlanSuperior.Count - 1; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue), PlanSuperior[i], PlanSuperior[i + 1]);
            }*/



            for (int i = 1; i < PlanSuperior.Count; i++)
            {
                gfx.DrawLine(Pens.Black, PlanSuperior[i].X, PlanSuperior[i].Y, PlanSuperior[i - 1].X, PlanSuperior[i - 1].Y);
            }

            int len = PlanSuperior.Count;

            gfx.DrawLine(Pens.Black, PlanSuperior[len - 1].X, PlanSuperior[len - 1].Y, PlanSuperior[0].X, PlanSuperior[0].Y);

          /*  for (int i = 0; i < PlanInferior.Count - 1; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Orange), PlanInferior[i], PlanInferior[i + 1]);
            }*/
        }

        private static List<Form1.point> Sortare(List<Form1.point> EQ)
        {
            int schimbat = 1;
            do
            {
                schimbat = 0;
                for (int i = 0; i < EQ.Count - 1; i++)
                    if (EQ[i].X > EQ[i + 1].X)
                    {
                        Form1.point aux = EQ[i];
                        EQ[i] = EQ[i + 1];
                        EQ[i + 1] = aux;
                        schimbat = 1;
                    }
                    else if (EQ[i].X == EQ[i + 1].X)
                    {
                        if (EQ[i].Y > EQ[i + 1].Y)
                        {
                            Form1.point aux = EQ[i];
                            EQ[i] = EQ[i + 1];
                            EQ[i + 1] = aux;
                            schimbat = 1;
                        }
                    }
            }
            while (schimbat == 1);
            return EQ.ToList();
        }

        private static int Orientation(Form1.point p1, Form1.point p2, Form1.point p)
        {
            // Determinant
            float Orin = (p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y);

            if (Orin > 0)
                return -1; //Orientarea este de la stanga la dreapta
            if (Orin < 0)
                return 1; //Orientarea este de la dreapta la stanga

            return 0; //Sunt colinieare
        }
    }
}

