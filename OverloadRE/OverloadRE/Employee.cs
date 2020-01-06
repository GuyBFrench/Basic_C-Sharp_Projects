using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadRE
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
