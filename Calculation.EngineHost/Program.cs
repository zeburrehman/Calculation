using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation.Engine.Implementations;
using Calculation.Engine.Interfaces;

namespace Calculation.EngineHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator cal = new Calculator();
            Console.WriteLine(cal.Add(12.7m, 34.2m));
            Console.ReadKey();
        }
    }
}
