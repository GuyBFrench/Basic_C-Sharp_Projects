using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _154_Log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Users\silve\Documents\logs\log.txt", userNumber);

            string returnNumber = File.ReadAllText(@"C:\Users\silve\Documents\logs\log.txt");

            Console.WriteLine("This is your number: " + returnNumber);
            Console.ReadLine();
        }
    }
}
