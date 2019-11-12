using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Math math = new Math();

            int addResult = math.Add(userNumber);
            Console.WriteLine("I changed your number by adding 50!! Here: " + addResult);

            int divideResult = math.Divide(userNumber);
            Console.WriteLine("I changed your number by dividing by 2! Here: " + divideResult);

            int subtractResult = math.Subtract(userNumber);
            Console.WriteLine("I changed your number by subtracting 10! Here: " + subtractResult);
            Console.ReadLine();




        }
    }
}
