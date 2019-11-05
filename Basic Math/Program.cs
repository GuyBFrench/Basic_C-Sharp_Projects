using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number such as 17 or 524.");
            int multiplyFifty = Convert.ToInt32(Console.ReadLine());
            int multiplyResult = multiplyFifty * 50;
            Console.WriteLine(multiplyResult);

            Console.WriteLine("Input a number such as 19 or 52.");
            int addTwentyFive = Convert.ToInt32(Console.ReadLine());
            int addResult = addTwentyFive + 25;
            Console.WriteLine(addResult);

            Console.WriteLine("Input a number such as 193 or 5847.");
            Double divideTwelve = Convert.ToDouble(Console.ReadLine());
            Double divideResult = divideTwelve / 12.5;
            Console.WriteLine(addResult);

            Console.WriteLine("Input a number such as 13 or 86.");
            int greaterThan = Convert.ToInt32(Console.ReadLine());
            if (greaterThan < 50)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("Input a number such as 189 or 86752.");
            int remainderInput = Convert.ToInt32(Console.ReadLine());
            int remainderNumber = remainderInput % 7;
            Console.WriteLine(remainderNumber);
            Console.ReadLine();
        }
    }
}
