using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HWModel2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Attempts to open a file that does not exist so the code will 
            //catch the exception.
            try
            {
                FileStream x = File.Open("C:\\Temp", FileMode.Open);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("{0} File not found.", e.Source);
            }
            Console.ReadLine();
            

            //Calling the Multi method below and printing it to console.
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Multi(input, out var msg));
            Console.WriteLine(msg);
            Console.ReadLine();

        }

        //Creating a method with more then one return value using a random math equation.
        static int Multi(int num, out string even)
        {
            int x = (num + num - 1) * 3 / num;
            if (x % 2 == 0)
            {
                even = "This number is even.";
            }
            else
            {
                even = "This number is odd.";
            }
            return x;
        }

    }
}
