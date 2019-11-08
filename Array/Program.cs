using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "Hello", "Hola", "Malo e lelei", "Kon'nichiwa", "Namaskāra", "dobroho ranku" };

            Console.WriteLine("Please enter a number 0-5, I will say Hello in one of several Languages.");
            int userArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray[userArray]);
            Console.ReadLine();

            int[] intArray = new int[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            Console.WriteLine("Please enter a number 0-9, I will multiply it by 10");
            int userInt = Convert.ToInt32(Console.ReadLine());
            if (userInt > 5) {
                Console.WriteLine("That number does not work, sorry.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(intArray[userInt]);
                Console.ReadLine();
            }

            List<string> stringList = new List<string>();
            stringList.Add("Goodbye");
            stringList.Add("Adios");
            stringList.Add("Ofa atu");
            stringList.Add("Sayōnara");
            stringList.Add("Alavidā");
            stringList.Add("do pobachennya");

            Console.WriteLine("Please enter a number 0-5, I will say Goobye in one of several Languages.");
            int userList = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[userList]);
            Console.ReadLine();




        }
    }
}
