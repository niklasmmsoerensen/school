using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Print();
        }
        public static void Print()
        {
            var calc = new calculator();
            System.Console.WriteLine(calc.add(20, 20));
            System.Console.WriteLine(calc.substract(20, 20));
            System.Console.WriteLine(calc.multiply(20, 20));
            System.Console.WriteLine(calc.power(20, 2));
        }
    }
}
