using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int temp = number;

            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            Console.WriteLine("Sum of digits of the number: " + sum);
        }
    }
}





