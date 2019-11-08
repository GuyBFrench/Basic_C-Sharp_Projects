using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "My name is Benhem, ";
            string myHome = "my home is in Texas,";
            string myFav = " and my favorite color is green.";
            Console.WriteLine(myName + myHome + myFav);
            Console.ReadLine();


            string lowerCase = "My name is Achilles";
            string upperCase = lowerCase.ToUpper();
            Console.WriteLine(upperCase);
            Console.ReadLine();

            StringBuilder myString = new StringBuilder();
            myString.Append("This is a string builder.");
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
