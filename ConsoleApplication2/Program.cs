using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = double.Parse(Console.ReadLine());
            var bonusPoints = 0.0;
            var totalPoints = 0.0;

            if (points > 1000)
            {
                bonusPoints = 0.1*points;
            }
            else if (points > 100)
            {
                bonusPoints = 0.20 * points;
            }
            else if(points < 100)
            {
                bonusPoints +=5;
            }
            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (points % 10 == 5)
            {
                bonusPoints += 2;
            }
            totalPoints = points + bonusPoints;

                    Console.WriteLine("{0}",bonusPoints);
                    Console.WriteLine("{0}",totalPoints);

        }
    }
}
