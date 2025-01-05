using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;

            Console.WriteLine("What shape wold you like to find the area of? Please enter 'r' rectangle or other key for circle.");

            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of the rectangle.");
                float height = float.Parse(Console.ReadLine());
            }
        }
    }
}
