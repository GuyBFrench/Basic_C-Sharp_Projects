using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please write the weight of your package in pounds.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please insert package width in inches.");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please insert package height in inches.");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            if (packageHeight + packageWidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            double packageSum = (packageHeight + packageWidth) * packageWeight;
            double packagePrice = packageSum / 100;

            Console.WriteLine("The estimated total to ship this package is: $" + packagePrice);
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
