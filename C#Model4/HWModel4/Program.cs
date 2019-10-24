using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModel4
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightInKilos = 80;
            //I learned that when using a method from static class you have to 
            //call the method on the Class name.
            double weightInPounds = Conversions.KilosToPounds(weightInKilos);
            Console.WriteLine($"Here we are using a static class and its method to convert " +
                $"{weightInKilos} kilos to {weightInPounds} pounds");
            Console.ReadLine();

            // Create some instances of the Coffee class.
            Coffee coffee1 = new Coffee();
            coffee1.AverageRating = 4.5;
            Coffee coffee2 = new Coffee();
            coffee2.AverageRating = 8.1;
            Coffee coffee3 = new Coffee();
            coffee3.AverageRating = 7.1;
            // Add the Coffee instances to an ArrayList.
            ArrayList coffeeList = new ArrayList();
            coffeeList.Add(coffee1);
            coffeeList.Add(coffee2);
            coffeeList.Add(coffee3);
            // Sort the ArrayList by average rating.
            coffeeList.Sort();

            //In order to print out the values, we have to override the ToString method
            //because otherwise it will just show us the type.
            Console.WriteLine("Here are the sorted values of the arraylist");
            foreach (var drink in coffeeList)
                Console.WriteLine(drink);
            Console.ReadLine();
        }
    }

    //Here we are creating a static class because we don't want
    //to create an object. We just want to have a class from
    //which we can class methods.
    public static class Conversions
    {
        //If the class is static then the methods and constructors
        //must also be static.
        public static double PoundsToKilos(double pounds)
        {
            // Convert argument from pounds to kilograms
            double kilos = pounds * 0.4536;
            return kilos;
        }
        public static double KilosToPounds(double kilos)
        {
            // Convert argument from kilograms to pounds
            double pounds = kilos * 2.205;
            return pounds;
        }
    }
    //Learned on to create custom sort conditions for sorting an array.
    //Really what Icomparer is doing is assigning a value of -1 if the first
    //value is less then the 2nd, 0 if the two values are equal, and 1 if the
    //first value is greater then the 2nd.

    public class Coffee : IComparable
    {
        public double AverageRating { get; set; }
        public string Variety { get; set; }
        int IComparable.CompareTo(object obj)
        {
            Coffee coffee1 = this;
            Coffee coffee2 = (Coffee)obj;
            return coffee1.AverageRating.CompareTo(coffee2.AverageRating);
        }
        public void PrintStudent()
        {
            Console.WriteLine($"{AverageRating}");
        }
        public override string ToString()
        {
            return String.Format($"{AverageRating}");
        }
    }

}
