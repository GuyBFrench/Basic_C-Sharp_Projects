using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _137_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();

            number.Amount = 12;

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }

    public struct Number
    {
        public decimal Amount;
    }
}
