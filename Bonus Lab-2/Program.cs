using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a number ");
            Console.WriteLine();

            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("You just entered: " + userInput);

            int finalAnswer = userInput + 1;

            Console.WriteLine("Final answer: " + finalAnswer);


        }
    }
}
