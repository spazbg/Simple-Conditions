using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());

            if (numb > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else if (numb >= 100)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Less than 100");
            }
        }
    }
}
