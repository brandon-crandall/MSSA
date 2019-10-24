using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            double weight;
            Console.Write("Enter weight in pounds!");
            userInput = Console.ReadLine();
            weight = Convert.ToDouble(userInput);

            double height;
            Console.Write("Enter your height in inches!");
            userInput = Console.ReadLine();
            height = Convert.ToDouble(userInput);

            double bmi = (weight * 703) / (height * height);

            if (bmi > 30)
            {
                Console.WriteLine("Obese");
            }
            else if (25 <= bmi && bmi <= 29.9)
            {
                Console.WriteLine("Overweight");
            }
            else if (18.5 <= bmi && bmi <= 24.9)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else
            {
                return;
            }
            Console.ReadLine();
        }
    }
}
