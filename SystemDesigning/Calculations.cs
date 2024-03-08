using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesigning
{
    internal class Calculations
    {
        public void Add()
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = " + a);
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = " + b);
            int c = a + b;
            Console.WriteLine("Addition of a and b is = " + c);
        }
    }
}
