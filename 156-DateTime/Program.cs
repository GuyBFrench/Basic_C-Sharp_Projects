using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _156_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please enter a number.");
            int userHours = Convert.ToInt32(Console.ReadLine());

            DateTime timeNow = DateTime.Now;
            DateTime addHours = timeNow.AddHours(userHours);
            Console.WriteLine("In that many hours it will be: " + addHours);

            Console.ReadLine();

        }
    }
}
