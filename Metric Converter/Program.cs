using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputData = double.Parse(Console.ReadLine());
            var inputUnit = Console.ReadLine();
            var outputUnit = Console.ReadLine();

            var unitInM = 0.0;
            var outputData = 0.0;

            if (inputUnit == "m")
            {
                unitInM = inputData;
            }
            else if (inputUnit == "mm")
            {
                unitInM = inputData / 1000;
            }
            else if (inputUnit == "cm")
            {
                unitInM = inputData / 100;
            }
            else if (inputUnit == "mi")
            {
                unitInM = inputData / 0.000621371192;
            }
            else if (inputUnit == "in")
            {
                unitInM = inputData / 39.3700787;
            }
             else if (inputUnit == "km")
            {
                unitInM = inputData / 0.001;
            }
             else if (inputUnit == "ft")
            {
                unitInM = inputData / 3.2808399;
            }
             else if (inputUnit == "yd")
            {
                unitInM = inputData / 1.0936133;
            }

            //////////////

            if (outputUnit == "m")
            {
                outputData = unitInM;
            }
            else if (outputUnit == "mm")
            {
                outputData = unitInM * 1000;
            }
            else if (outputUnit == "cm")
            {
                outputData = unitInM * 100;
            }
            else if (outputUnit == "mi")
            {
                outputData = unitInM * 0.000621371192;
            }
            else if (outputUnit == "in")
            {
                outputData = unitInM * 39.3700787;
            }
            else if (outputUnit == "km")
            {
                outputData = unitInM * 0.001;
            }
            else if (outputUnit == "ft")
            {
                outputData = unitInM * 3.2808399;
            }
            else if (outputUnit == "yd")
            {
                outputData = unitInM * 1.0936133;
            }

            Console.WriteLine("{0} {1}",outputData, outputUnit);
        }
    }
}
