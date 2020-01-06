using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadRE
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Benhem = new Employee();
            Employee employee2 = new Employee();

            employee2.Id = 0001;
            employee2.Name = "Talbot";

            Benhem.Id = 0002;
            Benhem.Name = "Benhem";

            bool isEmployee = Benhem == employee2;

            Console.WriteLine("Does " + Benhem.Name + " and " + employee2.Name + "s employee Ids match? " + isEmployee);
            Console.ReadLine();
        }
    }
}
