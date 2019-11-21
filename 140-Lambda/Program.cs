using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee First = new Employee() { Id = 1, firstName = "Pete", lastName = "Johnson" };
            Employee Second = new Employee() { Id = 2, firstName = "Alison", lastName = "Dalmer" };
            Employee Third = new Employee() { Id = 3, firstName = "Aaron", lastName = "O'Rielly" };
            Employee Fourth = new Employee() { Id = 4, firstName = "Guy", lastName = "Andrew" };
            Employee Fifth = new Employee() { Id = 5, firstName = "Joe", lastName = "Johnson" };
            Employee Sixth = new Employee() { Id = 6, firstName = "Jacob", lastName = "Ehlers" };
            Employee Seventh = new Employee() { Id = 7, firstName = "Emily", lastName = "Otea" };
            Employee Eighth = new Employee() { Id = 8, firstName = "Joe", lastName = "Solana" };
            Employee Ninth = new Employee() { Id = 9, firstName = "Elizabeth", lastName = "French" };
            Employee Tenth = new Employee() { Id = 10, firstName = "John", lastName = "Jackson" };


            List<Employee> employees = new List<Employee>() { First, Second, Third, Fourth, Fifth, Sixth, Seventh, Eighth, Ninth, Tenth };

            List<Employee> peoples = new List<Employee>();



            List<Employee> persons = new List<Employee>();


            foreach (Employee person in employees)
            {
                if (person.firstName == "Joe")
                {
                    persons.Add(person);
                }
            }

            List<Employee> humans = employees.FindAll(x => x.firstName == "Joe");


            List<Employee> theList = employees.FindAll(x => x.Id > 5);






            Console.ReadLine();




        }
        public class Employee
        {
            public int Id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
        }
    }
}
