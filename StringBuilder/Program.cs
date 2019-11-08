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

            StringBuilder sb = new StringBuilder();
            sb.Append("This is a string builder.");
            sb.AppendLine();

            sb.Append("It's just for practice so i'm using it");
            sb.AppendLine();

            sb.Append("to make this basic paragraph.");
            sb.AppendLine();

            sb.Append("I hope it works correctly.");
            sb.AppendLine();

            sb.Append("Cause if not that would be not good.");
            sb.AppendLine();

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
