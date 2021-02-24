using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuatia_dreptei
{
    class Program
    {
        static void Main(string[] args)
        {

            int xA, yA, xB, yB, coefX, coefY, termenLiber, ok = 1, okC = 1, termen1, termen2;
            double distanta;
            Console.WriteLine("Introduceti coordonatele punctului A.");
            Console.Write("Introduceti x pentru punctul A: ");
            xA = Int32.Parse(Console.ReadLine());
            Console.Write("Introduceti y pentru punctul A: ");
            yA = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Introduceti coordonatele punctului B.");
            Console.Write("Introduceti x pentru punctul B: ");
            xB = Int32.Parse(Console.ReadLine());
            Console.Write("Introduceti y pentru punctul B: ");
            yB = Int32.Parse(Console.ReadLine());
            coefX = yA - yB;
            coefY = xA - xB;
            if (coefY < 0)
            {
                ok = 0;
                coefY = coefY * -1;
            }
            termenLiber = xA * yB - xB * yA;
            if (termenLiber<0)
            {
                okC = 0;
                termenLiber *= -1;
            }

            Console.WriteLine();
            Console.WriteLine("Ecuatia dreptei: ");

            if(ok==1)
            {
                if(okC==1)
                    Console.WriteLine(coefX + "x - " + coefY + " y + " + termenLiber + "= 0");
                else
                    Console.WriteLine(coefX + "x - " + coefY + " y - " + termenLiber + "= 0");
            }
                
            else if(ok==0)
            {
                if(okC==1)
                    Console.WriteLine(coefX + "x + " + coefY + " y + " + termenLiber + "= 0");
                else
                    Console.WriteLine(coefX + "x + " + coefY + " y - " + termenLiber + "= 0");
            }

            Console.WriteLine("Distanta dintre doua puncte: ");

            termen1 = (xB - xA) * (xB - xA);
            termen2 = (yB - yA) * (yB - yA);
            distanta = termen1 + termen2;
            distanta = Math.Sqrt(distanta);

            Console.Write("|AB| = " + distanta);
            Console.ReadKey();

        }
    }
}
