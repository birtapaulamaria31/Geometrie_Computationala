using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_2
{



    class Program
    {
        /*static int CitireDoiVectori()
        {

            
        }*/

        static void Problemele1si2()
        {
            int x1, x2, x3, y1, y2,y3,z1,z2,z3,produsScalar;
            ///  static int CitireDoiVectori();

            Console.WriteLine("Introdu coordonatele vectorului v1: ");
            Console.Write("x = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = ");
            z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdu coordonatele vectorului v2: ");
            Console.Write("x = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = ");
            z2 = Convert.ToInt32(Console.ReadLine());


            Console.Write($"v1 = {x1} i ");
            if(y1<0)
            {
                Console.Write($"- { -y1} j ");
            }
            else if(y1>0)
                Console.Write($"+ {y1} j ");
            if (z1 < 0)
            {
                Console.Write($"- { -z1} k ");
            }
            else if (z1 > 0)
                Console.WriteLine($"+ {z1} k ");

           // Console.WriteLine();

            Console.Write($"v2 = {x2} i ");
            if (y2 < 0)
            {
                Console.Write($"- { -y2} j");
            }
            else if (y2 > 0)
                Console.Write($"+ {y2} j ");
            if (z2 < 0)
            {
                Console.Write($"- { -z2} k ");
            }
            else if (z2 > 0)
                Console.WriteLine($"+ {z2} k ");
       
            produsScalar = x1 * x2 + y1 * y2 + z1 * z2;
            Console.WriteLine();
            Console.WriteLine($"Produsul scalar: v1*v2 ={produsScalar}");
            if (produsScalar == 0)
                Console.WriteLine("Vectorii sunt perpendiculari. ");
            else
                Console.WriteLine("Vectorii nu sunt perpendiculari. ");
            Console.WriteLine($"Marimea lui v1: {Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1)}");
            Console.WriteLine($"Marimea lui v2: {Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2)}");


            ///Problema 2
            ///****************************************************************
            Console.WriteLine();
            
            Console.WriteLine("**********************Problema 2**********************");
            Console.WriteLine();
            double coefi, coefj, coefk;
            coefi = y1 * z2 - y2 * z1;
            coefj = x2 * z1 - x1 * z2;
            coefk = x1 * y2 - x2 * y1;

         

            if(coefi==0 && coefj==0 && coefk==0)
            {
                Console.WriteLine("Produsul vectorial: 0");
                Console.WriteLine("Vectorii sunt coliniari.");
            }
            else
            {
                Console.Write($"Produsul vectorial: {coefi} i ");
                if (coefj < 0)
                {
                    Console.Write($"{coefj} j ");
                }
                else Console.Write($"+ {coefj} j ");
                if (coefk < 0)
                {
                    Console.WriteLine($"{coefk} k ");
                }
                else Console.WriteLine($"+ {coefk} k ");
                Console.WriteLine("Vectorii nu sunt coliniari.");
            }
            double aria;
            aria = Math.Sqrt(coefi * coefi + coefj * coefj + coefk * coefk);
            Console.WriteLine($"Aria: {aria}");



            Console.ReadKey();
        }

        static void Problema3()
        {
            int x1, x2, x3, y1, y2, y3, z1, z2, z3, produsVectorial;
            int coefi, coefj, coefk;
             Console.WriteLine("Introdu coordonatele vectorului v1: ");
             Console.Write("x = ");
             x1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("y = ");
             y1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("z = ");
             z1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Introdu coordonatele vectorului v2: ");
             Console.Write("x = ");
             x2 = Convert.ToInt32(Console.ReadLine());
             Console.Write("y = ");
             y2 = Convert.ToInt32(Console.ReadLine());
             Console.Write("z = ");
             z2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introdu coordonatele vectorului v3: ");
            Console.Write("x = ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z = ");
            z3 = Convert.ToInt32(Console.ReadLine());

            Console.Write($"v1 = {x1} i ");
            if (y1 < 0)
            {
                Console.Write($"- { -y1} j ");
            }
            else if (y1 > 0)
                Console.Write($"+ {y1} j ");
            if (z1 < 0)
            {
                Console.Write($"- { -z1} k ");
            }
            else if (z1 > 0)
                Console.WriteLine($"+ {z1} k ");

            // Console.WriteLine();

            Console.Write($"v2 = {x2} i ");
            if (y2 < 0)
            {
                Console.Write($"- { -y2} j");
            }
            else if (y2 > 0)
                Console.Write($"+ {y2} j ");
            if (z2 < 0)
            {
                Console.Write($"- { -z2} k ");
            }
            else if (z2 > 0)
                Console.WriteLine($"+ {z2} k ");
            Console.WriteLine();
            Console.Write($"v3 = {x3} i ");
            if (y3 < 0)
            {
                Console.Write($"- { -y3} j");
            }
            else if (y3 > 0)
                Console.Write($"+ {y3} j ");
            if (z3 < 0)
            {
                Console.Write($"- { -z3} k ");
            }
            else if (z3 > 0)
                Console.WriteLine($"+ {z3} k ");
            Console.WriteLine();
            int produsMixt,volum;

            produsMixt = x1 * y2 * z3 + x2 * y3 * z1 + x3 * y1 * z2 + (-1) * x3 * y2 * z1 + (-1) * x1 * y3 * z2 + (-1) * x2 * y1 * z3;
            Console.WriteLine();
            Console.WriteLine($"Produsul mixt este: {produsMixt}");
            if (produsMixt == 0)
                Console.WriteLine("Vectorii sunt coplanari.");
            else    Console.WriteLine("Vectorii NU sunt coplanari.");
            volum = Math.Abs(produsMixt);
            Console.WriteLine($"Volumul paralelipipedului este: {volum}");
            Console.ReadKey();
            




        }

        static void Main(string[] args)
        {
            //Problemele1si2();
            Problema3();

        }
    }
}
