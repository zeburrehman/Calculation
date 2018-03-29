using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Engine.Interfaces
{
    public interface ICalculator
    {
        decimal Add(decimal valueOne, decimal valueTwo);
        decimal Subtract(decimal valueOne, decimal valueTwo);
        decimal Multiply(decimal valueOne, decimal valueTwo);
        decimal Divide(decimal valueOne, decimal valueTwo);
    }
}
