using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditia_de_concurenta_dintre_3_drepte
{
    class Program
    {

        static void citire(float a1, float b1, float c1)
        {
            Console.WriteLine("Dreapta de forma a1*x + b1*y + c1 = 0. Introduceti coeficientii: ");
            Console.Write("a1 = ");
            a1 = float.Parse(Console.ReadLine());
            Console.Write("b1 = ");
            b1 = float.Parse(Console.ReadLine());
            Console.Write("c1 = ");
            c1 = float.Parse(Console.ReadLine());

            Console.Write("d1: "+ a1 + "x");
            if (b1 < 0)
            {
                Console.Write(" - " + b1 * (-1) + "y");
            }
            else
                Console.Write(" + " + b1 + "y");
            if (c1 < 0)
                Console.Write(" - " + c1 * (-1));
            else
                Console.Write(" + " + c1);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            float a1,a2,a3,b1,b2,b3,c1,c2,c3;

            Console.WriteLine("Dreapta de forma a1*x + b1*y + c1 = 0. Introduceti coeficientii: ");
            Console.Write("a1 = ");
            a1 = float.Parse(Console.ReadLine());
            Console.Write("b1 = ");
            b1 = float.Parse(Console.ReadLine());
            Console.Write("c1 = ");
            c1 = float.Parse(Console.ReadLine());

            Console.Write("d1: " + a1 + "x");
            if (b1 < 0)
            {
                Console.Write(" - " + b1 * (-1) + "y");
            }
            else
                Console.Write(" + " + b1 + "y");
            if (c1 < 0)
                Console.Write(" - " + c1 * (-1));
            else
                Console.Write(" + " + c1);
            Console.Write(" = 0 ");
            Console.WriteLine();

            Console.WriteLine("Dreapta de forma a2*x + b2*y + c2 = 0. Introduceti coeficientii: ");
            Console.Write("a2 = ");
            a2 = float.Parse(Console.ReadLine());
            Console.Write("b2 = ");
            b2 = float.Parse(Console.ReadLine());
            Console.Write("c2 = ");
            c2 = float.Parse(Console.ReadLine());

            Console.Write("d2: " + a2 + "x");
            if (b2 < 0)
            {
                Console.Write(" - " + b2 * (-1) + "y");
            }
            else
                Console.Write(" + " + b2 + "y");
            if (c2 < 0)
                Console.Write(" - " + c2 * (-1));
            else
                Console.Write(" + " + c2);
            Console.Write(" = 0 ");
            Console.WriteLine();

            Console.WriteLine("Dreapta de forma a3*x + b3*y + c3 = 0. Introduceti coeficientii: ");
            Console.Write("a3 = ");
            a3 = float.Parse(Console.ReadLine());
            Console.Write("b3 = ");
            b3 = float.Parse(Console.ReadLine());
            Console.Write("c3 = ");
            c3 = float.Parse(Console.ReadLine());

            Console.Write("d3: " + a3 + "x");
            if (b3 < 0)
            {
                Console.Write(" - " + b3 * (-1) + "y");
            }
            else
                Console.Write(" + " + b3 + "y");
            if (c3 < 0)
                Console.Write(" - " + c3 * (-1));
            else
                Console.Write(" + " + c3);
            Console.Write(" = 0 ");
            Console.WriteLine();

            float determinant;
            determinant= a1 * b2 * c3 + a2 * b3 * c1 + a3 * b1 * c2 +(-1)* a3 * b2 * c1 + (-1) * a2 * b1 * c3 + (-1) * a1 * b3 * c2;
            if (determinant == 0)
                Console.WriteLine("Dreptele SUNT concurente.");
            else
                Console.WriteLine("Dreptele NU SUNT concurente.");

            Console.ReadKey();
        }
    }
}
