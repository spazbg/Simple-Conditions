using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = Console.ReadLine();

            if (form == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.###}", a * a);
            }
            else if (form == "rectangle")
            {
                var b = double.Parse(Console.ReadLine());
                var c = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.###}", b * c);
            }
            else if (form == "circle")
            {
                var d = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.###}", Math.PI * (d * d));
            }
            else if (form == "triangle")
            {
                var e = double.Parse(Console.ReadLine());
                var f = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.###}",(e * f)/2);
            }
        }
    }
}
