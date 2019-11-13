  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 leVoid = new Class1();

            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            leVoid.theVoid(userInput);

            Console.ReadLine();
        }
    }
}
