using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine("What is your age?");
            int personAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have You ever had a DUI? True or False.");
            bool personDui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int personTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you Qualify?");
            bool personQualify = (personAge > 15 && personDui == false && personTickets <= 3);
            Console.WriteLine(personQualify);
            Console.ReadLine();

        }
    }
}
