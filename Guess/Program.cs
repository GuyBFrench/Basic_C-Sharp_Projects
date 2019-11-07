using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my age.");
            int myAge = Convert.ToInt32(Console.ReadLine());
            bool userAnswer = myAge == 23;

            while (!userAnswer)
            {
                switch (myAge)
                {
                    case 100:
                        Console.WriteLine("You Guessed 100. I am not that old yet, dang....");
                        Console.WriteLine("Guess my age.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 1:
                        Console.WriteLine("You Guessed 1. That would be pretty weird honestly. Though Impressive in its own right, a 1 year old who can write basic C#?");
                        Console.WriteLine("Guess my age.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 22:
                        Console.WriteLine("You Guessed 22. Close but that is not correct.");
                        Console.WriteLine("Guess my age.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 24:
                        Console.WriteLine("You Guessed 24. Close but that is not correct.");
                        Console.WriteLine("Guess my age.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 23:
                        Console.WriteLine("You Guessed 23! That is Correct!!!");
                        userAnswer = true;
                        break;
                    default:
                        Console.WriteLine("That is not correct.");
                        Console.WriteLine("Guess my age.");
                        myAge = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.WriteLine("Guess what day of August I was born.");
            int monthDay = Convert.ToInt32(Console.ReadLine());
            bool userDay = monthDay == 31;

            do
            {
                switch (monthDay)
                {
                    case 31:
                        Console.WriteLine("You Guessed 31! That is Correct!!!");
                        userDay = true;
                        break;
                    case 32:
                        Console.WriteLine("You Guessed 32? Months dont go that high lol.");
                        Console.WriteLine("Guess what day of August I was born.");
                        monthDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("You Guessed 30. Close but that is not correct.");
                        Console.WriteLine("Guess what day of August I was born.");
                        monthDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You Guessed 29. Not Quite...");
                        Console.WriteLine("Guess what day of August I was born.");
                        monthDay = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("That is not correct.");
                        Console.WriteLine("Guess what day of August I was born.");
                        monthDay = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                
            }
            while (!userDay);

            Console.ReadLine();
        }
    }
}
