using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            if (a > b)
                return a - b;
            else
                return -1;
        }
        public static int Multiply(int a, int b)
        {
            return (a * b);
        }
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero");
                return a / a;
            }
            else 
                return a / b;
        }
    }
}
