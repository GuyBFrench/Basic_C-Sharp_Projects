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


            EmployeesId.Things.Add(0001);
            EmployeesId.Things.Add(0002);
            EmployeesId.Things.Add(0003);

            Names.Things.Add("Benhem");
            Names.Things.Add("Talbot");
            Names.Things.Add("Pete");
            Names.Things.Add("Kate");

            foreach (string item in Names.Things)
            {
                Console.WriteLine(item);
            }
            foreach (int item in EmployeesId.Things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
