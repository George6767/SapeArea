using System;

namespace SapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;

            Console.WriteLine("What shape would you like to find the area of? Please enter 'r' for rectangle or any other key for circle.");
            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of the rectangle.");
                float height = GetValidNumber();

                Console.WriteLine("Please enter the width of the rectangle.");
                float width = GetValidNumber();

                result = height * width;
            }
            else
            {
                Console.WriteLine("Please enter the radius of the circle.");
                float radius = GetValidNumber();

                result = (float)Math.PI * (radius * radius);
            }

            Console.WriteLine("The result is " + result);
            Console.ReadKey();
        }

        // Метод для проверки корректного ввода числового значения
        static float GetValidNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (float.TryParse(input, out float number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }
            }
        }
    }
}
