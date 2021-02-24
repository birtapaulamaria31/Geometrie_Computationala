using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditia_de_coliniaritate_dintre_3_puncte
{
    class Program
    {
        static void Main(string[] args)
        {
            int xA, yA, xB, yB, xC, yC, determinantColiniaritate;
          
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
            Console.WriteLine();

            Console.WriteLine("Introduceti coordonatele punctului C.");
            Console.Write("Introduceti x pentru punctul C: ");
            xC = Int32.Parse(Console.ReadLine());
            Console.Write("Introduceti y pentru punctul C: ");
            yC = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            determinantColiniaritate = xA * yB + xB * yC + xC * yA + xC * yB * (-1) + xB * yA * (-1) + xA * yC * (-1);
            if (determinantColiniaritate == 0)
                Console.WriteLine("Punctele SUNT coliniare");
            else
                Console.WriteLine("Punctele NU SUNT coliniare");

            Console.ReadKey();

        }
    }
}
