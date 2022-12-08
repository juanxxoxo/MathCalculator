using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class High
    {
        int a;
        int b;

        public void highCal()
        {
            Console.WriteLine("Enter value A: ");
            a = Convert.ToInt32(Console.ReadLine()); //This will convert value A to an integer in order to store it before calculating

            Console.WriteLine("Enter value B: ");
            b = Convert.ToInt32(Console.ReadLine()); //This will convert value B to an integer in order to store it before calculating

            Console.WriteLine("The highest value is: " + Math.Max(a, b)); //The a and b parameters represent the A and B user input values
        }
    }
}
