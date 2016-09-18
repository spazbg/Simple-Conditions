using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var kmInput = double.Parse(Console.ReadLine());
            var DayNight = Console.ReadLine();
            double CheapTravel = 0.0;

            if (kmInput >= 100)
            {
                CheapTravel = kmInput * 0.06;
                Console.WriteLine(String.Format("{0:0.##}", CheapTravel));
            }
            else if (kmInput >= 20)
            {
                CheapTravel = kmInput * 0.09;
                Console.WriteLine(String.Format("{0:0.##}", CheapTravel));
            }
            else
            {
                if (DayNight == "day")
                {
                    CheapTravel = 0.70 + kmInput * 0.79;
                }
                else
                {
                    CheapTravel = 0.70 + kmInput * 0.90;
                }

                Console.WriteLine(String.Format("{0:0.##}",CheapTravel));
            }
        }
    }
}
