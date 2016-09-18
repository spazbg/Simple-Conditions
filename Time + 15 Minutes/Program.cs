using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hh = int.Parse(Console.ReadLine());
            var mm = int.Parse(Console.ReadLine());

            int totalMM = hh * 60 + mm + 15;
            int finalHh = totalMM / 60;
            int finalMM = totalMM% 60;

            if (totalMM >= 1440)
            {
                Console.WriteLine("0:{1:00}", finalHh, finalMM);
            }
            else
            {
                Console.WriteLine("{0}:{1:00}", finalHh, finalMM);
            }
        }
    }
}
