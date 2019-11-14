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
            Employee Sample = new Employee();
            Sample.firstName = "Sample";
            Sample.lastName = "Student";

            Sample.SayName();
            Console.ReadLine();

            IQuitable quitable = new Employee();
            quitable.Quit();

            Console.ReadLine();
        }
    }
}
