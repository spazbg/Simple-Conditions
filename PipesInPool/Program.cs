using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            var vInL = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            var totalPipes = pipe1 * hours + pipe2 * hours;

            double poolNow = 0.0;
            double pipe1Now = 0.0;
            double pipe2Now = 0.0;
                               

            if (totalPipes <= vInL)
            {
                poolNow = Math.Truncate((100 * totalPipes) / vInL);
                pipe1Now = Math.Truncate((100 * (pipe1 * hours) / totalPipes));
                pipe2Now = Math.Truncate((100 * (pipe2 * hours) / totalPipes));
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",poolNow, pipe1Now, pipe2Now);

            }
            else
            {
                poolNow = Math.Abs(vInL - totalPipes);
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hours, poolNow);
            }
            
        }
    }
}
