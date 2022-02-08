using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"summation of {number1} and {number2} is {number1+number2}");
            Console.ReadLine();

        }
    }
}
