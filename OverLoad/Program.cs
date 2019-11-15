using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Benhem = new Employee();
            Benhem.Name = "Benhem";
            Employee Talbot = new Employee();
            Talbot.Name = "Student";

            bool isName = Benhem == Talbot;


            Console.WriteLine("Is Benhem equal to Talbot?: " + isName);
            Console.ReadLine();
        }
    }
}
