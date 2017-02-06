using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class calculator
    {
        public double add(double a, double b)
        {
            double result = 0;

            result = a + b;
            return result;
        }
        public double substract(double a, double b)
        {
            double result = 0;

            result = a - b;
            return result;
        }
        public double multiply(double a, double b)
        {
            double result = 0;

            result = a * b;
            return result;
        }
        public double power(double x, double exp)
        {
            double result = 0;

            result = System.Math.Pow(x, exp);
            return result;
        }
    }
}
