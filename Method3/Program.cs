using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many chicken tacos you want");
            int numChicken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter how many fish tacos you dont have to get any.");
            string numFish = Console.ReadLine();

            Taco taco = new Taco();
            int totalTacos;
            Console.WriteLine("Your total number of tacos is: ");

            if (Int32.TryParse(numFish, out totalTacos))
            {
                Console.WriteLine(taco.tacos(numChicken, totalTacos));
            }
            else
            {
                Console.WriteLine(taco.tacos(numChicken));
            }


            Console.ReadLine();


        }
    }
}
