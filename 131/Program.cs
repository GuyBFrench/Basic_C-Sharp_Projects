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
            Employee<string> Names = new Employee<string>();
            
            Employee<int> EmployeesId = new Employee<int>();

            Names.things.Add("Benhem");
            Names.things.Add("Talbot");
            Names.things.Add("Pete");
            Names.things.Add("Kate");

            EmployeesId.things.Add(23);
            EmployeesId.things.Add(22);
            EmployeesId.things.Add(21);
            EmployeesId.things.Add(26);
            
            foreach (string item in Names.things)
            {
                Console.WriteLine(item);
            }
            foreach (int item in EmployeesId.things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
