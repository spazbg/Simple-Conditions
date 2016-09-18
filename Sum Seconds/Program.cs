using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var runer1 = int.Parse(Console.ReadLine());
            var runer2 = int.Parse(Console.ReadLine());
            var runer3 = int.Parse(Console.ReadLine());

            var totalSec = runer1 + runer2 + runer3;

            int totalMin = totalSec / 60;
            int seconds = totalSec % 60;

            if (seconds < 10)
            {
                Console.WriteLine("{0}:0{1}", totalMin, seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", totalMin, seconds);
            }
                   
        }
    }
}
