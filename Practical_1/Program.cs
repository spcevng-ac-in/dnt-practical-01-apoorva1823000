using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1
{
    internal class Program
    {
            static int getSum(int n)
            {
                int sum = 0;

                while (n != 0)
                {
                    sum = sum + n % 10;
                    n = n / 10;
                }

                return sum;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"summation of {number1} is {getSum(number1)}");
            Console.ReadLine();

        }
    }
}
