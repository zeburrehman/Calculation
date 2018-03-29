using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation.Engine.Interfaces;

namespace Calculation.Engine.Implementations
{
    public class Calculator : ICalculator
    {
        public decimal Add(decimal valueOne, decimal valueTwo)
        {
            return valueOne + valueTwo;
        }

        public decimal Subtract(decimal valueOne, decimal valueTwo)
        {
            return valueOne - valueTwo;
        }

        public decimal Multiply(decimal valueOne, decimal valueTwo)
        {
            return valueOne * valueTwo;
        }

        public decimal Divide(decimal valueOne, decimal valueTwo)
        {
            return valueOne / valueTwo;
        }
    }
}
