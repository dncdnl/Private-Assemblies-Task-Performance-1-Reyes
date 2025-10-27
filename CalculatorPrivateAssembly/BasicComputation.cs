using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        // Creating 4 static methods for basic arithmetic operations
        // Addition
        public static float Add(float a, float b)
        {
            return a + b;
        }
        // Subtraction
        public static float Subtract(float a, float b)
        {
            return a - b;
        }
        // Multiplication
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
        // Division
        public static float Divide(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }
}
