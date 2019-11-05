using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your Hourly Rate.");
            double firstHourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your Hours worked per Week.");
            int firstWeek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your Hourly Rate.");
            double secondHourly = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your Hours worked per Week.");
            int secondWeek = Convert.ToInt32(Console.ReadLine());

            double firstSalary = firstHourly * firstWeek;
            Console.WriteLine("Person 1 has a weekly salary of " + firstSalary + " dollars.");

            double secondSalary = secondHourly * secondWeek;
            Console.WriteLine("Person 2 has a weekly salary of " + secondSalary + " dollars.");

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (firstSalary > secondSalary)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();

        }
    }
}
